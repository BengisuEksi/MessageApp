namespace MessageApp
{
    partial class NewMessage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMessage));
            this.exit_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subject_txtbox = new System.Windows.Forms.TextBox();
            this.message_txtbox = new System.Windows.Forms.RichTextBox();
            this.send_bttn = new System.Windows.Forms.Button();
            this.back_bttn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.receiver_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_bttn.Location = new System.Drawing.Point(608, 0);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(30, 30);
            this.exit_bttn.TabIndex = 5;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(47, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Receiver: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(60, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Subject: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(50, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Message: ";
            // 
            // subject_txtbox
            // 
            this.subject_txtbox.Location = new System.Drawing.Point(146, 87);
            this.subject_txtbox.Name = "subject_txtbox";
            this.subject_txtbox.Size = new System.Drawing.Size(418, 30);
            this.subject_txtbox.TabIndex = 1;
            // 
            // message_txtbox
            // 
            this.message_txtbox.Location = new System.Drawing.Point(146, 131);
            this.message_txtbox.Name = "message_txtbox";
            this.message_txtbox.Size = new System.Drawing.Size(418, 324);
            this.message_txtbox.TabIndex = 2;
            this.message_txtbox.Text = "";
            // 
            // send_bttn
            // 
            this.send_bttn.BackColor = System.Drawing.Color.Transparent;
            this.send_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.send_bttn.Location = new System.Drawing.Point(386, 464);
            this.send_bttn.Name = "send_bttn";
            this.send_bttn.Size = new System.Drawing.Size(178, 32);
            this.send_bttn.TabIndex = 3;
            this.send_bttn.Text = "Send";
            this.send_bttn.UseVisualStyleBackColor = false;
            this.send_bttn.Click += new System.EventHandler(this.send_bttn_Click);
            this.send_bttn.MouseEnter += new System.EventHandler(this.send_bttn_MouseEnter);
            this.send_bttn.MouseLeave += new System.EventHandler(this.send_bttn_MouseLeave);
            // 
            // back_bttn
            // 
            this.back_bttn.BackColor = System.Drawing.Color.Transparent;
            this.back_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_bttn.BackgroundImage")));
            this.back_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_bttn.Location = new System.Drawing.Point(573, 0);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(30, 30);
            this.back_bttn.TabIndex = 4;
            this.back_bttn.UseVisualStyleBackColor = false;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click);
            this.back_bttn.MouseEnter += new System.EventHandler(this.back_bttn_MouseEnter);
            this.back_bttn.MouseLeave += new System.EventHandler(this.back_bttn_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // receiver_txtbox
            // 
            this.receiver_txtbox.Location = new System.Drawing.Point(146, 48);
            this.receiver_txtbox.Mask = "0000";
            this.receiver_txtbox.Name = "receiver_txtbox";
            this.receiver_txtbox.Size = new System.Drawing.Size(418, 30);
            this.receiver_txtbox.TabIndex = 0;
            // 
            // NewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 519);
            this.Controls.Add(this.receiver_txtbox);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.send_bttn);
            this.Controls.Add(this.message_txtbox);
            this.Controls.Add(this.subject_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_bttn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMessage";
            this.Load += new System.EventHandler(this.NewMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subject_txtbox;
        private System.Windows.Forms.RichTextBox message_txtbox;
        private System.Windows.Forms.Button send_bttn;
        private System.Windows.Forms.Button back_bttn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox receiver_txtbox;
    }
}