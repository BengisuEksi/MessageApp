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

namespace MessageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=MessageDatabase;Integrated Security=True");
        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signin_bttn_MouseEnter(object sender, EventArgs e)
        {
            signin_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void signin_bttn_MouseLeave(object sender, EventArgs e)
        {
            signin_bttn.BackColor = Color.Transparent;
        }

        private void signup_lbl_MouseEnter(object sender, EventArgs e)
        {
            signup_lbl.BackColor = Color.DarkSeaGreen;
        }

        private void signup_lbl_MouseLeave(object sender, EventArgs e)
        {
            signup_lbl.BackColor = Color.Transparent;
        }

        private void signin_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_People where Number = @p1 and Password = @p2", conn);
            cmd.Parameters.AddWithValue("@p1",number_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2",password_txtbox.Text);
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                AllMessages fr = new AllMessages();
                this.Hide();
                fr.full_name = da[1].ToString() + " " + da[2].ToString();
                fr.no = da[3].ToString();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Invalid number or password!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                number_txtbox.Text = "";
                password_txtbox.Text = "";
                number_txtbox.Focus();
            }
            conn.Close();
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void signup_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewEntry fr = new NewEntry();
            this.Hide();
            fr.Show();
        }
    }
}
