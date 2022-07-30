namespace Motel_booking_system
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
            this.dtGridView_availableRooms = new System.Windows.Forms.DataGridView();
            this.txt_availableRoomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_availableRoomDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_availableRoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpBox_review = new System.Windows.Forms.GroupBox();
            this.lbl_reviewStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancelReview = new System.Windows.Forms.Button();
            this.btn_submitReview = new System.Windows.Forms.Button();
            this.txt_review = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_searchRooms = new System.Windows.Forms.Button();
            this.btn_confirmReservation = new System.Windows.Forms.Button();
            this.txt_roomNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPicker_checkOut = new System.Windows.Forms.DateTimePicker();
            this.dtPicker_checkIn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_roomType = new System.Windows.Forms.ComboBox();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_availableRooms)).BeginInit();
            this.gpBox_review.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1243, 42);
            this.panel_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(502, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room reservation";
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.AutoSize = true;
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.dtGridView_availableRooms);
            this.panel_main.Controls.Add(this.gpBox_review);
            this.panel_main.Controls.Add(this.label5);
            this.panel_main.Controls.Add(this.label8);
            this.panel_main.Controls.Add(this.groupBox2);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.ForeColor = System.Drawing.Color.White;
            this.panel_main.Location = new System.Drawing.Point(0, 42);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1243, 938);
            this.panel_main.TabIndex = 1;
            // 
            // dtGridView_availableRooms
            // 
            this.dtGridView_availableRooms.AllowUserToAddRows = false;
            this.dtGridView_availableRooms.AllowUserToDeleteRows = false;
            this.dtGridView_availableRooms.AllowUserToOrderColumns = true;
            this.dtGridView_availableRooms.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dtGridView_availableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_availableRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_availableRoomNum,
            this.txt_availableRoomDescription,
            this.txt_availableRoomPrice});
            this.dtGridView_availableRooms.Location = new System.Drawing.Point(601, 45);
            this.dtGridView_availableRooms.Name = "dtGridView_availableRooms";
            this.dtGridView_availableRooms.ReadOnly = true;
            this.dtGridView_availableRooms.RowTemplate.Height = 25;
            this.dtGridView_availableRooms.Size = new System.Drawing.Size(606, 381);
            this.dtGridView_availableRooms.TabIndex = 39;
            // 
            // txt_availableRoomNum
            // 
            this.txt_availableRoomNum.DataPropertyName = "RoomNumber";
            this.txt_availableRoomNum.HeaderText = "Room Number";
            this.txt_availableRoomNum.Name = "txt_availableRoomNum";
            this.txt_availableRoomNum.ReadOnly = true;
            // 
            // txt_availableRoomDescription
            // 
            this.txt_availableRoomDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_availableRoomDescription.DataPropertyName = "Description";
            this.txt_availableRoomDescription.HeaderText = "Description";
            this.txt_availableRoomDescription.Name = "txt_availableRoomDescription";
            this.txt_availableRoomDescription.ReadOnly = true;
            // 
            // txt_availableRoomPrice
            // 
            this.txt_availableRoomPrice.DataPropertyName = "Price";
            this.txt_availableRoomPrice.HeaderText = "Price";
            this.txt_availableRoomPrice.Name = "txt_availableRoomPrice";
            this.txt_availableRoomPrice.ReadOnly = true;
            // 
            // gpBox_review
            // 
            this.gpBox_review.BackColor = System.Drawing.Color.LightSlateGray;
            this.gpBox_review.Controls.Add(this.lbl_reviewStatus);
            this.gpBox_review.Controls.Add(this.label7);
            this.gpBox_review.Controls.Add(this.btn_cancelReview);
            this.gpBox_review.Controls.Add(this.btn_submitReview);
            this.gpBox_review.Controls.Add(this.txt_review);
            this.gpBox_review.Location = new System.Drawing.Point(25, 515);
            this.gpBox_review.Name = "gpBox_review";
            this.gpBox_review.Size = new System.Drawing.Size(1182, 384);
            this.gpBox_review.TabIndex = 41;
            this.gpBox_review.TabStop = false;
            this.gpBox_review.Text = "Service review";
            // 
            // lbl_reviewStatus
            // 
            this.lbl_reviewStatus.AutoSize = true;
            this.lbl_reviewStatus.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_reviewStatus.ForeColor = System.Drawing.Color.Black;
            this.lbl_reviewStatus.Location = new System.Drawing.Point(22, 324);
            this.lbl_reviewStatus.Name = "lbl_reviewStatus";
            this.lbl_reviewStatus.Size = new System.Drawing.Size(0, 26);
            this.lbl_reviewStatus.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(634, 52);
            this.label7.TabIndex = 42;
            this.label7.Text = "Please leave a review about your experience about us.\r\nThis help us to improve ou" +
    "r services and give better services in future.";
            // 
            // btn_cancelReview
            // 
            this.btn_cancelReview.BackColor = System.Drawing.Color.Red;
            this.btn_cancelReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelReview.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelReview.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelReview.Location = new System.Drawing.Point(1060, 324);
            this.btn_cancelReview.Name = "btn_cancelReview";
            this.btn_cancelReview.Size = new System.Drawing.Size(96, 35);
            this.btn_cancelReview.TabIndex = 37;
            this.btn_cancelReview.Text = "Cancel";
            this.btn_cancelReview.UseVisualStyleBackColor = false;
            this.btn_cancelReview.Click += new System.EventHandler(this.btn_cancelReview_Click);
            // 
            // btn_submitReview
            // 
            this.btn_submitReview.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_submitReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submitReview.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_submitReview.ForeColor = System.Drawing.Color.Black;
            this.btn_submitReview.Location = new System.Drawing.Point(960, 324);
            this.btn_submitReview.Name = "btn_submitReview";
            this.btn_submitReview.Size = new System.Drawing.Size(94, 35);
            this.btn_submitReview.TabIndex = 37;
            this.btn_submitReview.Text = "Confirm";
            this.btn_submitReview.UseVisualStyleBackColor = false;
            this.btn_submitReview.Click += new System.EventHandler(this.btn_submitReview_Click);
            // 
            // txt_review
            // 
            this.txt_review.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_review.Location = new System.Drawing.Point(22, 103);
            this.txt_review.Multiline = true;
            this.txt_review.Name = "txt_review";
            this.txt_review.Size = new System.Drawing.Size(1141, 215);
            this.txt_review.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(870, 52);
            this.label5.TabIndex = 40;
            this.label5.Text = "Note : To make a room reservation, first search available rooms within your stayc" +
    "ation day range. \r\nThen, enter the room number that you want to make reservation" +
    ". ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(601, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 26);
            this.label8.TabIndex = 34;
            this.label8.Text = "Available rooms";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_searchRooms);
            this.groupBox2.Controls.Add(this.btn_confirmReservation);
            this.groupBox2.Controls.Add(this.txt_roomNumber);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtPicker_checkOut);
            this.groupBox2.Controls.Add(this.dtPicker_checkIn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmb_roomType);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(25, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 381);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search available rooms";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(270, 301);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(96, 35);
            this.btn_cancel.TabIndex = 36;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Check In :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "Room number";
            // 
            // btn_searchRooms
            // 
            this.btn_searchRooms.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_searchRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchRooms.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_searchRooms.ForeColor = System.Drawing.Color.Black;
            this.btn_searchRooms.Location = new System.Drawing.Point(170, 199);
            this.btn_searchRooms.Name = "btn_searchRooms";
            this.btn_searchRooms.Size = new System.Drawing.Size(107, 36);
            this.btn_searchRooms.TabIndex = 31;
            this.btn_searchRooms.Text = "Search";
            this.btn_searchRooms.UseVisualStyleBackColor = false;
            this.btn_searchRooms.Click += new System.EventHandler(this.btn_searchRooms_Click);
            // 
            // btn_confirmReservation
            // 
            this.btn_confirmReservation.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_confirmReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmReservation.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_confirmReservation.ForeColor = System.Drawing.Color.Black;
            this.btn_confirmReservation.Location = new System.Drawing.Point(170, 301);
            this.btn_confirmReservation.Name = "btn_confirmReservation";
            this.btn_confirmReservation.Size = new System.Drawing.Size(94, 35);
            this.btn_confirmReservation.TabIndex = 35;
            this.btn_confirmReservation.Text = "Confirm";
            this.btn_confirmReservation.UseVisualStyleBackColor = false;
            this.btn_confirmReservation.Click += new System.EventHandler(this.btn_confirmReservation_Click);
            // 
            // txt_roomNumber
            // 
            this.txt_roomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_roomNumber.Location = new System.Drawing.Point(170, 255);
            this.txt_roomNumber.Name = "txt_roomNumber";
            this.txt_roomNumber.Size = new System.Drawing.Size(196, 29);
            this.txt_roomNumber.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Room type";
            // 
            // dtPicker_checkOut
            // 
            this.dtPicker_checkOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPicker_checkOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker_checkOut.Location = new System.Drawing.Point(383, 78);
            this.dtPicker_checkOut.MinDate = new System.DateTime(2022, 6, 21, 0, 0, 0, 0);
            this.dtPicker_checkOut.Name = "dtPicker_checkOut";
            this.dtPicker_checkOut.Size = new System.Drawing.Size(129, 29);
            this.dtPicker_checkOut.TabIndex = 30;
            // 
            // dtPicker_checkIn
            // 
            this.dtPicker_checkIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPicker_checkIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker_checkIn.Location = new System.Drawing.Point(119, 78);
            this.dtPicker_checkIn.MinDate = new System.DateTime(2022, 6, 21, 0, 0, 0, 0);
            this.dtPicker_checkIn.Name = "dtPicker_checkIn";
            this.dtPicker_checkIn.Size = new System.Drawing.Size(130, 29);
            this.dtPicker_checkIn.TabIndex = 17;
            this.dtPicker_checkIn.ValueChanged += new System.EventHandler(this.dtPicker_checkIn_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(258, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 29;
            this.label4.Text = "Check Out :";
            // 
            // cmb_roomType
            // 
            this.cmb_roomType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_roomType.FormattingEnabled = true;
            this.cmb_roomType.Location = new System.Drawing.Point(170, 168);
            this.cmb_roomType.Name = "cmb_roomType";
            this.cmb_roomType.Size = new System.Drawing.Size(258, 25);
            this.cmb_roomType.TabIndex = 22;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 964);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1243, 16);
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
            this.Size = new System.Drawing.Size(1243, 980);
            this.Load += new System.EventHandler(this.userCtrl_Reservation_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_availableRooms)).EndInit();
            this.gpBox_review.ResumeLayout(false);
            this.gpBox_review.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_top;
        private Panel panel_main;
        private Panel panel_bottom;
        private Label label1;
        private DataGridView dtGridView_availableRooms;
        private Label label8;
        private GroupBox groupBox2;
        private Label label2;
        private Button btn_searchRooms;
        private Label label3;
        private DateTimePicker dtPicker_checkOut;
        private DateTimePicker dtPicker_checkIn;
        private Label label4;
        private ComboBox cmb_roomType;
        private Label label6;
        private TextBox txt_roomNumber;
        private Button btn_cancel;
        private Button btn_confirmReservation;
        private Label label5;
        private GroupBox gpBox_review;
        private Button btn_cancelReview;
        private Button btn_submitReview;
        private TextBox txt_review;
        private Label label7;
        private Label lbl_reviewStatus;
        private DataGridViewTextBoxColumn txt_availableRoomNum;
        private DataGridViewTextBoxColumn txt_availableRoomDescription;
        private DataGridViewTextBoxColumn txt_availableRoomPrice;
    }
}
