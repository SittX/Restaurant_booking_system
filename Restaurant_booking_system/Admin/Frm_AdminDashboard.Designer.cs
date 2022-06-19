namespace Restaurant_booking_system.Admin
{
    partial class Frm_AdminDashboard
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_topMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_services = new System.Windows.Forms.Button();
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_reservations = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_topMenu.SuspendLayout();
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Cornsilk;
            this.panel_main.Controls.Add(this.pictureBox1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(211, 75);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1044, 676);
            this.panel_main.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Restaurant_booking_system.Properties.Resources.FineDiner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1044, 676);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_topMenu
            // 
            this.panel_topMenu.BackColor = System.Drawing.Color.Cornsilk;
            this.panel_topMenu.Controls.Add(this.label1);
            this.panel_topMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topMenu.Location = new System.Drawing.Point(211, 24);
            this.panel_topMenu.Name = "panel_topMenu";
            this.panel_topMenu.Size = new System.Drawing.Size(1044, 51);
            this.panel_topMenu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(395, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin dashboard";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Cornsilk;
            this.panel.Controls.Add(this.btn_logout);
            this.panel.Controls.Add(this.btn_services);
            this.panel.Controls.Add(this.btn_account);
            this.panel.Controls.Add(this.btn_reservations);
            this.panel.Controls.Add(this.btn_menu);
            this.panel.Controls.Add(this.panel_logo);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(211, 727);
            this.panel.TabIndex = 5;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.IndianRed;
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_logout.Location = new System.Drawing.Point(0, 324);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(211, 64);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // btn_services
            // 
            this.btn_services.BackColor = System.Drawing.Color.IndianRed;
            this.btn_services.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_services.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_services.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_services.Location = new System.Drawing.Point(0, 260);
            this.btn_services.Name = "btn_services";
            this.btn_services.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_services.Size = new System.Drawing.Size(211, 64);
            this.btn_services.TabIndex = 7;
            this.btn_services.Text = "Services";
            this.btn_services.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_services.UseVisualStyleBackColor = false;
            // 
            // btn_account
            // 
            this.btn_account.BackColor = System.Drawing.Color.IndianRed;
            this.btn_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_account.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_account.Location = new System.Drawing.Point(0, 207);
            this.btn_account.Name = "btn_account";
            this.btn_account.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_account.Size = new System.Drawing.Size(211, 53);
            this.btn_account.TabIndex = 5;
            this.btn_account.Text = "Account";
            this.btn_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_account.UseVisualStyleBackColor = false;
            // 
            // btn_reservations
            // 
            this.btn_reservations.BackColor = System.Drawing.Color.IndianRed;
            this.btn_reservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reservations.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reservations.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_reservations.Location = new System.Drawing.Point(0, 154);
            this.btn_reservations.Name = "btn_reservations";
            this.btn_reservations.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_reservations.Size = new System.Drawing.Size(211, 53);
            this.btn_reservations.TabIndex = 3;
            this.btn_reservations.Text = "Reservations";
            this.btn_reservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reservations.UseVisualStyleBackColor = false;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.IndianRed;
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_menu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_menu.Location = new System.Drawing.Point(0, 100);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_menu.Size = new System.Drawing.Size(211, 54);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.Text = "Menu";
            this.btn_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.UseVisualStyleBackColor = false;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Cornsilk;
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(211, 100);
            this.panel_logo.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingsToolStripMenuItem,
            this.bookingsHistoryToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1255, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.bookingsToolStripMenuItem.Text = "&Bookings";
            // 
            // bookingsHistoryToolStripMenuItem
            // 
            this.bookingsHistoryToolStripMenuItem.Name = "bookingsHistoryToolStripMenuItem";
            this.bookingsHistoryToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.bookingsHistoryToolStripMenuItem.Text = "Bookings &History";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "&Account";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "&Log out";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // Frm_AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 751);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_topMenu);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Frm_AdminDashboard";
            this.Text = "Frm_AdminDashboard";
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_topMenu.ResumeLayout(false);
            this.panel_topMenu.PerformLayout();
            this.panel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_main;
        private PictureBox pictureBox1;
        private Panel panel_topMenu;
        private Label label1;
        private Panel panel;
        private Button btn_logout;
        private Button btn_services;
        private Button btn_account;
        private Button btn_reservations;
        private Button btn_menu;
        private Panel panel_logo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bookingsToolStripMenuItem;
        private ToolStripMenuItem bookingsHistoryToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}