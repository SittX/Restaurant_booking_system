namespace Restaurant_booking_system
{
    partial class userCtrl_Reservation
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_phNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date_bookingDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_bookingTime = new System.Windows.Forms.ComboBox();
            this.cmb_tableType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtGrid_availableTables = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_availableTables)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1368, 67);
            this.panel_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(503, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table reservation";
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.AutoSize = true;
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.groupBox1);
            this.panel_main.Controls.Add(this.label7);
            this.panel_main.Controls.Add(this.dtGrid_availableTables);
            this.panel_main.Controls.Add(this.btn_cancel);
            this.panel_main.Controls.Add(this.btn_confirm);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 67);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1368, 636);
            this.panel_main.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_phNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.date_bookingDate);
            this.groupBox1.Controls.Add(this.cmb_bookingTime);
            this.groupBox1.Controls.Add(this.cmb_tableType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(752, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 355);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bookings details";
            // 
            // txt_phNumber
            // 
            this.txt_phNumber.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phNumber.Location = new System.Drawing.Point(214, 270);
            this.txt_phNumber.Mask = "00-00000000000000000000";
            this.txt_phNumber.Name = "txt_phNumber";
            this.txt_phNumber.Size = new System.Drawing.Size(242, 30);
            this.txt_phNumber.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(142, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Table type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(100, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Check In : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(43, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone number :";
            // 
            // date_bookingDate
            // 
            this.date_bookingDate.Location = new System.Drawing.Point(214, 66);
            this.date_bookingDate.Name = "date_bookingDate";
            this.date_bookingDate.Size = new System.Drawing.Size(193, 33);
            this.date_bookingDate.TabIndex = 4;
            // 
            // cmb_bookingTime
            // 
            this.cmb_bookingTime.FormattingEnabled = true;
            this.cmb_bookingTime.Location = new System.Drawing.Point(214, 140);
            this.cmb_bookingTime.Name = "cmb_bookingTime";
            this.cmb_bookingTime.Size = new System.Drawing.Size(193, 33);
            this.cmb_bookingTime.TabIndex = 5;
            // 
            // cmb_tableType
            // 
            this.cmb_tableType.FormattingEnabled = true;
            this.cmb_tableType.Location = new System.Drawing.Point(214, 213);
            this.cmb_tableType.Name = "cmb_tableType";
            this.cmb_tableType.Size = new System.Drawing.Size(84, 33);
            this.cmb_tableType.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(23, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Available Tables";
            // 
            // dtGrid_availableTables
            // 
            this.dtGrid_availableTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_availableTables.Location = new System.Drawing.Point(23, 65);
            this.dtGrid_availableTables.Name = "dtGrid_availableTables";
            this.dtGrid_availableTables.RowTemplate.Height = 25;
            this.dtGrid_availableTables.Size = new System.Drawing.Size(697, 418);
            this.dtGrid_availableTables.TabIndex = 12;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.Location = new System.Drawing.Point(1158, 442);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 41);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_confirm.ForeColor = System.Drawing.Color.Black;
            this.btn_confirm.Location = new System.Drawing.Point(1012, 442);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(107, 41);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 641);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1368, 62);
            this.panel_bottom.TabIndex = 2;
            // 
            // userCtrl_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Name = "userCtrl_Reservation";
            this.Size = new System.Drawing.Size(1368, 703);
            this.Load += new System.EventHandler(this.userCtrl_Reservation_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_availableTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_top;
        private Panel panel_main;
        private Panel panel_bottom;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox txt_phNumber;
        private Label label6;
        private Button btn_cancel;
        private Button btn_confirm;
        private ComboBox cmb_tableType;
        private ComboBox cmb_bookingTime;
        private DateTimePicker date_bookingDate;
        private Label label7;
        private DataGridView dtGrid_availableTables;
        private GroupBox groupBox1;
    }
}
