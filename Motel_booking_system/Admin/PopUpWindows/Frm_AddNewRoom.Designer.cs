namespace Motel_booking_system.Admin.PopUpWindows
{
    partial class Frm_AddNewRoom
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picBox_roomImg = new System.Windows.Forms.PictureBox();
            this.btn_browseImg = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_roomNo = new System.Windows.Forms.TextBox();
            this.btn_addRoom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_roomType = new System.Windows.Forms.ComboBox();
            this.ofd_img = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_roomImg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.picBox_roomImg);
            this.groupBox1.Controls.Add(this.btn_browseImg);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.txt_description);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_roomNo);
            this.groupBox1.Controls.Add(this.btn_addRoom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_roomType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 702);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Room details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "Room image";
            // 
            // picBox_roomImg
            // 
            this.picBox_roomImg.BackColor = System.Drawing.Color.White;
            this.picBox_roomImg.Location = new System.Drawing.Point(20, 59);
            this.picBox_roomImg.Name = "picBox_roomImg";
            this.picBox_roomImg.Size = new System.Drawing.Size(537, 291);
            this.picBox_roomImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_roomImg.TabIndex = 28;
            this.picBox_roomImg.TabStop = false;
            // 
            // btn_browseImg
            // 
            this.btn_browseImg.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_browseImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browseImg.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_browseImg.Location = new System.Drawing.Point(406, 356);
            this.btn_browseImg.Name = "btn_browseImg";
            this.btn_browseImg.Size = new System.Drawing.Size(151, 34);
            this.btn_browseImg.TabIndex = 27;
            this.btn_browseImg.Text = "Browse image";
            this.btn_browseImg.UseVisualStyleBackColor = false;
            this.btn_browseImg.Click += new System.EventHandler(this.btn_browseImg_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.Location = new System.Drawing.Point(475, 640);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(82, 34);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_description.Location = new System.Drawing.Point(20, 550);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(537, 69);
            this.txt_description.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Room number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Room type";
            // 
            // txt_roomNo
            // 
            this.txt_roomNo.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_roomNo.Location = new System.Drawing.Point(20, 407);
            this.txt_roomNo.Name = "txt_roomNo";
            this.txt_roomNo.Size = new System.Drawing.Size(142, 27);
            this.txt_roomNo.TabIndex = 9;
            // 
            // btn_addRoom
            // 
            this.btn_addRoom.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_addRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addRoom.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addRoom.Location = new System.Drawing.Point(382, 640);
            this.btn_addRoom.Name = "btn_addRoom";
            this.btn_addRoom.Size = new System.Drawing.Size(79, 34);
            this.btn_addRoom.TabIndex = 20;
            this.btn_addRoom.Text = "Add";
            this.btn_addRoom.UseVisualStyleBackColor = false;
            this.btn_addRoom.Click += new System.EventHandler(this.btn_addRoom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Room description";
            // 
            // cmb_roomType
            // 
            this.cmb_roomType.FormattingEnabled = true;
            this.cmb_roomType.Location = new System.Drawing.Point(20, 478);
            this.cmb_roomType.Name = "cmb_roomType";
            this.cmb_roomType.Size = new System.Drawing.Size(296, 29);
            this.cmb_roomType.TabIndex = 13;
            // 
            // ofd_img
            // 
            this.ofd_img.FileName = "openFileDialog1";
            this.ofd_img.InitialDirectory = "C:\\";
            this.ofd_img.Title = "Image for rooms";
            // 
            // Frm_AddNewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(606, 726);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_AddNewRoom";
            this.Text = "Add new room details";
            this.Load += new System.EventHandler(this.Frm_AddNewRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_roomImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_description;
        private Label label1;
        private Label label2;
        private TextBox txt_roomNo;
        private Label label3;
        private ComboBox cmb_roomType;
        private Button btn_cancel;
        private Button btn_addRoom;
        private OpenFileDialog ofd_img;
        private Label label5;
        private PictureBox picBox_roomImg;
        private Button btn_browseImg;
    }
}