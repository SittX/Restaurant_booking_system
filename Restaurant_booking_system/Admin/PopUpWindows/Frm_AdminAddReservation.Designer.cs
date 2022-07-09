namespace Restaurant_booking_system.Admin
{
    partial class Frm_AdminAddReservation
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.txt_cusEmail = new System.Windows.Forms.TextBox();
            this.txt_cusPhNumber = new System.Windows.Forms.TextBox();
            this.txt_cusName = new System.Windows.Forms.TextBox();
            this.cmb_tableType = new System.Windows.Forms.ComboBox();
            this.cmb_bookingTime = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_bookingDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.label7);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(706, 73);
            this.panel_top.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(274, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Table bookings panel";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.groupBox1);
            this.panel_main.Controls.Add(this.btn_cancel);
            this.panel_main.Controls.Add(this.btn_confirm);
            this.panel_main.Controls.Add(this.cmb_tableType);
            this.panel_main.Controls.Add(this.cmb_bookingTime);
            this.panel_main.Controls.Add(this.date_bookingDate);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 73);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(706, 634);
            this.panel_main.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Location = new System.Drawing.Point(547, 512);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(107, 46);
            this.btn_cancel.TabIndex = 27;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancelReservation_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_confirm.Location = new System.Drawing.Point(394, 512);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(105, 46);
            this.btn_confirm.TabIndex = 26;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            // 
            // txt_cusEmail
            // 
            this.txt_cusEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cusEmail.Location = new System.Drawing.Point(176, 132);
            this.txt_cusEmail.Name = "txt_cusEmail";
            this.txt_cusEmail.Size = new System.Drawing.Size(241, 29);
            this.txt_cusEmail.TabIndex = 25;
            // 
            // txt_cusPhNumber
            // 
            this.txt_cusPhNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cusPhNumber.Location = new System.Drawing.Point(176, 212);
            this.txt_cusPhNumber.Name = "txt_cusPhNumber";
            this.txt_cusPhNumber.Size = new System.Drawing.Size(241, 29);
            this.txt_cusPhNumber.TabIndex = 24;
            // 
            // txt_cusName
            // 
            this.txt_cusName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cusName.Location = new System.Drawing.Point(176, 54);
            this.txt_cusName.Name = "txt_cusName";
            this.txt_cusName.Size = new System.Drawing.Size(241, 29);
            this.txt_cusName.TabIndex = 23;
            // 
            // cmb_tableType
            // 
            this.cmb_tableType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_tableType.FormattingEnabled = true;
            this.cmb_tableType.Location = new System.Drawing.Point(549, 113);
            this.cmb_tableType.Name = "cmb_tableType";
            this.cmb_tableType.Size = new System.Drawing.Size(83, 25);
            this.cmb_tableType.TabIndex = 22;
            // 
            // cmb_bookingTime
            // 
            this.cmb_bookingTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_bookingTime.FormattingEnabled = true;
            this.cmb_bookingTime.Location = new System.Drawing.Point(103, 110);
            this.cmb_bookingTime.Name = "cmb_bookingTime";
            this.cmb_bookingTime.Size = new System.Drawing.Size(289, 25);
            this.cmb_bookingTime.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(104, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(104, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // date_bookingDate
            // 
            this.date_bookingDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_bookingDate.Location = new System.Drawing.Point(103, 28);
            this.date_bookingDate.MinDate = new System.DateTime(2022, 6, 21, 0, 0, 0, 0);
            this.date_bookingDate.Name = "date_bookingDate";
            this.date_bookingDate.Size = new System.Drawing.Size(280, 29);
            this.date_bookingDate.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(438, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Table type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date";
            // 
            // panel_bottom
            // 
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 666);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(706, 41);
            this.panel_bottom.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cusEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_cusPhNumber);
            this.groupBox1.Controls.Add(this.txt_cusName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(53, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 292);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // Frm_adminTableReservatoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 707);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_adminTableReservatoins";
            this.Text = "Frm_adminBookingsTable";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_top;
        private Panel panel_main;
        private Panel panel_bottom;
        private Button btn_cancel;
        private Button btn_confirm;
        private TextBox txt_cusEmail;
        private TextBox txt_cusPhNumber;
        private TextBox txt_cusName;
        private ComboBox cmb_tableType;
        private ComboBox cmb_bookingTime;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker date_bookingDate;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private GroupBox groupBox1;
    }
}