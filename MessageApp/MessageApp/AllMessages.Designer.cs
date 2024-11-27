namespace MessageApp
{
    partial class AllMessages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllMessages));
            this.exit_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fullname_lbl = new System.Windows.Forms.Label();
            this.number_lbl = new System.Windows.Forms.Label();
            this.newmessage_bttn = new System.Windows.Forms.Button();
            this.inbox_bttn = new System.Windows.Forms.Button();
            this.sent_bttn = new System.Windows.Forms.Button();
            this.myaccount_bttn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.signout_bttn = new System.Windows.Forms.Button();
            this.date_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_bttn.Location = new System.Drawing.Point(998, -1);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(33, 33);
            this.exit_bttn.TabIndex = 6;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(46, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(348, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number: ";
            // 
            // fullname_lbl
            // 
            this.fullname_lbl.AutoSize = true;
            this.fullname_lbl.BackColor = System.Drawing.Color.Transparent;
            this.fullname_lbl.Location = new System.Drawing.Point(150, 64);
            this.fullname_lbl.Name = "fullname_lbl";
            this.fullname_lbl.Size = new System.Drawing.Size(40, 22);
            this.fullname_lbl.TabIndex = 5;
            this.fullname_lbl.Text = "null";
            // 
            // number_lbl
            // 
            this.number_lbl.AutoSize = true;
            this.number_lbl.BackColor = System.Drawing.Color.Transparent;
            this.number_lbl.Location = new System.Drawing.Point(438, 64);
            this.number_lbl.Name = "number_lbl";
            this.number_lbl.Size = new System.Drawing.Size(50, 22);
            this.number_lbl.TabIndex = 6;
            this.number_lbl.Text = "0000";
            // 
            // newmessage_bttn
            // 
            this.newmessage_bttn.BackColor = System.Drawing.Color.Transparent;
            this.newmessage_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newmessage_bttn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newmessage_bttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newmessage_bttn.Location = new System.Drawing.Point(39, 49);
            this.newmessage_bttn.Name = "newmessage_bttn";
            this.newmessage_bttn.Size = new System.Drawing.Size(259, 36);
            this.newmessage_bttn.TabIndex = 0;
            this.newmessage_bttn.Text = "New Message";
            this.newmessage_bttn.UseVisualStyleBackColor = false;
            this.newmessage_bttn.Click += new System.EventHandler(this.newmessage_bttn_Click);
            this.newmessage_bttn.MouseEnter += new System.EventHandler(this.newmessage_bttn_MouseEnter);
            this.newmessage_bttn.MouseLeave += new System.EventHandler(this.newmessage_bttn_MouseLeave);
            // 
            // inbox_bttn
            // 
            this.inbox_bttn.BackColor = System.Drawing.Color.Transparent;
            this.inbox_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inbox_bttn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inbox_bttn.Location = new System.Drawing.Point(39, 102);
            this.inbox_bttn.Name = "inbox_bttn";
            this.inbox_bttn.Size = new System.Drawing.Size(259, 36);
            this.inbox_bttn.TabIndex = 1;
            this.inbox_bttn.Text = "Inbox";
            this.inbox_bttn.UseVisualStyleBackColor = false;
            this.inbox_bttn.Click += new System.EventHandler(this.inbox_bttn_Click);
            this.inbox_bttn.MouseEnter += new System.EventHandler(this.inbox_bttn_MouseEnter);
            this.inbox_bttn.MouseLeave += new System.EventHandler(this.inbox_bttn_MouseLeave);
            // 
            // sent_bttn
            // 
            this.sent_bttn.BackColor = System.Drawing.Color.Transparent;
            this.sent_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sent_bttn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sent_bttn.Location = new System.Drawing.Point(39, 154);
            this.sent_bttn.Name = "sent_bttn";
            this.sent_bttn.Size = new System.Drawing.Size(259, 36);
            this.sent_bttn.TabIndex = 2;
            this.sent_bttn.Text = "Sent";
            this.sent_bttn.UseVisualStyleBackColor = false;
            this.sent_bttn.Click += new System.EventHandler(this.sent_bttn_Click);
            this.sent_bttn.MouseEnter += new System.EventHandler(this.sent_bttn_MouseEnter);
            this.sent_bttn.MouseLeave += new System.EventHandler(this.sent_bttn_MouseLeave);
            // 
            // myaccount_bttn
            // 
            this.myaccount_bttn.BackColor = System.Drawing.Color.Transparent;
            this.myaccount_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myaccount_bttn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.myaccount_bttn.Location = new System.Drawing.Point(39, 205);
            this.myaccount_bttn.Name = "myaccount_bttn";
            this.myaccount_bttn.Size = new System.Drawing.Size(259, 36);
            this.myaccount_bttn.TabIndex = 3;
            this.myaccount_bttn.Text = "My Account";
            this.myaccount_bttn.UseVisualStyleBackColor = false;
            this.myaccount_bttn.Click += new System.EventHandler(this.myaccount_bttn_Click);
            this.myaccount_bttn.MouseEnter += new System.EventHandler(this.myaccount_bttn_MouseEnter);
            this.myaccount_bttn.MouseLeave += new System.EventHandler(this.myaccount_bttn_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(372, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 321);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(641, 292);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.signout_bttn);
            this.groupBox2.Controls.Add(this.newmessage_bttn);
            this.groupBox2.Controls.Add(this.myaccount_bttn);
            this.groupBox2.Controls.Add(this.inbox_bttn);
            this.groupBox2.Controls.Add(this.sent_bttn);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 321);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Messages";
            // 
            // signout_bttn
            // 
            this.signout_bttn.BackColor = System.Drawing.Color.Transparent;
            this.signout_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signout_bttn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signout_bttn.Location = new System.Drawing.Point(39, 256);
            this.signout_bttn.Name = "signout_bttn";
            this.signout_bttn.Size = new System.Drawing.Size(259, 36);
            this.signout_bttn.TabIndex = 4;
            this.signout_bttn.Text = "Sign Out";
            this.signout_bttn.UseVisualStyleBackColor = false;
            this.signout_bttn.Click += new System.EventHandler(this.signout_bttn_Click);
            this.signout_bttn.MouseEnter += new System.EventHandler(this.signout_bttn_MouseEnter);
            this.signout_bttn.MouseLeave += new System.EventHandler(this.signout_bttn_MouseLeave);
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.BackColor = System.Drawing.Color.Transparent;
            this.date_lbl.Location = new System.Drawing.Point(911, 4);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(60, 22);
            this.date_lbl.TabIndex = 13;
            this.date_lbl.Text = "label4";
            // 
            // AllMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 468);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.number_lbl);
            this.Controls.Add(this.fullname_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_bttn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllMessages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllMessages";
            this.Load += new System.EventHandler(this.AllMessages_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fullname_lbl;
        private System.Windows.Forms.Label number_lbl;
        private System.Windows.Forms.Button newmessage_bttn;
        private System.Windows.Forms.Button inbox_bttn;
        private System.Windows.Forms.Button sent_bttn;
        private System.Windows.Forms.Button myaccount_bttn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button signout_bttn;
        private System.Windows.Forms.Label date_lbl;
    }
}