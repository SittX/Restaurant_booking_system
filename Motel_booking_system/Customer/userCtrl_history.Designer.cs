namespace Motel_booking_system
{
    partial class userCtrl_history
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtGridView_history = new System.Windows.Forms.DataGridView();
            this.txt_bookingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_roomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_checkIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_checkOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_history)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(814, 40);
            this.panel_top.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(237, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurant bookings application";
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 493);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(814, 23);
            this.panel_bottom.TabIndex = 2;
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.dtGridView_history);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 40);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(814, 453);
            this.panel_main.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Booking history";
            // 
            // dtGridView_history
            // 
            this.dtGridView_history.AllowUserToAddRows = false;
            this.dtGridView_history.AllowUserToDeleteRows = false;
            this.dtGridView_history.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dtGridView_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_history.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_bookingId,
            this.txt_totalPrice,
            this.txt_roomNum,
            this.txt_customerId,
            this.txt_checkIn,
            this.txt_checkOut});
            this.dtGridView_history.Location = new System.Drawing.Point(24, 49);
            this.dtGridView_history.Name = "dtGridView_history";
            this.dtGridView_history.ReadOnly = true;
            this.dtGridView_history.RowTemplate.Height = 25;
            this.dtGridView_history.Size = new System.Drawing.Size(763, 382);
            this.dtGridView_history.TabIndex = 0;
            // 
            // txt_bookingId
            // 
            this.txt_bookingId.DataPropertyName = "id";
            this.txt_bookingId.HeaderText = "Booking Id";
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
            this.txt_customerId.DataPropertyName = "cus_id";
            this.txt_customerId.HeaderText = "Customer Id";
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
            // userCtrl_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.Name = "userCtrl_history";
            this.Size = new System.Drawing.Size(814, 516);
            this.Load += new System.EventHandler(this.userCtrl_history_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_history)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_top;
        private Panel panel_bottom;
        private Panel panel_main;
        private Label label1;
        private DataGridView dtGridView_history;
        private Label label2;
        private DataGridViewTextBoxColumn txt_bookingId;
        private DataGridViewTextBoxColumn txt_totalPrice;
        private DataGridViewTextBoxColumn txt_roomNum;
        private DataGridViewTextBoxColumn txt_customerId;
        private DataGridViewTextBoxColumn txt_checkIn;
        private DataGridViewTextBoxColumn txt_checkOut;
    }
}
