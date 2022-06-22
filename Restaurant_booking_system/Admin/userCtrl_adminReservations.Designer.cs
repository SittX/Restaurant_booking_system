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
            this.btn_cancelReservation = new System.Windows.Forms.Button();
            this.btn_makeReservation = new System.Windows.Forms.Button();
            this.btn_updateReservation = new System.Windows.Forms.Button();
            this.dtGridView_reservations = new System.Windows.Forms.DataGridView();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_reservations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(927, 51);
            this.panel_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(341, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservations Control panel";
            // 
            // panel_bottom
            // 
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 647);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(927, 46);
            this.panel_bottom.TabIndex = 1;
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.Controls.Add(this.btn_cancelReservation);
            this.panel_main.Controls.Add(this.btn_makeReservation);
            this.panel_main.Controls.Add(this.btn_updateReservation);
            this.panel_main.Controls.Add(this.dtGridView_reservations);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 51);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(927, 596);
            this.panel_main.TabIndex = 2;
            // 
            // btn_cancelReservation
            // 
            this.btn_cancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelReservation.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelReservation.Location = new System.Drawing.Point(735, 529);
            this.btn_cancelReservation.Name = "btn_cancelReservation";
            this.btn_cancelReservation.Size = new System.Drawing.Size(147, 61);
            this.btn_cancelReservation.TabIndex = 3;
            this.btn_cancelReservation.Text = "Cancel Reservation";
            this.btn_cancelReservation.UseVisualStyleBackColor = true;
            // 
            // btn_makeReservation
            // 
            this.btn_makeReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_makeReservation.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_makeReservation.Location = new System.Drawing.Point(381, 529);
            this.btn_makeReservation.Name = "btn_makeReservation";
            this.btn_makeReservation.Size = new System.Drawing.Size(147, 61);
            this.btn_makeReservation.TabIndex = 2;
            this.btn_makeReservation.Text = "Make Reservation";
            this.btn_makeReservation.UseVisualStyleBackColor = true;
            this.btn_makeReservation.Click += new System.EventHandler(this.btn_makeReservation_Click);
            // 
            // btn_updateReservation
            // 
            this.btn_updateReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateReservation.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_updateReservation.Location = new System.Drawing.Point(555, 529);
            this.btn_updateReservation.Name = "btn_updateReservation";
            this.btn_updateReservation.Size = new System.Drawing.Size(147, 61);
            this.btn_updateReservation.TabIndex = 1;
            this.btn_updateReservation.Text = "Update Reservation";
            this.btn_updateReservation.UseVisualStyleBackColor = true;
            // 
            // dtGridView_reservations
            // 
            this.dtGridView_reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_reservations.Location = new System.Drawing.Point(28, 6);
            this.dtGridView_reservations.Name = "dtGridView_reservations";
            this.dtGridView_reservations.RowTemplate.Height = 25;
            this.dtGridView_reservations.Size = new System.Drawing.Size(854, 517);
            this.dtGridView_reservations.TabIndex = 0;
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
            this.Size = new System.Drawing.Size(927, 693);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_reservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_top;
        private Panel panel_bottom;
        private Label label1;
        private Panel panel_main;
        private DataGridView dtGridView_reservations;
        private Button btn_cancelReservation;
        private Button btn_makeReservation;
        private Button btn_updateReservation;
    }
}
