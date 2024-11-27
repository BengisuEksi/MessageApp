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
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }
        public string no;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=MessageDatabase;Integrated Security=True");
        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void update_bttn_MouseEnter(object sender, EventArgs e)
        {
            update_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void update_bttn_MouseLeave(object sender, EventArgs e)
        {
            update_bttn.BackColor = Color.Transparent;
        }

        private void delete_bttn_MouseEnter(object sender, EventArgs e)
        {
            delete_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void delete_bttn_MouseLeave(object sender, EventArgs e)
        {
            delete_bttn.BackColor = Color.Transparent;
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_People where Number = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", no);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name_txtbox.Text = dr["Name"].ToString();
                surname_txtbox.Text = dr["Surname"].ToString();
                number_txtbox.Text = dr["Number"].ToString();
                password_txtbox.Text = dr["Password"].ToString();
            }
            conn.Close();
        }

        private void return_bttn_Click(object sender, EventArgs e)
        {
            AllMessages fr = new AllMessages();
            fr.full_name = name_txtbox.Text + " " + surname_txtbox.Text;
            fr.no = no;
            this.Close();
            fr.Show();
        }

        private void return_bttn_MouseEnter(object sender, EventArgs e)
        {
            return_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void return_bttn_MouseLeave(object sender, EventArgs e)
        {
            return_bttn.BackColor = Color.Transparent;
        }
        void list()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_People", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void delete_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete your account?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Tbl_People where Number = @p1", conn);
                cmd.Parameters.AddWithValue("@p1", no);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your account is deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                list();
                Form1 fr = new Form1();
                this.Close();
                fr.Show();
            }
            else {;}
        }

        private void update_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Tbl_People set Name = @p1,Surname = @p2,Password = @p3 where Number = @p4", conn);
            cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2",surname_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3", password_txtbox.Text);
            cmd.Parameters.AddWithValue("@p4", no);
            cmd.ExecuteNonQuery();
            conn.Close();
            list();
            MessageBox.Show("Your account is updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
