namespace Restaurant_booking_system.Admin
{
    partial class userCtrl_AdminAccount
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_adminAccounts = new System.Windows.Forms.DataGridView();
            this.lbl_accountOperationsStatus = new System.Windows.Forms.Label();
            this.btn_reload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_deleteAccPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_deleteAcc = new System.Windows.Forms.Button();
            this.txt_deleteAccUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_newAccReEnteredPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_newAccPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancelNewAcc = new System.Windows.Forms.Button();
            this.btn_createNewAcc = new System.Windows.Forms.Button();
            this.txt_newAccName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adminAccounts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1044, 47);
            this.panel_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(431, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account control panel";
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 756);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1044, 41);
            this.panel_bottom.TabIndex = 1;
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.Controls.Add(this.groupBox2);
            this.panel_main.Controls.Add(this.groupBox1);
            this.panel_main.Controls.Add(this.groupBox4);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 47);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1044, 709);
            this.panel_main.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_adminAccounts);
            this.groupBox2.Controls.Add(this.lbl_accountOperationsStatus);
            this.groupBox2.Controls.Add(this.btn_reload);
            this.groupBox2.Location = new System.Drawing.Point(28, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 365);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Admin accounts";
            // 
            // dataGridView_adminAccounts
            // 
            this.dataGridView_adminAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_adminAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_id,
            this.txt_username,
            this.txt_password});
            this.dataGridView_adminAccounts.Location = new System.Drawing.Point(18, 22);
            this.dataGridView_adminAccounts.Name = "dataGridView_adminAccounts";
            this.dataGridView_adminAccounts.RowTemplate.Height = 25;
            this.dataGridView_adminAccounts.Size = new System.Drawing.Size(473, 278);
            this.dataGridView_adminAccounts.TabIndex = 17;
            // 
            // lbl_accountOperationsStatus
            // 
            this.lbl_accountOperationsStatus.AutoSize = true;
            this.lbl_accountOperationsStatus.Location = new System.Drawing.Point(18, 318);
            this.lbl_accountOperationsStatus.Name = "lbl_accountOperationsStatus";
            this.lbl_accountOperationsStatus.Size = new System.Drawing.Size(0, 15);
            this.lbl_accountOperationsStatus.TabIndex = 13;
            // 
            // btn_reload
            // 
            this.btn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reload.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reload.Location = new System.Drawing.Point(429, 306);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(62, 27);
            this.btn_reload.TabIndex = 11;
            this.btn_reload.Text = "Reload";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox1.Controls.Add(this.txt_deleteAccPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_deleteAcc);
            this.groupBox1.Controls.Add(this.txt_deleteAccUsername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(615, 485);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 180);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete account";
            // 
            // txt_deleteAccPassword
            // 
            this.txt_deleteAccPassword.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_deleteAccPassword.Location = new System.Drawing.Point(117, 89);
            this.txt_deleteAccPassword.Name = "txt_deleteAccPassword";
            this.txt_deleteAccPassword.PasswordChar = '*';
            this.txt_deleteAccPassword.Size = new System.Drawing.Size(223, 27);
            this.txt_deleteAccPassword.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // btn_deleteAcc
            // 
            this.btn_deleteAcc.BackColor = System.Drawing.Color.Red;
            this.btn_deleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteAcc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deleteAcc.Location = new System.Drawing.Point(262, 139);
            this.btn_deleteAcc.Name = "btn_deleteAcc";
            this.btn_deleteAcc.Size = new System.Drawing.Size(78, 35);
            this.btn_deleteAcc.TabIndex = 4;
            this.btn_deleteAcc.Text = "Delete";
            this.btn_deleteAcc.UseVisualStyleBackColor = false;
            this.btn_deleteAcc.Click += new System.EventHandler(this.btn_deleteAcc_Click);
            // 
            // txt_deleteAccUsername
            // 
            this.txt_deleteAccUsername.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_deleteAccUsername.Location = new System.Drawing.Point(117, 41);
            this.txt_deleteAccUsername.Name = "txt_deleteAccUsername";
            this.txt_deleteAccUsername.Size = new System.Drawing.Size(83, 27);
            this.txt_deleteAccUsername.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox4.Controls.Add(this.txt_newAccReEnteredPassword);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txt_newAccPassword);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btn_cancelNewAcc);
            this.groupBox4.Controls.Add(this.btn_createNewAcc);
            this.groupBox4.Controls.Add(this.txt_newAccName);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(615, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 399);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Create account";
            // 
            // txt_newAccReEnteredPassword
            // 
            this.txt_newAccReEnteredPassword.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_newAccReEnteredPassword.Location = new System.Drawing.Point(58, 243);
            this.txt_newAccReEnteredPassword.Name = "txt_newAccReEnteredPassword";
            this.txt_newAccReEnteredPassword.PasswordChar = '*';
            this.txt_newAccReEnteredPassword.Size = new System.Drawing.Size(255, 27);
            this.txt_newAccReEnteredPassword.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(51, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Re-enter password";
            // 
            // txt_newAccPassword
            // 
            this.txt_newAccPassword.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_newAccPassword.Location = new System.Drawing.Point(58, 159);
            this.txt_newAccPassword.Name = "txt_newAccPassword";
            this.txt_newAccPassword.PasswordChar = '*';
            this.txt_newAccPassword.Size = new System.Drawing.Size(255, 27);
            this.txt_newAccPassword.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(58, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Password";
            // 
            // btn_cancelNewAcc
            // 
            this.btn_cancelNewAcc.BackColor = System.Drawing.Color.Red;
            this.btn_cancelNewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelNewAcc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelNewAcc.Location = new System.Drawing.Point(262, 326);
            this.btn_cancelNewAcc.Name = "btn_cancelNewAcc";
            this.btn_cancelNewAcc.Size = new System.Drawing.Size(78, 45);
            this.btn_cancelNewAcc.TabIndex = 8;
            this.btn_cancelNewAcc.Text = "Cancel";
            this.btn_cancelNewAcc.UseVisualStyleBackColor = false;
            this.btn_cancelNewAcc.Click += new System.EventHandler(this.btn_cancelNewAcc_Click);
            // 
            // btn_createNewAcc
            // 
            this.btn_createNewAcc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_createNewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createNewAcc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_createNewAcc.Location = new System.Drawing.Point(151, 326);
            this.btn_createNewAcc.Name = "btn_createNewAcc";
            this.btn_createNewAcc.Size = new System.Drawing.Size(74, 45);
            this.btn_createNewAcc.TabIndex = 4;
            this.btn_createNewAcc.Text = "Create";
            this.btn_createNewAcc.UseVisualStyleBackColor = false;
            this.btn_createNewAcc.Click += new System.EventHandler(this.btn_createNewAcc_Click);
            // 
            // txt_newAccName
            // 
            this.txt_newAccName.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_newAccName.Location = new System.Drawing.Point(58, 66);
            this.txt_newAccName.Name = "txt_newAccName";
            this.txt_newAccName.Size = new System.Drawing.Size(255, 27);
            this.txt_newAccName.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(58, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Username";
            // 
            // txt_id
            // 
            this.txt_id.DataPropertyName = "id";
            this.txt_id.Frozen = true;
            this.txt_id.HeaderText = "EmployeeId";
            this.txt_id.Name = "txt_id";
            // 
            // txt_username
            // 
            this.txt_username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.txt_username.DataPropertyName = "username";
            this.txt_username.Frozen = true;
            this.txt_username.HeaderText = "Username";
            this.txt_username.Name = "txt_username";
            this.txt_username.Width = 330;
            // 
            // txt_password
            // 
            this.txt_password.Frozen = true;
            this.txt_password.HeaderText = "Password";
            this.txt_password.Name = "txt_password";
            this.txt_password.Visible = false;
            // 
            // userCtrl_AdminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.Name = "userCtrl_AdminAccount";
            this.Size = new System.Drawing.Size(1044, 797);
            this.Load += new System.EventHandler(this.userCtrl_AdminAccount_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adminAccounts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_top;
        private Panel panel_bottom;
        private Panel panel_main;
        private Label label1;
        private GroupBox groupBox4;
        private Label label7;
        private Button btn_cancelNewAcc;
        private Button btn_createNewAcc;
        private TextBox txt_newAccName;
        private Label label9;
        private GroupBox groupBox1;
        private TextBox txt_deleteAccPassword;
        private Label label3;
        private Button btn_deleteAcc;
        private TextBox txt_deleteAccUsername;
        private Label label4;
        private Button btn_reload;
        private TextBox txt_newAccReEnteredPassword;
        private Label label5;
        private TextBox txt_newAccPassword;
        private Label lbl_accountOperationsStatus;
        private GroupBox groupBox2;
        private DataGridView dataGridView_adminAccounts;
        private DataGridViewTextBoxColumn txt_id;
        private DataGridViewTextBoxColumn txt_username;
        private DataGridViewTextBoxColumn txt_password;
    }
}
