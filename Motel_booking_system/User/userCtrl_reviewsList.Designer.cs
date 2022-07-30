namespace Motel_booking_system.User
{
    partial class userCtrl_reviewsList
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
            this.flowLayoutPanel_reviews = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_reviews
            // 
            this.flowLayoutPanel_reviews.AutoScroll = true;
            this.flowLayoutPanel_reviews.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel_reviews.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_reviews.Location = new System.Drawing.Point(0, 47);
            this.flowLayoutPanel_reviews.Name = "flowLayoutPanel_reviews";
            this.flowLayoutPanel_reviews.Size = new System.Drawing.Size(798, 421);
            this.flowLayoutPanel_reviews.TabIndex = 0;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_top.Controls.Add(this.label8);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(798, 41);
            this.panel_top.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(258, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 26);
            this.label8.TabIndex = 35;
            this.label8.Text = "Reviews from our customers";
            // 
            // userCtrl_reviewsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.flowLayoutPanel_reviews);
            this.Name = "userCtrl_reviewsList";
            this.Size = new System.Drawing.Size(798, 468);
            this.Load += new System.EventHandler(this.userCtrl_reviewsList_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel_reviews;
        private Panel panel_top;
        private Label label8;
    }
}
