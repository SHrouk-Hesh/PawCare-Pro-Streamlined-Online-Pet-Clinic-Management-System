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
    public partial class AdminOnDoctorView : Form
    {
        public AdminOnDoctorView()
        {
            InitializeComponent();
            ShowDoc();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\20100\Documents\lastPetDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowDoc()
        {
            Con.Open();
            string Query = "select * from DoctorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DocDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AdminOnRec obj = new AdminOnRec();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminOnDoctorView obj = new AdminOnDoctorView();
            obj.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void DNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void DocDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DNameTb.Text = DocDGV.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.Text = DocDGV.SelectedRows[0].Cells[2].Value.ToString();
            AddTb.Text = DocDGV.SelectedRows[0].Cells[3].Value.ToString();
            DDOB.Text = DocDGV.SelectedRows[0].Cells[4].Value.ToString();
            PhoneTb.Text = DocDGV.SelectedRows[0].Cells[5].Value.ToString();
            PassTb.Text = DocDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (DNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DocDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || GenCb.SelectedIndex == -1 || PhoneTb.Text == "" || AddTb.Text == "" || PhoneTb.Text == ""  || PassTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else if (PhoneTb.Text.Length < 12)
            {
                MessageBox.Show("phone number is incorrect, Enter vaild number");
            }
            else if (PhoneTb.Text.Length > 12)
            {
                MessageBox.Show("phone number is incorrect, Enter vaild number");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update DoctorTbl set DocName=@DN,DocGen=@DG,DocAdd=@DA,DocDOB=@DDOB,DocPhone=@DPhone,DocPass=@DPa where DocNum=@DKey", Con);
                    cmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                    cmd.Parameters.AddWithValue("@DG", GenCb.Text);
                    cmd.Parameters.AddWithValue("@DA", AddTb.Text);
                    cmd.Parameters.AddWithValue("@DDOB", DDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DPhone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@DPa", PassTb.Text);
                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Doctor Updated!!!");
                    Con.Close();
                    ShowDoc();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || GenCb.SelectedIndex == -1 || PhoneTb.Text == "" || AddTb.Text == "" || PhoneTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else if (PhoneTb.Text.Length < 12)
            {
                MessageBox.Show("phone number is incorrect, Enter vaild number");
            }
            else if (PhoneTb.Text.Length > 12)
            {
                MessageBox.Show("phone number is incorrect, Enter vaild number");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DoctorTbl(DocName,DocGen,DocAdd,DocDOB,DocPhone,DocPass)values(@DN,@DG,@DA,@DDOB,@DPhone,@DPa)", Con);
                    cmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                    cmd.Parameters.AddWithValue("@DG", GenCb.Text);
                    cmd.Parameters.AddWithValue("@DA", AddTb.Text);
                    cmd.Parameters.AddWithValue("@DDOB", DDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DPhone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@DPa", PassTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Saved");
                    Con.Close();
                    ShowDoc();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
   

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Doctor!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from DoctorTbl where DocNum=@DKey", Con);

                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Doctor Deleted!!!");
                    Con.Close();
                    ShowDoc();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DDOB_onValueChanged(object sender, EventArgs e)
        {

        }

        private void GenCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTb_TextChanged(object sender, EventArgs e)
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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
