namespace Restaurant_booking_system.Admin
{
    partial class userCtrl_adminServices
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
            this.txt_description = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.cmb_tableType = new System.Windows.Forms.ComboBox();
            this.btn_deleteService = new System.Windows.Forms.Button();
            this.txt_tableNumber = new System.Windows.Forms.TextBox();
            this.btn_updateService = new System.Windows.Forms.Button();
            this.btn_addService = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtGridView_services = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_services)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(966, 40);
            this.panel_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(421, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Services ";
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.txt_description);
            this.panel_main.Controls.Add(this.Description);
            this.panel_main.Controls.Add(this.cmb_tableType);
            this.panel_main.Controls.Add(this.btn_deleteService);
            this.panel_main.Controls.Add(this.txt_tableNumber);
            this.panel_main.Controls.Add(this.btn_updateService);
            this.panel_main.Controls.Add(this.btn_addService);
            this.panel_main.Controls.Add(this.label12);
            this.panel_main.Controls.Add(this.label13);
            this.panel_main.Controls.Add(this.dtGridView_services);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 40);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(966, 747);
            this.panel_main.TabIndex = 2;
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_description.Location = new System.Drawing.Point(192, 499);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(389, 117);
            this.txt_description.TabIndex = 22;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Description.Location = new System.Drawing.Point(53, 503);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(119, 26);
            this.Description.TabIndex = 23;
            this.Description.Text = "Description";
            // 
            // cmb_tableType
            // 
            this.cmb_tableType.FormattingEnabled = true;
            this.cmb_tableType.Location = new System.Drawing.Point(521, 441);
            this.cmb_tableType.Name = "cmb_tableType";
            this.cmb_tableType.Size = new System.Drawing.Size(60, 23);
            this.cmb_tableType.TabIndex = 13;
            // 
            // btn_deleteService
            // 
            this.btn_deleteService.BackColor = System.Drawing.Color.Red;
            this.btn_deleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteService.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deleteService.Location = new System.Drawing.Point(671, 573);
            this.btn_deleteService.Name = "btn_deleteService";
            this.btn_deleteService.Size = new System.Drawing.Size(208, 45);
            this.btn_deleteService.TabIndex = 21;
            this.btn_deleteService.Text = "Delete";
            this.btn_deleteService.UseVisualStyleBackColor = false;
            // 
            // txt_tableNumber
            // 
            this.txt_tableNumber.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tableNumber.Location = new System.Drawing.Point(192, 439);
            this.txt_tableNumber.Name = "txt_tableNumber";
            this.txt_tableNumber.Size = new System.Drawing.Size(124, 27);
            this.txt_tableNumber.TabIndex = 9;
            // 
            // btn_updateService
            // 
            this.btn_updateService.BackColor = System.Drawing.Color.Orange;
            this.btn_updateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateService.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_updateService.Location = new System.Drawing.Point(671, 505);
            this.btn_updateService.Name = "btn_updateService";
            this.btn_updateService.Size = new System.Drawing.Size(208, 45);
            this.btn_updateService.TabIndex = 20;
            this.btn_updateService.Text = "Update";
            this.btn_updateService.UseVisualStyleBackColor = false;
            // 
            // btn_addService
            // 
            this.btn_addService.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_addService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addService.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addService.Location = new System.Drawing.Point(671, 437);
            this.btn_addService.Name = "btn_addService";
            this.btn_addService.Size = new System.Drawing.Size(208, 45);
            this.btn_addService.TabIndex = 9;
            this.btn_addService.Text = "Add new service";
            this.btn_addService.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(400, 439);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 26);
            this.label12.TabIndex = 11;
            this.label12.Text = "Table type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(44, 437);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 26);
            this.label13.TabIndex = 10;
            this.label13.Text = "Table Number";
            // 
            // dtGridView_services
            // 
            this.dtGridView_services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_services.Location = new System.Drawing.Point(21, 20);
            this.dtGridView_services.Name = "dtGridView_services";
            this.dtGridView_services.RowTemplate.Height = 25;
            this.dtGridView_services.Size = new System.Drawing.Size(926, 338);
            this.dtGridView_services.TabIndex = 19;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 734);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(966, 53);
            this.panel_bottom.TabIndex = 24;
            // 
            // userCtrl_adminServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Name = "userCtrl_adminServices";
            this.Size = new System.Drawing.Size(966, 787);
            this.Load += new System.EventHandler(this.userCtrl_adminServices_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_services)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_top;
        private Panel panel_main;
        private DataGridView dtGridView_services;
        private Label label1;
        private TextBox txt_description;
        private Label Description;
        private ComboBox cmb_tableType;
        private Button btn_deleteService;
        private TextBox txt_tableNumber;
        private Button btn_updateService;
        private Button btn_addService;
        private Label label12;
        private Label label13;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel_bottom;
    }
}
