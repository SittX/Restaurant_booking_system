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
            this.dataGridView_history = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_history)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_history
            // 
            this.dataGridView_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_history.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_history.Name = "dataGridView_history";
            this.dataGridView_history.RowTemplate.Height = 25;
            this.dataGridView_history.Size = new System.Drawing.Size(814, 770);
            this.dataGridView_history.TabIndex = 0;
            // 
            // userCtrl_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.dataGridView_history);
            this.Name = "userCtrl_history";
            this.Size = new System.Drawing.Size(814, 770);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_history)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_history;
    }
}
