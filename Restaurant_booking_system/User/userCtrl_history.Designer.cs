namespace Restaurant_booking_system
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date_bookingDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtGridView_history = new System.Windows.Forms.DataGridView();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel_top.Size = new System.Drawing.Size(814, 69);
            this.panel_top.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurant bookings application";
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 721);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(814, 49);
            this.panel_bottom.TabIndex = 2;
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.groupBox1);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.dtGridView_history);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 69);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(814, 652);
            this.panel_main.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.date_bookingDate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(24, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 98);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date";
            // 
            // date_bookingDate
            // 
            this.date_bookingDate.Location = new System.Drawing.Point(103, 39);
            this.date_bookingDate.Name = "date_bookingDate";
            this.date_bookingDate.Size = new System.Drawing.Size(193, 29);
            this.date_bookingDate.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Booking history";
            // 
            // dtGridView_history
            // 
            this.dtGridView_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_history.Location = new System.Drawing.Point(24, 62);
            this.dtGridView_history.Name = "dtGridView_history";
            this.dtGridView_history.RowTemplate.Height = 25;
            this.dtGridView_history.Size = new System.Drawing.Size(763, 382);
            this.dtGridView_history.TabIndex = 0;
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
            this.Size = new System.Drawing.Size(814, 770);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Label label3;
        private DateTimePicker date_bookingDate;
    }
}
