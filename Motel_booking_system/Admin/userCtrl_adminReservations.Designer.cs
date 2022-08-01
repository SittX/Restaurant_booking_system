namespace Motel_booking_system.Admin
{
    partial class userCtrl_adminReservations
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_bookingId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancelReservation = new System.Windows.Forms.Button();
            this.btn_makeBooking = new System.Windows.Forms.Button();
            this.dtGridView_bookings = new System.Windows.Forms.DataGridView();
            this.txt_bookingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_roomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_checkIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_checkOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_bookings)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(905, 45);
            this.panel_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(329, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rooms reservations";
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 575);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(905, 16);
            this.panel_bottom.TabIndex = 1;
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.cmb_bookingId);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.btn_cancelReservation);
            this.panel_main.Controls.Add(this.btn_makeBooking);
            this.panel_main.Controls.Add(this.dtGridView_bookings);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 45);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(905, 530);
            this.panel_main.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(416, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Booking Id";
            // 
            // cmb_bookingId
            // 
            this.cmb_bookingId.FormattingEnabled = true;
            this.cmb_bookingId.Location = new System.Drawing.Point(416, 480);
            this.cmb_bookingId.Name = "cmb_bookingId";
            this.cmb_bookingId.Size = new System.Drawing.Size(170, 23);
            this.cmb_bookingId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reserved rooms";
            // 
            // btn_cancelReservation
            // 
            this.btn_cancelReservation.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelReservation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelReservation.Location = new System.Drawing.Point(636, 452);
            this.btn_cancelReservation.Name = "btn_cancelReservation";
            this.btn_cancelReservation.Size = new System.Drawing.Size(238, 43);
            this.btn_cancelReservation.TabIndex = 3;
            this.btn_cancelReservation.Text = "Remove a reservation";
            this.btn_cancelReservation.UseVisualStyleBackColor = false;
            this.btn_cancelReservation.Click += new System.EventHandler(this.btn_cancelReservation_Click);
            // 
            // btn_makeBooking
            // 
            this.btn_makeBooking.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_makeBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_makeBooking.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_makeBooking.Location = new System.Drawing.Point(20, 452);
            this.btn_makeBooking.Name = "btn_makeBooking";
            this.btn_makeBooking.Size = new System.Drawing.Size(217, 43);
            this.btn_makeBooking.TabIndex = 2;
            this.btn_makeBooking.Text = "Make a reservation";
            this.btn_makeBooking.UseVisualStyleBackColor = false;
            this.btn_makeBooking.Click += new System.EventHandler(this.btn_makeReservation_Click);
            // 
            // dtGridView_bookings
            // 
            this.dtGridView_bookings.AllowUserToAddRows = false;
            this.dtGridView_bookings.AllowUserToDeleteRows = false;
            this.dtGridView_bookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_bookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_bookingId,
            this.txt_totalPrice,
            this.txt_roomNum,
            this.txt_customerId,
            this.txt_checkIn,
            this.txt_checkOut});
            this.dtGridView_bookings.Location = new System.Drawing.Point(20, 51);
            this.dtGridView_bookings.Name = "dtGridView_bookings";
            this.dtGridView_bookings.ReadOnly = true;
            this.dtGridView_bookings.RowTemplate.Height = 25;
            this.dtGridView_bookings.Size = new System.Drawing.Size(854, 395);
            this.dtGridView_bookings.TabIndex = 0;
            // 
            // txt_bookingId
            // 
            this.txt_bookingId.DataPropertyName = "id";
            this.txt_bookingId.HeaderText = "Booking ID";
            this.txt_bookingId.Name = "txt_bookingId";
            this.txt_bookingId.ReadOnly = true;
            // 
            // txt_totalPrice
            // 
            this.txt_totalPrice.DataPropertyName = "total_price";
            this.txt_totalPrice.HeaderText = "Total Price";
            this.txt_totalPrice.Name = "txt_totalPrice";
            this.txt_totalPrice.ReadOnly = true;
            // 
            // txt_roomNum
            // 
            this.txt_roomNum.DataPropertyName = "room_id";
            this.txt_roomNum.HeaderText = "Room Number";
            this.txt_roomNum.Name = "txt_roomNum";
            this.txt_roomNum.ReadOnly = true;
            // 
            // txt_customerId
            // 
            this.txt_customerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_customerId.DataPropertyName = "cus_id";
            this.txt_customerId.HeaderText = "Customer ID";
            this.txt_customerId.Name = "txt_customerId";
            this.txt_customerId.ReadOnly = true;
            // 
            // txt_checkIn
            // 
            this.txt_checkIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_checkIn.DataPropertyName = "check_in";
            this.txt_checkIn.HeaderText = "Check In";
            this.txt_checkIn.Name = "txt_checkIn";
            this.txt_checkIn.ReadOnly = true;
            // 
            // txt_checkOut
            // 
            this.txt_checkOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_checkOut.DataPropertyName = "check_out";
            this.txt_checkOut.HeaderText = "Check Out";
            this.txt_checkOut.Name = "txt_checkOut";
            this.txt_checkOut.ReadOnly = true;
            // 
            // userCtrl_adminReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.Name = "userCtrl_adminReservations";
            this.Size = new System.Drawing.Size(905, 591);
            this.Load += new System.EventHandler(this.userCtrl_adminReservations_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_bookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_top;
        private Panel panel_bottom;
        private Label label1;
        private Panel panel_main;
        private DataGridView dtGridView_bookings;
        private Button btn_cancelReservation;
        private Button btn_makeBooking;
        private Label label2;
        private Label label3;
        private ComboBox cmb_bookingId;
        private DataGridViewTextBoxColumn txt_bookingId;
        private DataGridViewTextBoxColumn txt_totalPrice;
        private DataGridViewTextBoxColumn txt_roomNum;
        private DataGridViewTextBoxColumn txt_customerId;
        private DataGridViewTextBoxColumn txt_checkIn;
        private DataGridViewTextBoxColumn txt_checkOut;
    }
}
