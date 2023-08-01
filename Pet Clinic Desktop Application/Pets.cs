using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bmd302Project
{
    public partial class Pets : Form
    {

        public Pets()
        {
            InitializeComponent();
            ShowPet();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\20100\Documents\lastPetDB.mdf;Integrated Security=True;Connect Timeout=30");
        public class pet
        {
            public Guid Id { get; private set; } = Guid.NewGuid();
            public string PName { get; set; }
            public string PoAdd { get; set; }
        }
        private void ShowPet()
        {
            Con.Open();
            string Query = "select * from PetTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PetDGV.DataSource = ds.Tables[0];
            Con.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            logIn obj = new logIn();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pets obj = new Pets();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Prescriptions obj = new Prescriptions();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        //show the data in the box 
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //add button 
            //check if there are a empty parameters
            if (PetNameTb.Text == "" || GenCb.SelectedIndex == -1 || AgeTb.Text == "" || AddTb.Text == "" || PhoneTb.Text == "" || PetAllTb.Text == "" || CostTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else if (PhoneTb.Text.Length < 12 )
            {
                MessageBox.Show("phone number is incorrect, Enter vaild number");
            }
            else if (PhoneTb.Text.Length > 12)
            {
                MessageBox.Show("phone number is incorrect, Enter vaild number");
            }
            else
            {
                //add parameters to the database
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PetTbl(PName,PGen,PAge,POAdd,PoPhone,PAllergie,cost)values(@PN,@PG,@PA,@POA,@POP,@PAl,@CO)", Con);
                    
                    cmd.Parameters.AddWithValue("@PN", PetNameTb.Text);
                    cmd.Parameters.AddWithValue("@PG", GenCb.Text);
                    cmd.Parameters.AddWithValue("@PA", AgeTb.Text);
                    cmd.Parameters.AddWithValue("@POA", AddTb.Text);
                    cmd.Parameters.AddWithValue("@POP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CO", CostTb.Text);
                    cmd.Parameters.AddWithValue("@PAl", PetAllTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pet Saved");
                    Con.Close();
                    ShowPet();
                }
                //if there are any probelm catch erroe 
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //delete button
            //check if the user selected a value 
            if (Key == 0)
            {
                MessageBox.Show("Select Pet!!!");
            }
            else
            {
                try
                {
                    //delete the data
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from PetTbl where PNum=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pet Deleted!!!");
                    Con.Close();
                    ShowPet();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            //edite button 
            //cheack if there are any empty value 
            if (PetNameTb.Text == "" || GenCb.SelectedIndex == -1 || AgeTb.Text == "" || AddTb.Text == "" || PhoneTb.Text == "" || PetAllTb.Text == "")
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
                    //adding the values 
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update PetTbl set PName=@PN,PGen=@PG,PAge=@PA,POAdd=@POA,PoPhone=@POP,PAllergie=@PAl cost =@CO  where PNum = @PKey", Con);
                    cmd.Parameters.AddWithValue("@PN", PetNameTb.Text);
                    cmd.Parameters.AddWithValue("@PG", GenCb.Text);
                    cmd.Parameters.AddWithValue("@PA", AgeTb.Text);
                    cmd.Parameters.AddWithValue("@POA", AddTb.Text);
                    cmd.Parameters.AddWithValue("@POP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PAl", PetAllTb.Text);
                    cmd.Parameters.AddWithValue("@CO", CostTb.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pet Updated!!!");
                    Con.Close();
                    ShowPet();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            logIn obj = new logIn();
            obj.Show();
            this.Hide();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void PetDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //adding the values to the box to show it in rosw and columes 
            PetNameTb.Text = PetDGV.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.SelectedValue = PetDGV.SelectedRows[0].Cells[2].Value.ToString();
            AgeTb.Text = PetDGV.SelectedRows[0].Cells[3].Value.ToString();
            AddTb.Text = PetDGV.SelectedRows[0].Cells[4].Value.ToString();
            PhoneTb.Text = PetDGV.SelectedRows[0].Cells[5].Value.ToString();
            PetAllTb.Text = PetDGV.SelectedRows[0].Cells[6].Value.ToString();
            CostTb.Text = PetDGV.SelectedRows[0].Cells[7].Value.ToString();

            if (PetNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PetDGV.SelectedRows[0].Cells[0].Value.ToString());

            }

        }
        
        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CostTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
