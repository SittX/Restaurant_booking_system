namespace Restaurant_booking_system.Admin
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
            this.btn_cancelBooking = new System.Windows.Forms.Button();
            this.btn_makeBooking = new System.Windows.Forms.Button();
            this.btn_updateBooking = new System.Windows.Forms.Button();
            this.dtGridView_bookings = new System.Windows.Forms.DataGridView();
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
            this.panel_top.Size = new System.Drawing.Size(905, 51);
            this.panel_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(341, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bookings Control panel";
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 724);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(905, 46);
            this.panel_bottom.TabIndex = 1;
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.btn_cancelBooking);
            this.panel_main.Controls.Add(this.btn_makeBooking);
            this.panel_main.Controls.Add(this.btn_updateBooking);
            this.panel_main.Controls.Add(this.dtGridView_bookings);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 51);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(905, 673);
            this.panel_main.TabIndex = 2;
            // 
            // btn_cancelBooking
            // 
            this.btn_cancelBooking.BackColor = System.Drawing.Color.Red;
            this.btn_cancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelBooking.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelBooking.Location = new System.Drawing.Point(546, 570);
            this.btn_cancelBooking.Name = "btn_cancelBooking";
            this.btn_cancelBooking.Size = new System.Drawing.Size(116, 53);
            this.btn_cancelBooking.TabIndex = 3;
            this.btn_cancelBooking.Text = "Delete ";
            this.btn_cancelBooking.UseVisualStyleBackColor = false;
            // 
            // btn_makeBooking
            // 
            this.btn_makeBooking.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_makeBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_makeBooking.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_makeBooking.Location = new System.Drawing.Point(244, 570);
            this.btn_makeBooking.Name = "btn_makeBooking";
            this.btn_makeBooking.Size = new System.Drawing.Size(110, 53);
            this.btn_makeBooking.TabIndex = 2;
            this.btn_makeBooking.Text = "Create";
            this.btn_makeBooking.UseVisualStyleBackColor = false;
            this.btn_makeBooking.Click += new System.EventHandler(this.btn_makeReservation_Click);
            // 
            // btn_updateBooking
            // 
            this.btn_updateBooking.BackColor = System.Drawing.Color.Orange;
            this.btn_updateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateBooking.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_updateBooking.Location = new System.Drawing.Point(399, 570);
            this.btn_updateBooking.Name = "btn_updateBooking";
            this.btn_updateBooking.Size = new System.Drawing.Size(116, 53);
            this.btn_updateBooking.TabIndex = 1;
            this.btn_updateBooking.Text = "Update";
            this.btn_updateBooking.UseVisualStyleBackColor = false;
            // 
            // dtGridView_bookings
            // 
            this.dtGridView_bookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_bookings.Location = new System.Drawing.Point(26, 36);
            this.dtGridView_bookings.Name = "dtGridView_bookings";
            this.dtGridView_bookings.RowTemplate.Height = 25;
            this.dtGridView_bookings.Size = new System.Drawing.Size(854, 517);
            this.dtGridView_bookings.TabIndex = 0;
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
            this.Size = new System.Drawing.Size(905, 770);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_bookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_top;
        private Panel panel_bottom;
        private Label label1;
        private Panel panel_main;
        private DataGridView dtGridView_bookings;
        private Button btn_cancelBooking;
        private Button btn_makeBooking;
        private Button btn_updateBooking;
    }
}
