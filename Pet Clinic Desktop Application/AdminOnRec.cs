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
    public partial class AdminOnRec : Form
    {
        public AdminOnRec()
        {
            InitializeComponent();
            ShowRec();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\20100\Documents\lastPetDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowRec()
        {
            Con.Open();
            string Query = "select * from ReceptionistTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            RecDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
         private void AddBtn_Click_1(object sender, EventArgs e)
        {
            if (RecName.Text == "" || RecPhone.Text == "" || RecPass.Text == "" || RecAddTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else if (RecPhone.Text.Length < 12)
            {
                MessageBox.Show("phone number is incorrect, Enter vaild number");
            }
            else if (RecPhone.Text.Length > 12)
            {
                MessageBox.Show("phone number is incorrect, Enter vaild number");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ReceptionistTbl(RecName,RecAdd,RecPhone,RecPass)values(@RN,@RA,@RP,@RPa)", Con);
                    cmd.Parameters.AddWithValue("@RN", RecName.Text);
                    cmd.Parameters.AddWithValue("@RA", RecAddTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RecPhone.Text);
                    cmd.Parameters.AddWithValue("@RPa", RecPass.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Recepetionist Saved");
                    Con.Close();
                    ShowRec();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        
    

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (RecName.Text == "" || RecPhone.Text == "" || RecPass.Text == "" || RecAddTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ReceptionistTbl set RecName=@RN,RecAdd=@RA,RecPhone=@RP,RecPass=@RPa where RecNum=@RKey", Con);
                    cmd.Parameters.AddWithValue("@RN", RecName.Text);
                    cmd.Parameters.AddWithValue("@RA", RecAddTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RecPhone.Text);
                    cmd.Parameters.AddWithValue("@RPa", RecPass.Text);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Recepetionist Updated!!!");
                    Con.Close();
                    ShowRec();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }   

    
        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            if (RecName.Text == "" || RecPhone.Text == "" || RecPass.Text == "" || RecAddTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else if (RecPhone.Text.Length < 12)
            {
                MessageBox.Show("phone number is incorrect, Enter vaild number");
            }
            else if (RecPhone.Text.Length > 12)
            {
                MessageBox.Show("phone number is incorrect, Enter vaild number");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ReceptionistTbl set RecName=@RN,RecAdd=@RA,RecPhone=@RP,RecPass=@RPa where RecNum=@RKey", Con);
                    cmd.Parameters.AddWithValue("@RN", RecName.Text);
                    cmd.Parameters.AddWithValue("@RA", RecAddTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RecPhone.Text);
                    cmd.Parameters.AddWithValue("@RPa", RecPass.Text);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Recepetionist Updated!!!");
                    Con.Close();
                    ShowRec();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

       

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ReceptionistTbl where RecNum=@RKey", Con);
                    cmd.Parameters.AddWithValue("@RN", RecName.Text);
                    cmd.Parameters.AddWithValue("@RA", RecAddTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RecPhone.Text);
                    cmd.Parameters.AddWithValue("@RPa", RecPass.Text);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Recepetionist Deleted!!!");
                    Con.Close();
                    ShowRec();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void RecDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RecName.Text = RecDGV.SelectedRows[0].Cells[1].Value.ToString();
            RecAddTb.Text = RecDGV.SelectedRows[0].Cells[2].Value.ToString();
            RecPhone.Text = RecDGV.SelectedRows[0].Cells[3].Value.ToString();
            RecPass.Text = RecDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (RecName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(RecDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            logIn obj = new logIn();
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminOnDoctorView obj = new AdminOnDoctorView();
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AdminOnRec obj = new AdminOnRec();
            obj.Show();
            this.Hide();
        }

        private void RecName_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RecName.Text = RecDGV.SelectedRows[0].Cells[1].Value.ToString();
            RecAddTb.Text = RecDGV.SelectedRows[0].Cells[2].Value.ToString();
            RecPhone.Text = RecDGV.SelectedRows[0].Cells[3].Value.ToString();
            RecPass.Text = RecDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (RecName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(RecDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }
    }

}
