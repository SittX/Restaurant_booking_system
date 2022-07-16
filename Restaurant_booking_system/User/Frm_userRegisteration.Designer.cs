namespace Restaurant_booking_system
{
    partial class Frm_userRegisteration
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_saveRegisteration = new System.Windows.Forms.Button();
            this.btn_cancelRegisteration = new System.Windows.Forms.Button();
            this.lbl_registerationStatus = new System.Windows.Forms.Label();
            this.txt_nrc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phNumber = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(96, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_username.Location = new System.Drawing.Point(158, 62);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(261, 27);
            this.txt_username.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone Number";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_password.Location = new System.Drawing.Point(158, 146);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(261, 27);
            this.txt_password.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(158, 237);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(261, 27);
            this.txt_email.TabIndex = 10;
            // 
            // btn_saveRegisteration
            // 
            this.btn_saveRegisteration.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_saveRegisteration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveRegisteration.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_saveRegisteration.Location = new System.Drawing.Point(210, 486);
            this.btn_saveRegisteration.Name = "btn_saveRegisteration";
            this.btn_saveRegisteration.Size = new System.Drawing.Size(88, 35);
            this.btn_saveRegisteration.TabIndex = 12;
            this.btn_saveRegisteration.Text = "Create";
            this.btn_saveRegisteration.UseVisualStyleBackColor = false;
            this.btn_saveRegisteration.Click += new System.EventHandler(this.btn_saveRegisteration_Click);
            // 
            // btn_cancelRegisteration
            // 
            this.btn_cancelRegisteration.BackColor = System.Drawing.Color.Red;
            this.btn_cancelRegisteration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelRegisteration.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelRegisteration.Location = new System.Drawing.Point(335, 486);
            this.btn_cancelRegisteration.Name = "btn_cancelRegisteration";
            this.btn_cancelRegisteration.Size = new System.Drawing.Size(94, 35);
            this.btn_cancelRegisteration.TabIndex = 13;
            this.btn_cancelRegisteration.Text = "Cancel";
            this.btn_cancelRegisteration.UseVisualStyleBackColor = false;
            // 
            // lbl_registerationStatus
            // 
            this.lbl_registerationStatus.AutoSize = true;
            this.lbl_registerationStatus.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_registerationStatus.Location = new System.Drawing.Point(84, 497);
            this.lbl_registerationStatus.Name = "lbl_registerationStatus";
            this.lbl_registerationStatus.Size = new System.Drawing.Size(0, 19);
            this.lbl_registerationStatus.TabIndex = 15;
            // 
            // txt_nrc
            // 
            this.txt_nrc.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nrc.Location = new System.Drawing.Point(158, 314);
            this.txt_nrc.Name = "txt_nrc";
            this.txt_nrc.Size = new System.Drawing.Size(261, 27);
            this.txt_nrc.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(96, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "NRC ";
            // 
            // txt_phNumber
            // 
            this.txt_phNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phNumber.Location = new System.Drawing.Point(158, 404);
            this.txt_phNumber.Mask = "(00)-0000000000";
            this.txt_phNumber.Name = "txt_phNumber";
            this.txt_phNumber.Size = new System.Drawing.Size(261, 29);
            this.txt_phNumber.TabIndex = 18;
            // 
            // Frm_userRegisteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 569);
            this.Controls.Add(this.txt_phNumber);
            this.Controls.Add(this.txt_nrc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_registerationStatus);
            this.Controls.Add(this.btn_cancelRegisteration);
            this.Controls.Add(this.btn_saveRegisteration);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Frm_userRegisteration";
            this.Text = "RegisterationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_username;
        private Label label6;
        private TextBox txt_password;
        private TextBox txt_email;
        private Button btn_saveRegisteration;
        private Button btn_cancelRegisteration;
        private Label lbl_registerationStatus;
        private TextBox txt_nrc;
        private Label label1;
        private MaskedTextBox txt_phNumber;
    }
}