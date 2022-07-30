namespace Motel_booking_system
{
    partial class Frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.top_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.link_registerNewUser = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.lbl_failureTimer = new System.Windows.Forms.Label();
            this.lbl_loginFailureMsg = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.mskTxtBox_password = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_loginUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.top_panel.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.top_panel.Controls.Add(this.label1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(693, 65);
            this.top_panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(95, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Booking Application Login";
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.bottom_panel.Controls.Add(this.link_registerNewUser);
            this.bottom_panel.Controls.Add(this.label4);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(0, 400);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(693, 37);
            this.bottom_panel.TabIndex = 1;
            // 
            // link_registerNewUser
            // 
            this.link_registerNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_registerNewUser.AutoSize = true;
            this.link_registerNewUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.link_registerNewUser.Location = new System.Drawing.Point(306, 10);
            this.link_registerNewUser.Name = "link_registerNewUser";
            this.link_registerNewUser.Size = new System.Drawing.Size(67, 18);
            this.link_registerNewUser.TabIndex = 1;
            this.link_registerNewUser.TabStop = true;
            this.link_registerNewUser.Text = "Register";
            this.link_registerNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_registerNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_registerNewUser_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(210, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "New User ?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.main_panel.Controls.Add(this.lbl_failureTimer);
            this.main_panel.Controls.Add(this.lbl_loginFailureMsg);
            this.main_panel.Controls.Add(this.btn_cancel);
            this.main_panel.Controls.Add(this.btn_login);
            this.main_panel.Controls.Add(this.mskTxtBox_password);
            this.main_panel.Controls.Add(this.txtBox_loginUsername);
            this.main_panel.Controls.Add(this.label3);
            this.main_panel.Controls.Add(this.label2);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 65);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(693, 335);
            this.main_panel.TabIndex = 2;
            // 
            // lbl_failureTimer
            // 
            this.lbl_failureTimer.AutoSize = true;
            this.lbl_failureTimer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_failureTimer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_failureTimer.ForeColor = System.Drawing.Color.Red;
            this.lbl_failureTimer.Location = new System.Drawing.Point(458, 281);
            this.lbl_failureTimer.Name = "lbl_failureTimer";
            this.lbl_failureTimer.Size = new System.Drawing.Size(21, 22);
            this.lbl_failureTimer.TabIndex = 14;
            this.lbl_failureTimer.Text = "0";
            this.lbl_failureTimer.Visible = false;
            // 
            // lbl_loginFailureMsg
            // 
            this.lbl_loginFailureMsg.AutoSize = true;
            this.lbl_loginFailureMsg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loginFailureMsg.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_loginFailureMsg.ForeColor = System.Drawing.Color.Red;
            this.lbl_loginFailureMsg.Location = new System.Drawing.Point(117, 281);
            this.lbl_loginFailureMsg.Name = "lbl_loginFailureMsg";
            this.lbl_loginFailureMsg.Size = new System.Drawing.Size(344, 22);
            this.lbl_loginFailureMsg.TabIndex = 13;
            this.lbl_loginFailureMsg.Text = "Login Attempts Exceeded. Try again in :";
            this.lbl_loginFailureMsg.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.Location = new System.Drawing.Point(325, 207);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 35);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.Location = new System.Drawing.Point(223, 207);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(94, 35);
            this.btn_login.TabIndex = 11;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // mskTxtBox_password
            // 
            this.mskTxtBox_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTxtBox_password.Location = new System.Drawing.Point(223, 147);
            this.mskTxtBox_password.Name = "mskTxtBox_password";
            this.mskTxtBox_password.PasswordChar = '*';
            this.mskTxtBox_password.Size = new System.Drawing.Size(262, 26);
            this.mskTxtBox_password.TabIndex = 10;
            // 
            // txtBox_loginUsername
            // 
            this.txtBox_loginUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_loginUsername.Location = new System.Drawing.Point(220, 56);
            this.txtBox_loginUsername.Name = "txtBox_loginUsername";
            this.txtBox_loginUsername.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBox_loginUsername.Size = new System.Drawing.Size(265, 26);
            this.txtBox_loginUsername.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(123, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(117, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 437);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_login_FormClosing);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.bottom_panel.ResumeLayout(false);
            this.bottom_panel.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel top_panel;
        private Label label1;
        private Panel bottom_panel;
        private LinkLabel link_registerNewUser;
        private Label label4;
        private Panel main_panel;
        private Button btn_cancel;
        private Button btn_login;
        private MaskedTextBox mskTxtBox_password;
        private TextBox txtBox_loginUsername;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer timer;
        private Label lbl_failureTimer;
        private Label lbl_loginFailureMsg;
    }
}