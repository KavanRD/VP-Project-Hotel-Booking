using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelBooking
{
    public partial class SignUp : Form
    {
        string sql;
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();

            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ANISH08\Documents\SignUp.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();
            sql = "insert into sign (First_Name,Last_Name,Username,Email_ID,Password,Confirm_Password,Phone_Number) values ('"+ textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+maskedTextBox1.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+maskedTextBox2.Text+"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Details Registered");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }
    }
}
