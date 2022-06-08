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
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_checkIn = new System.Windows.Forms.ComboBox();
            this.cmb_checkOut = new System.Windows.Forms.ComboBox();
            this.cmb_tableType = new System.Windows.Forms.ComboBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_phNumber = new System.Windows.Forms.MaskedTextBox();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(689, 67);
            this.panel_top.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.txtBox_phNumber);
            this.panel_main.Controls.Add(this.label6);
            this.panel_main.Controls.Add(this.btn_cancel);
            this.panel_main.Controls.Add(this.btn_confirm);
            this.panel_main.Controls.Add(this.cmb_tableType);
            this.panel_main.Controls.Add(this.cmb_checkOut);
            this.panel_main.Controls.Add(this.cmb_checkIn);
            this.panel_main.Controls.Add(this.dateTimePicker1);
            this.panel_main.Controls.Add(this.label5);
            this.panel_main.Controls.Add(this.label4);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 67);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(689, 594);
            this.panel_main.TabIndex = 1;
            // 
            // panel_bottom
            // 
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 599);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(689, 62);
            this.panel_bottom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(206, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table reservation form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Table type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Check In : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(363, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Check Out : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // cmb_checkIn
            // 
            this.cmb_checkIn.FormattingEnabled = true;
            this.cmb_checkIn.Location = new System.Drawing.Point(151, 191);
            this.cmb_checkIn.Name = "cmb_checkIn";
            this.cmb_checkIn.Size = new System.Drawing.Size(84, 23);
            this.cmb_checkIn.TabIndex = 5;
            // 
            // cmb_checkOut
            // 
            this.cmb_checkOut.FormattingEnabled = true;
            this.cmb_checkOut.Location = new System.Drawing.Point(493, 191);
            this.cmb_checkOut.Name = "cmb_checkOut";
            this.cmb_checkOut.Size = new System.Drawing.Size(84, 23);
            this.cmb_checkOut.TabIndex = 6;
            // 
            // cmb_tableType
            // 
            this.cmb_tableType.FormattingEnabled = true;
            this.cmb_tableType.Location = new System.Drawing.Point(154, 278);
            this.cmb_tableType.Name = "cmb_tableType";
            this.cmb_tableType.Size = new System.Drawing.Size(84, 23);
            this.cmb_tableType.TabIndex = 7;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_confirm.ForeColor = System.Drawing.Color.Black;
            this.btn_confirm.Location = new System.Drawing.Point(363, 460);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(88, 41);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.Location = new System.Drawing.Point(489, 460);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 41);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone number :";
            // 
            // txtBox_phNumber
            // 
            this.txtBox_phNumber.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_phNumber.Location = new System.Drawing.Point(197, 370);
            this.txtBox_phNumber.Mask = "00-00000000000000000000";
            this.txtBox_phNumber.Name = "txtBox_phNumber";
            this.txtBox_phNumber.Size = new System.Drawing.Size(242, 30);
            this.txtBox_phNumber.TabIndex = 11;
            // 
            // userCtrlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Name = "userCtrlReservation";
            this.Size = new System.Drawing.Size(689, 661);
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
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox txtBox_phNumber;
        private Label label6;
        private Button btn_cancel;
        private Button btn_confirm;
        private ComboBox cmb_tableType;
        private ComboBox cmb_checkOut;
        private ComboBox cmb_checkIn;
        private DateTimePicker dateTimePicker1;
    }
}
