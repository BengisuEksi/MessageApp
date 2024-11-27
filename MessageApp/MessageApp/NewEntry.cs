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
using System.CodeDom;

namespace MessageApp
{
    public partial class NewEntry : Form
    {
        public NewEntry()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=MessageDatabase;Integrated Security=True");

        void list()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_People", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public int GenerateUniqueNumber(SqlConnection conn)
        {
            Random rnd = new Random();
            int randomNumber;
            bool isUnique = false;

            do
            {
                randomNumber = rnd.Next(1000, 10000);

                string query = "SELECT COUNT(*) FROM Tbl_People WHERE Number = @p1";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@p1", randomNumber);
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        isUnique = true;
                    }
                }
            } while (!isUnique);
            return randomNumber;
        }

        private void save_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            int no = GenerateUniqueNumber(conn);
            SqlCommand cmd = new SqlCommand("Insert into Tbl_People (Name,Surname,Password,Number) values (@p1,@p2,@p3,@p4)", conn);
            cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2",surname_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3",password_txtbox.Text);
            cmd.Parameters.AddWithValue("@p4", no);
            cmd.ExecuteNonQuery();
            conn.Close();
            number_lbl.Text = no.ToString();
            MessageBox.Show("Your account is created.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            list();
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Close();
            fr.Show();
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.PowderBlue;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void save_bttn_MouseEnter(object sender, EventArgs e)
        {
            save_bttn.BackColor = Color.PowderBlue;
        }

        private void save_bttn_MouseLeave(object sender, EventArgs e)
        {
            save_bttn.BackColor = Color.Transparent;
        }
    }
}
