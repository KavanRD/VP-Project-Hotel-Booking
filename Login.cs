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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ANISH08\Documents\SignUp.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();
            sql = "insert into Login (Username,Password) values ('"+ textBox1.Text+"','"+ textBox2.Text+"')";
            SqlCommand cmd = new SqlCommand (sql,conn);

            sql = "select l.username,l.password,s.username,s.password from login l join sign s where l.username= s.username AND l.password= s.password";
            SqlCommand cm = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("success");
            System.Diagnostics.Process.Start("https://www.youtube.com/");

        }
    }
}
