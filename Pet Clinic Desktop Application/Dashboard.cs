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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountPet();
            CountDoctors();
            CountPrescriptions();
            SumAmt();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\20100\Documents\lastPetDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void CountPet()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PetTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PnumLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountDoctors()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from DoctorTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DNumLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountPrescriptions()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PrescriptionTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PrNumLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void SumAmt()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(Cost) from PetTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AmountLbl.Text = "EGP " + dt.Rows[0][0].ToString();
            Con.Close();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Prescriptions obj = new Prescriptions();
            obj.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AmountLbl_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void CatLbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void DNumLbl_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnumLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
