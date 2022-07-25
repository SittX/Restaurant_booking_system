namespace Restaurant_booking_system
{
    partial class userCtrl_Account
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_main = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_updatePassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_oldPassword = new System.Windows.Forms.TextBox();
            this.txt_newPassword = new System.Windows.Forms.TextBox();
            this.lbl_operationsStatus = new System.Windows.Forms.Label();
            this.txt_newUsername = new System.Windows.Forms.TextBox();
            this.btn_createNewAccount = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_updateUsername = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.groupBox1);
            this.panel_main.Controls.Add(this.lbl_operationsStatus);
            this.panel_main.Controls.Add(this.txt_newUsername);
            this.panel_main.Controls.Add(this.btn_createNewAccount);
            this.panel_main.Controls.Add(this.label7);
            this.panel_main.Controls.Add(this.btn_updateUsername);
            this.panel_main.Controls.Add(this.txt_email);
            this.panel_main.Controls.Add(this.txt_username);
            this.panel_main.Controls.Add(this.label4);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1040, 592);
            this.panel_main.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_updatePassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_oldPassword);
            this.groupBox1.Controls.Add(this.txt_newPassword);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(529, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 276);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password";
            // 
            // btn_updatePassword
            // 
            this.btn_updatePassword.BackColor = System.Drawing.Color.Orange;
            this.btn_updatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatePassword.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_updatePassword.Location = new System.Drawing.Point(228, 197);
            this.btn_updatePassword.Name = "btn_updatePassword";
            this.btn_updatePassword.Size = new System.Drawing.Size(156, 37);
            this.btn_updatePassword.TabIndex = 12;
            this.btn_updatePassword.Text = "Update";
            this.btn_updatePassword.UseVisualStyleBackColor = false;
            this.btn_updatePassword.Click += new System.EventHandler(this.btn_updatePassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password";
            // 
            // txt_oldPassword
            // 
            this.txt_oldPassword.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_oldPassword.Location = new System.Drawing.Point(167, 54);
            this.txt_oldPassword.Name = "txt_oldPassword";
            this.txt_oldPassword.PasswordChar = '*';
            this.txt_oldPassword.Size = new System.Drawing.Size(217, 27);
            this.txt_oldPassword.TabIndex = 9;
            // 
            // txt_newPassword
            // 
            this.txt_newPassword.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_newPassword.Location = new System.Drawing.Point(167, 136);
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.PasswordChar = '*';
            this.txt_newPassword.Size = new System.Drawing.Size(217, 27);
            this.txt_newPassword.TabIndex = 10;
            // 
            // lbl_operationsStatus
            // 
            this.lbl_operationsStatus.AutoSize = true;
            this.lbl_operationsStatus.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_operationsStatus.Location = new System.Drawing.Point(36, 437);
            this.lbl_operationsStatus.Name = "lbl_operationsStatus";
            this.lbl_operationsStatus.Size = new System.Drawing.Size(0, 23);
            this.lbl_operationsStatus.TabIndex = 16;
            // 
            // txt_newUsername
            // 
            this.txt_newUsername.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_newUsername.Location = new System.Drawing.Point(169, 237);
            this.txt_newUsername.Name = "txt_newUsername";
            this.txt_newUsername.Size = new System.Drawing.Size(217, 27);
            this.txt_newUsername.TabIndex = 15;
            // 
            // btn_createNewAccount
            // 
            this.btn_createNewAccount.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_createNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createNewAccount.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_createNewAccount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_createNewAccount.Location = new System.Drawing.Point(812, 437);
            this.btn_createNewAccount.Name = "btn_createNewAccount";
            this.btn_createNewAccount.Size = new System.Drawing.Size(167, 47);
            this.btn_createNewAccount.TabIndex = 0;
            this.btn_createNewAccount.Text = "Create new account";
            this.btn_createNewAccount.UseVisualStyleBackColor = false;
            this.btn_createNewAccount.Click += new System.EventHandler(this.btn_createNewAccount_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(31, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "New username";
            // 
            // btn_updateUsername
            // 
            this.btn_updateUsername.BackColor = System.Drawing.Color.Orange;
            this.btn_updateUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateUsername.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_updateUsername.Location = new System.Drawing.Point(392, 232);
            this.btn_updateUsername.Name = "btn_updateUsername";
            this.btn_updateUsername.Size = new System.Drawing.Size(93, 32);
            this.btn_updateUsername.TabIndex = 13;
            this.btn_updateUsername.Text = "Update";
            this.btn_updateUsername.UseVisualStyleBackColor = false;
            this.btn_updateUsername.Click += new System.EventHandler(this.btn_updateUsername_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(98, 333);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(288, 27);
            this.txt_email.TabIndex = 11;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_username.Location = new System.Drawing.Point(169, 175);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(217, 27);
            this.txt_username.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_top.Controls.Add(this.label5);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1040, 69);
            this.panel_top.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(459, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Account";
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 531);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1040, 61);
            this.panel_bottom.TabIndex = 2;
            // 
            // userCtrl_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_main);
            this.Name = "userCtrl_Account";
            this.Size = new System.Drawing.Size(1040, 592);
            this.Load += new System.EventHandler(this.userCtrl_Account_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_main;
        private Button btn_updatePassword;
        private TextBox txt_email;
        private TextBox txt_newPassword;
        private TextBox txt_oldPassword;
        private TextBox txt_username;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel_top;
        private Button btn_createNewAccount;
        private TextBox txt_newUsername;
        private Label label7;
        private Button btn_updateUsername;
        private Label lbl_operationsStatus;
        private Panel panel_bottom;
        private GroupBox groupBox1;
        private Label label5;
    }
}
