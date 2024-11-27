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
    public partial class AllMessages : Form
    {
        public AllMessages()
        {
            InitializeComponent();
        }
        public string full_name;
        public string no;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=MessageDatabase;Integrated Security=True");
        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AllMessages_Load(object sender, EventArgs e)
        {
            number_lbl.Text = no;
            fullname_lbl.Text = full_name;
            date_lbl.Text = DateTime.Now.ToString("d");
        }

        private void signout_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Form1 fr = new Form1();
                this.Close();
                fr.ShowDialog();
            }
            else {; }
        }

        private void myaccount_bttn_Click(object sender, EventArgs e)
        {
            MyAccount fr = new MyAccount();
            fr.no = no;
            this.Close();
            fr.ShowDialog();
        }

        private void newmessage_bttn_MouseEnter(object sender, EventArgs e)
        {
            newmessage_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void newmessage_bttn_MouseLeave(object sender, EventArgs e)
        {
            newmessage_bttn.BackColor = Color.Transparent;
        }

        private void inbox_bttn_MouseEnter(object sender, EventArgs e)
        {
            inbox_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void inbox_bttn_MouseLeave(object sender, EventArgs e)
        {
            inbox_bttn.BackColor = Color.Transparent;
        }

        private void sent_bttn_MouseEnter(object sender, EventArgs e)
        {
            sent_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void sent_bttn_MouseLeave(object sender, EventArgs e)
        {
            sent_bttn.BackColor = Color.Transparent;
        }

        private void myaccount_bttn_MouseEnter(object sender, EventArgs e)
        {
            myaccount_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void myaccount_bttn_MouseLeave(object sender, EventArgs e)
        {
            myaccount_bttn.BackColor = Color.Transparent;
        }

        private void signout_bttn_MouseEnter(object sender, EventArgs e)
        {
            signout_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void signout_bttn_MouseLeave(object sender, EventArgs e)
        {
            signout_bttn.BackColor = Color.Transparent;
        }

        private void newmessage_bttn_Click(object sender, EventArgs e)
        {
            NewMessage fr = new NewMessage();
            fr.no = no;
            fr.full_name = full_name;
            this.Close();
            fr.Show();
        }

        void inbox()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MessageID, (SenderPeople.Name + ' ' + SenderPeople.Surname) as Sender, (ReceiverPeople.Name + ' ' + ReceiverPeople.Surname) as Receiver,Subject,Text from Tbl_Message\r\ninner join Tbl_People as SenderPeople\r\non Tbl_Message.Sender = SenderPeople.Number\r\ninner join Tbl_People as ReceiverPeople\r\non Tbl_Message.Receiver = ReceiverPeople.Number where Receiver =" + no,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void inbox_bttn_Click(object sender, EventArgs e)
        {
            inbox();
        }

        void sent_messages()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MessageID, (SenderPeople.Name + ' ' + SenderPeople.Surname) as Sender, (ReceiverPeople.Name + ' ' + ReceiverPeople.Surname) as Receiver,Subject,Text from Tbl_Message\r\ninner join Tbl_People as SenderPeople\r\non Tbl_Message.Sender = SenderPeople.Number\r\ninner join Tbl_People as ReceiverPeople\r\non Tbl_Message.Receiver = ReceiverPeople.Number where Sender =" + no, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void sent_bttn_Click(object sender, EventArgs e)
        {
            sent_messages();
        }
    }
}
