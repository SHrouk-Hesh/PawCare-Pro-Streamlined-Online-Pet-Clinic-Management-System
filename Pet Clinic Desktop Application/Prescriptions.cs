using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bmd302Project
{
    public partial class Prescriptions : Form
    {
 
        public Prescriptions()
        {
            InitializeComponent();
            ShowPresc();
            GetDoctorId();
            GetPetId(); 

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\20100\Documents\lastPetDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowPresc()
        
        {
            Con.Open();
            string Query = "select * from PrescriptionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PrescDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void GetDoctorId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select DocNum from DoctorTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DocNum", typeof(int));
            dt.Load(rdr);
            DocIdCb.ValueMember = "DocNum";
            DocIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetDoctorName()
        {
            Con.Open();
            string Query = "Select * from DoctorTbl where DocNum =" + DocIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                DocNameTb.Text = dr["DocName"].ToString();
            }
            Con.Close();
        }
        private void GetPetName()
        {
            Con.Open();
            string Query = "Select * from PetTbl where PNum =" + PetIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PetNameTb.Text = dr["PName"].ToString();
            }
            Con.Close();
        }
        private void GetPetId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PNum from PetTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PNum", typeof(int));
            dt.Load(rdr);
            PetIdCb.ValueMember = "PNum";
            PetIdCb.DataSource = dt;
            Con.Close();
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Prescription!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from PrescriptionTbl where PrNum=@PKey", Con);

                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Prescription Deleted!!!");
                    Con.Close();
                    ShowPresc();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocIdCb.SelectedValue = PrescDGV.SelectedRows[0].Cells[1].Value.ToString();
            PetIdCb.SelectedValue = PrescDGV.SelectedRows[0].Cells[2].Value.ToString();

            ExtraTestCb.SelectedItem = PrescDGV.SelectedRows[0].Cells[3].Value.ToString();
            MedicineTb.Text = PrescDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (MedicineTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PrescDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

            if (DocIdCb.SelectedIndex == -1 || PetIdCb.SelectedIndex == -1 || MedicineTb.Text == "" ||  ExtraTestCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update PrescriptionTbl set DocId=@DI,PetId=@PI,ExtTest=@ET,MedList=@ML where PrNum=@PKey", Con);
                    cmd.Parameters.AddWithValue("@DI", DocIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PI", PetIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@ET", ExtraTestCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ML", MedicineTb.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prescription Saved");
                    Con.Close();
                    ShowPresc();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (DocIdCb.SelectedIndex == -1 || PetIdCb.SelectedIndex == -1 || MedicineTb.Text == ""  || ExtraTestCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("insert into PrescriptionTbl(DocId,PetId,ExtTest,MedList)values(@DI,@PI,@ET,@ML)", Con);
                    cmd.Parameters.AddWithValue("@DI", DocIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PI", PetIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@ET", ExtraTestCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ML", MedicineTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prescription Saved");
                    Con.Close();
                    ShowPresc();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            logIn obj = new logIn();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pets obj = new Pets();
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExtraTestCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
