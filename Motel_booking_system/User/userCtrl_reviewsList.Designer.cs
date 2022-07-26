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
            this.SuspendLayout();
            // 
            // flowLayoutPanel_reviews
            // 
            this.flowLayoutPanel_reviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_reviews.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_reviews.Name = "flowLayoutPanel_reviews";
            this.flowLayoutPanel_reviews.Size = new System.Drawing.Size(798, 468);
            this.flowLayoutPanel_reviews.TabIndex = 0;
            // 
            // userCtrl_reviewsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel_reviews);
            this.Name = "userCtrl_reviewsList";
            this.Size = new System.Drawing.Size(798, 468);
            this.Load += new System.EventHandler(this.userCtrl_reviewsList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel_reviews;
    }
}
