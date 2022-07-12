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
            this.dtGridView_rooms = new System.Windows.Forms.DataGridView();
            this.txt_roomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_deleteType = new System.Windows.Forms.Button();
            this.cmb_typeId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtGridView_roomTypes = new System.Windows.Forms.DataGridView();
            this.txt_typeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_typeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_newTypeDescription = new System.Windows.Forms.TextBox();
            this.btn_addNewType = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_roomNumber = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_deleteService = new System.Windows.Forms.Button();
            this.btn_addService = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_roomTypes)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panel_main.Controls.Add(this.dtGridView_rooms);
            this.panel_main.Controls.Add(this.btn_deleteType);
            this.panel_main.Controls.Add(this.cmb_typeId);
            this.panel_main.Controls.Add(this.label5);
            this.panel_main.Controls.Add(this.dtGridView_roomTypes);
            this.panel_main.Controls.Add(this.groupBox1);
            this.panel_main.Controls.Add(this.label4);
            this.panel_main.Controls.Add(this.cmb_roomNumber);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.btn_deleteService);
            this.panel_main.Controls.Add(this.btn_addService);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 40);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(966, 747);
            this.panel_main.TabIndex = 2;
            // 
            // dtGridView_rooms
            // 
            this.dtGridView_rooms.AllowUserToAddRows = false;
            this.dtGridView_rooms.AllowUserToDeleteRows = false;
            this.dtGridView_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_rooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_roomId,
            this.txt_roomType,
            this.txt_description});
            this.dtGridView_rooms.Location = new System.Drawing.Point(21, 63);
            this.dtGridView_rooms.Name = "dtGridView_rooms";
            this.dtGridView_rooms.ReadOnly = true;
            this.dtGridView_rooms.RowTemplate.Height = 25;
            this.dtGridView_rooms.Size = new System.Drawing.Size(560, 275);
            this.dtGridView_rooms.TabIndex = 40;
            // 
            // txt_roomId
            // 
            this.txt_roomId.DataPropertyName = "id";
            this.txt_roomId.HeaderText = "Room Number";
            this.txt_roomId.Name = "txt_roomId";
            this.txt_roomId.ReadOnly = true;
            // 
            // txt_roomType
            // 
            this.txt_roomType.DataPropertyName = "type_description";
            this.txt_roomType.HeaderText = "Type";
            this.txt_roomType.Name = "txt_roomType";
            this.txt_roomType.ReadOnly = true;
            // 
            // txt_description
            // 
            this.txt_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_description.DataPropertyName = "room_description";
            this.txt_description.HeaderText = "Description";
            this.txt_description.Name = "txt_description";
            this.txt_description.ReadOnly = true;
            // 
            // btn_deleteType
            // 
            this.btn_deleteType.BackColor = System.Drawing.Color.Red;
            this.btn_deleteType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteType.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deleteType.Location = new System.Drawing.Point(441, 647);
            this.btn_deleteType.Name = "btn_deleteType";
            this.btn_deleteType.Size = new System.Drawing.Size(140, 45);
            this.btn_deleteType.TabIndex = 39;
            this.btn_deleteType.Text = "Delete type";
            this.btn_deleteType.UseVisualStyleBackColor = false;
            this.btn_deleteType.Click += new System.EventHandler(this.btn_deleteType_Click);
            // 
            // cmb_typeId
            // 
            this.cmb_typeId.FormattingEnabled = true;
            this.cmb_typeId.Location = new System.Drawing.Point(178, 658);
            this.cmb_typeId.Name = "cmb_typeId";
            this.cmb_typeId.Size = new System.Drawing.Size(218, 23);
            this.cmb_typeId.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 655);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 26);
            this.label5.TabIndex = 37;
            this.label5.Text = "Type number";
            // 
            // dtGridView_roomTypes
            // 
            this.dtGridView_roomTypes.AllowUserToAddRows = false;
            this.dtGridView_roomTypes.AllowUserToDeleteRows = false;
            this.dtGridView_roomTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_roomTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_typeId,
            this.txt_typeDescription});
            this.dtGridView_roomTypes.Location = new System.Drawing.Point(21, 395);
            this.dtGridView_roomTypes.Name = "dtGridView_roomTypes";
            this.dtGridView_roomTypes.ReadOnly = true;
            this.dtGridView_roomTypes.RowTemplate.Height = 25;
            this.dtGridView_roomTypes.Size = new System.Drawing.Size(560, 236);
            this.dtGridView_roomTypes.TabIndex = 36;
            // 
            // txt_typeId
            // 
            this.txt_typeId.DataPropertyName = "id";
            this.txt_typeId.HeaderText = "TypeId";
            this.txt_typeId.Name = "txt_typeId";
            this.txt_typeId.ReadOnly = true;
            // 
            // txt_typeDescription
            // 
            this.txt_typeDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_typeDescription.DataPropertyName = "type_description";
            this.txt_typeDescription.HeaderText = "Type Description";
            this.txt_typeDescription.Name = "txt_typeDescription";
            this.txt_typeDescription.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_newTypeDescription);
            this.groupBox1.Controls.Add(this.btn_addNewType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(587, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 236);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New type details";
            // 
            // txt_newTypeDescription
            // 
            this.txt_newTypeDescription.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_newTypeDescription.Location = new System.Drawing.Point(16, 76);
            this.txt_newTypeDescription.Multiline = true;
            this.txt_newTypeDescription.Name = "txt_newTypeDescription";
            this.txt_newTypeDescription.Size = new System.Drawing.Size(297, 80);
            this.txt_newTypeDescription.TabIndex = 32;
            // 
            // btn_addNewType
            // 
            this.btn_addNewType.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_addNewType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addNewType.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addNewType.Location = new System.Drawing.Point(16, 171);
            this.btn_addNewType.Name = "btn_addNewType";
            this.btn_addNewType.Size = new System.Drawing.Size(147, 45);
            this.btn_addNewType.TabIndex = 34;
            this.btn_addNewType.Text = "Add new type";
            this.btn_addNewType.UseVisualStyleBackColor = false;
            this.btn_addNewType.Click += new System.EventHandler(this.btn_addNewType_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 26);
            this.label6.TabIndex = 33;
            this.label6.Text = "Type description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 29;
            this.label4.Text = "Room types";
            // 
            // cmb_roomNumber
            // 
            this.cmb_roomNumber.FormattingEnabled = true;
            this.cmb_roomNumber.Location = new System.Drawing.Point(773, 179);
            this.cmb_roomNumber.Name = "cmb_roomNumber";
            this.cmb_roomNumber.Size = new System.Drawing.Size(60, 23);
            this.cmb_roomNumber.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(625, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Room number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Room Number";
            // 
            // btn_deleteService
            // 
            this.btn_deleteService.BackColor = System.Drawing.Color.Red;
            this.btn_deleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteService.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deleteService.Location = new System.Drawing.Point(625, 226);
            this.btn_deleteService.Name = "btn_deleteService";
            this.btn_deleteService.Size = new System.Drawing.Size(208, 45);
            this.btn_deleteService.TabIndex = 21;
            this.btn_deleteService.Text = "Delete room";
            this.btn_deleteService.UseVisualStyleBackColor = false;
            this.btn_deleteService.Click += new System.EventHandler(this.btn_deleteService_Click);
            // 
            // btn_addService
            // 
            this.btn_addService.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_addService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addService.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addService.Location = new System.Drawing.Point(625, 88);
            this.btn_addService.Name = "btn_addService";
            this.btn_addService.Size = new System.Drawing.Size(208, 45);
            this.btn_addService.TabIndex = 9;
            this.btn_addService.Text = "Add new room";
            this.btn_addService.UseVisualStyleBackColor = false;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 769);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(966, 18);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_roomTypes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_top;
        private Panel panel_main;
        private Label label1;
        private Button btn_deleteService;
        private Button btn_addService;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel_bottom;
        private Label label2;
        private ComboBox cmb_roomNumber;
        private Label label3;
        private Label label4;
        private TextBox txt_newTypeDescription;
        private Label label6;
        private Button btn_addNewType;
        private GroupBox groupBox1;
        private DataGridView dtGridView_roomTypes;
        private DataGridViewTextBoxColumn txt_typeId;
        private DataGridViewTextBoxColumn txt_typeDescription;
        private Button btn_deleteType;
        private ComboBox cmb_typeId;
        private Label label5;
        private DataGridView dtGridView_rooms;
        private DataGridViewTextBoxColumn txt_roomId;
        private DataGridViewTextBoxColumn txt_roomType;
        private DataGridViewTextBoxColumn txt_description;
    }
}
