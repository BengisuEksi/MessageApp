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

namespace MessageApp
{
    public partial class NewMessage : Form
    {
        public NewMessage()
        {
            InitializeComponent();
        }
        public string no;
        public string full_name;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=MessageDatabase;Integrated Security=True");

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            AllMessages fr = new AllMessages();
            fr.no = no;
            fr.full_name = full_name;
            this.Close();
            fr.Show();
        }

        private void NewMessage_Load(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(receiver_txtbox, "Enter the receiver's number.");
        }

        private void send_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Message (Sender,Receiver,Subject,Text) values (@p1,@p2,@p3,@p4)", conn);
            cmd.Parameters.AddWithValue("@p1", no);
            cmd.Parameters.AddWithValue("@p2",receiver_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3",subject_txtbox.Text);
            cmd.Parameters.AddWithValue("@p4", message_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Message is sent.","",MessageBoxButtons.OK, MessageBoxIcon.Information);

            receiver_txtbox.Text = "";
            subject_txtbox.Text = "";
            message_txtbox.Text = "";
        }

        private void back_bttn_MouseEnter(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void back_bttn_MouseLeave(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.Transparent;
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void send_bttn_MouseEnter(object sender, EventArgs e)
        {
            send_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void send_bttn_MouseLeave(object sender, EventArgs e)
        {
            send_bttn.BackColor = Color.Transparent;
        }
    }
}
