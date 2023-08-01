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
    public partial class logIn : Form
    {
        public logIn()
        { 
            //creat the functions 
            InitializeComponent();
        }
        //conect the data base 
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\20100\Documents\lastPetDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            /*Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();*/
            //if user do not choose any role 
            if (RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select your Role!!!");
            }
            else if (RoleCb.SelectedIndex == 0)
            {
                //0 = Admin
                // user name or password is empty 
                if (UnameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter Both UserName and Password!!!");
                }
                else
                //user name and password is correct
                {
                    if (UnameTb.Text == "Admin" && PasswordTb.Text == "Password")
                    {
                        // open AdminOnRec form and hide login form 
                        AdminOnRec Obj = new AdminOnRec();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    // password or user name is wrong 
                    {
                        MessageBox.Show("Wrong Admin Name Or Password!!!");
                        UnameTb.Text = "";
                        PasswordTb.Text = "";
                    }

                }
            }
            else if (RoleCb.SelectedIndex == 1)
            {
                //Receptionist
                if (UnameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter Both UserName and Password!!!");
                }
                else
                {
                    //search in data base for user name and password
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from ReceptionistTbl where RecName='" + UnameTb.Text + "' and RecPass='" + PasswordTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    // if the user name and the password is 1 (true) (correct) open pet form 
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Pets Obj = new Pets();
                        Obj.Show();
                        this.Hide();
                    }
                    // if the user name or the password is wrong show this message 
                    else
                    {
                        MessageBox.Show("Wrong Receptionist Name Or Password!!!");
                        UnameTb.Text = "";
                        PasswordTb.Text = "";
                    }
                    Con.Close();
                }

            }
            else if (RoleCb.SelectedIndex == 2)
            {
                //Doctor
                if (UnameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter Both DoctorName and Password!!!");
                }
                //same as receptionist
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from DoctorTbl where DocName='" + UnameTb.Text + "' and DocPass='" + PasswordTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Prescriptions Obj = new Prescriptions();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Doctor Name Or Password!!!");
                        UnameTb.Text = "";
                        PasswordTb.Text = "";
                    }
                    Con.Close();
                }
            }

        }
        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logIn_Load(object sender, EventArgs e)
        {

        }
    }
}
