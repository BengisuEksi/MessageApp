namespace MessageApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exit_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.number_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.signin_bttn = new System.Windows.Forms.Button();
            this.signup_lbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_bttn.Location = new System.Drawing.Point(548, 0);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(30, 30);
            this.exit_bttn.TabIndex = 4;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Message App!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(153, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(138, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password: ";
            // 
            // number_txtbox
            // 
            this.number_txtbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_txtbox.Location = new System.Drawing.Point(239, 95);
            this.number_txtbox.Name = "number_txtbox";
            this.number_txtbox.Size = new System.Drawing.Size(197, 30);
            this.number_txtbox.TabIndex = 0;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_txtbox.Location = new System.Drawing.Point(239, 134);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(197, 30);
            this.password_txtbox.TabIndex = 1;
            this.password_txtbox.UseSystemPasswordChar = true;
            // 
            // signin_bttn
            // 
            this.signin_bttn.BackColor = System.Drawing.Color.Transparent;
            this.signin_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin_bttn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signin_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signin_bttn.Location = new System.Drawing.Point(239, 175);
            this.signin_bttn.Name = "signin_bttn";
            this.signin_bttn.Size = new System.Drawing.Size(197, 30);
            this.signin_bttn.TabIndex = 2;
            this.signin_bttn.Text = "Sign In";
            this.signin_bttn.UseVisualStyleBackColor = false;
            this.signin_bttn.Click += new System.EventHandler(this.signin_bttn_Click);
            this.signin_bttn.MouseEnter += new System.EventHandler(this.signin_bttn_MouseEnter);
            this.signin_bttn.MouseLeave += new System.EventHandler(this.signin_bttn_MouseLeave);
            // 
            // signup_lbl
            // 
            this.signup_lbl.AutoSize = true;
            this.signup_lbl.BackColor = System.Drawing.Color.Transparent;
            this.signup_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signup_lbl.LinkColor = System.Drawing.Color.White;
            this.signup_lbl.Location = new System.Drawing.Point(182, 220);
            this.signup_lbl.Name = "signup_lbl";
            this.signup_lbl.Size = new System.Drawing.Size(222, 19);
            this.signup_lbl.TabIndex = 3;
            this.signup_lbl.TabStop = true;
            this.signup_lbl.Text = "Don\'t have an account? Sign up!";
            this.signup_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_lbl_LinkClicked);
            this.signup_lbl.MouseEnter += new System.EventHandler(this.signup_lbl_MouseEnter);
            this.signup_lbl.MouseLeave += new System.EventHandler(this.signup_lbl_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 279);
            this.Controls.Add(this.signup_lbl);
            this.Controls.Add(this.signin_bttn);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.number_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_bttn);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox number_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Button signin_bttn;
        private System.Windows.Forms.LinkLabel signup_lbl;
    }
}

