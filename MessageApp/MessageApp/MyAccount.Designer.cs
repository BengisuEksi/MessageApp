namespace MessageApp
{
    partial class MyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccount));
            this.exit_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.delete_bttn = new System.Windows.Forms.Button();
            this.update_bttn = new System.Windows.Forms.Button();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.surname_txtbox = new System.Windows.Forms.TextBox();
            this.number_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.return_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_bttn.Location = new System.Drawing.Point(549, -1);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(33, 33);
            this.exit_bttn.TabIndex = 2;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(184, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(160, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(138, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(143, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(128, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password: ";
            // 
            // delete_bttn
            // 
            this.delete_bttn.BackColor = System.Drawing.Color.Transparent;
            this.delete_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_bttn.Location = new System.Drawing.Point(298, 260);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(158, 31);
            this.delete_bttn.TabIndex = 8;
            this.delete_bttn.Text = "Delete";
            this.delete_bttn.UseVisualStyleBackColor = false;
            this.delete_bttn.Click += new System.EventHandler(this.delete_bttn_Click);
            this.delete_bttn.MouseEnter += new System.EventHandler(this.delete_bttn_MouseEnter);
            this.delete_bttn.MouseLeave += new System.EventHandler(this.delete_bttn_MouseLeave);
            // 
            // update_bttn
            // 
            this.update_bttn.BackColor = System.Drawing.Color.Transparent;
            this.update_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_bttn.Location = new System.Drawing.Point(132, 260);
            this.update_bttn.Name = "update_bttn";
            this.update_bttn.Size = new System.Drawing.Size(158, 31);
            this.update_bttn.TabIndex = 9;
            this.update_bttn.Text = "Update";
            this.update_bttn.UseVisualStyleBackColor = false;
            this.update_bttn.Click += new System.EventHandler(this.update_bttn_Click);
            this.update_bttn.MouseEnter += new System.EventHandler(this.update_bttn_MouseEnter);
            this.update_bttn.MouseLeave += new System.EventHandler(this.update_bttn_MouseLeave);
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(233, 75);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(223, 30);
            this.name_txtbox.TabIndex = 10;
            // 
            // surname_txtbox
            // 
            this.surname_txtbox.Location = new System.Drawing.Point(233, 120);
            this.surname_txtbox.Name = "surname_txtbox";
            this.surname_txtbox.Size = new System.Drawing.Size(223, 30);
            this.surname_txtbox.TabIndex = 11;
            // 
            // number_txtbox
            // 
            this.number_txtbox.Enabled = false;
            this.number_txtbox.Location = new System.Drawing.Point(233, 167);
            this.number_txtbox.Name = "number_txtbox";
            this.number_txtbox.Size = new System.Drawing.Size(223, 30);
            this.number_txtbox.TabIndex = 12;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(233, 215);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(223, 30);
            this.password_txtbox.TabIndex = 13;
            // 
            // return_bttn
            // 
            this.return_bttn.BackColor = System.Drawing.Color.Transparent;
            this.return_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_bttn.Location = new System.Drawing.Point(132, 297);
            this.return_bttn.Name = "return_bttn";
            this.return_bttn.Size = new System.Drawing.Size(324, 31);
            this.return_bttn.TabIndex = 14;
            this.return_bttn.Text = "Return to the Messages Screen";
            this.return_bttn.UseVisualStyleBackColor = false;
            this.return_bttn.Click += new System.EventHandler(this.return_bttn_Click);
            this.return_bttn.MouseEnter += new System.EventHandler(this.return_bttn_MouseEnter);
            this.return_bttn.MouseLeave += new System.EventHandler(this.return_bttn_MouseLeave);
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 349);
            this.Controls.Add(this.return_bttn);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.number_txtbox);
            this.Controls.Add(this.surname_txtbox);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.update_bttn);
            this.Controls.Add(this.delete_bttn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_bttn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAccount";
            this.Load += new System.EventHandler(this.MyAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delete_bttn;
        private System.Windows.Forms.Button update_bttn;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.TextBox surname_txtbox;
        private System.Windows.Forms.TextBox number_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Button return_bttn;
    }
}