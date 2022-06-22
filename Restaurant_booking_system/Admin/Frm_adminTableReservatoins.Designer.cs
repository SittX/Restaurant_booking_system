namespace Restaurant_booking_system.Admin
{
    partial class Frm_adminTableReservatoins
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
            this.btn_cancelReservation = new System.Windows.Forms.Button();
            this.btn_makeReservation = new System.Windows.Forms.Button();
            this.txt_customerEmail = new System.Windows.Forms.TextBox();
            this.txt_customerPhNumber = new System.Windows.Forms.TextBox();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.cmb_tableType = new System.Windows.Forms.ComboBox();
            this.cmb_bookingTime = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.label7);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(790, 79);
            this.panel_top.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(274, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Table bookings panel";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.btn_cancelReservation);
            this.panel_main.Controls.Add(this.btn_makeReservation);
            this.panel_main.Controls.Add(this.txt_customerEmail);
            this.panel_main.Controls.Add(this.txt_customerPhNumber);
            this.panel_main.Controls.Add(this.txt_customerName);
            this.panel_main.Controls.Add(this.cmb_tableType);
            this.panel_main.Controls.Add(this.cmb_bookingTime);
            this.panel_main.Controls.Add(this.label6);
            this.panel_main.Controls.Add(this.label5);
            this.panel_main.Controls.Add(this.label4);
            this.panel_main.Controls.Add(this.dateTimePicker);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 79);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(790, 585);
            this.panel_main.TabIndex = 1;
            // 
            // btn_cancelReservation
            // 
            this.btn_cancelReservation.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_cancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelReservation.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelReservation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancelReservation.Location = new System.Drawing.Point(560, 427);
            this.btn_cancelReservation.Name = "btn_cancelReservation";
            this.btn_cancelReservation.Size = new System.Drawing.Size(148, 56);
            this.btn_cancelReservation.TabIndex = 27;
            this.btn_cancelReservation.Text = "Cancel";
            this.btn_cancelReservation.UseVisualStyleBackColor = false;
            this.btn_cancelReservation.Click += new System.EventHandler(this.btn_cancelReservation_Click);
            // 
            // btn_makeReservation
            // 
            this.btn_makeReservation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_makeReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_makeReservation.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_makeReservation.Location = new System.Drawing.Point(406, 427);
            this.btn_makeReservation.Name = "btn_makeReservation";
            this.btn_makeReservation.Size = new System.Drawing.Size(148, 56);
            this.btn_makeReservation.TabIndex = 26;
            this.btn_makeReservation.Text = "Place reservation";
            this.btn_makeReservation.UseVisualStyleBackColor = false;
            // 
            // txt_customerEmail
            // 
            this.txt_customerEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customerEmail.Location = new System.Drawing.Point(53, 371);
            this.txt_customerEmail.Name = "txt_customerEmail";
            this.txt_customerEmail.Size = new System.Drawing.Size(241, 29);
            this.txt_customerEmail.TabIndex = 25;
            // 
            // txt_customerPhNumber
            // 
            this.txt_customerPhNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customerPhNumber.Location = new System.Drawing.Point(420, 271);
            this.txt_customerPhNumber.Name = "txt_customerPhNumber";
            this.txt_customerPhNumber.Size = new System.Drawing.Size(241, 29);
            this.txt_customerPhNumber.TabIndex = 24;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customerName.Location = new System.Drawing.Point(53, 271);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(241, 29);
            this.txt_customerName.TabIndex = 23;
            // 
            // cmb_tableType
            // 
            this.cmb_tableType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_tableType.FormattingEnabled = true;
            this.cmb_tableType.Location = new System.Drawing.Point(164, 162);
            this.cmb_tableType.Name = "cmb_tableType";
            this.cmb_tableType.Size = new System.Drawing.Size(83, 25);
            this.cmb_tableType.TabIndex = 22;
            // 
            // cmb_bookingTime
            // 
            this.cmb_bookingTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_bookingTime.FormattingEnabled = true;
            this.cmb_bookingTime.Location = new System.Drawing.Point(535, 70);
            this.cmb_bookingTime.Name = "cmb_bookingTime";
            this.cmb_bookingTime.Size = new System.Drawing.Size(83, 25);
            this.cmb_bookingTime.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(420, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Customer phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Customer email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(53, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Customer name";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Location = new System.Drawing.Point(114, 70);
            this.dateTimePicker.MinDate = new System.DateTime(2022, 6, 21, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(280, 29);
            this.dateTimePicker.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Table type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(470, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date";
            // 
            // panel_bottom
            // 
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 609);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(790, 55);
            this.panel_bottom.TabIndex = 2;
            // 
            // Frm_adminTableReservatoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 664);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_top;
        private Panel panel_main;
        private Panel panel_bottom;
        private Button btn_cancelReservation;
        private Button btn_makeReservation;
        private TextBox txt_customerEmail;
        private TextBox txt_customerPhNumber;
        private TextBox txt_customerName;
        private ComboBox cmb_tableType;
        private ComboBox cmb_bookingTime;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
    }
}