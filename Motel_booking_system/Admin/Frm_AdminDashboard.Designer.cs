﻿namespace Motel_booking_system.Admin
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
            this.panel_topMenu = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_services = new System.Windows.Forms.Button();
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_reservations = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_reservations = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_account = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_services = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_mainBackground = new System.Windows.Forms.Panel();
            this.panel_topMenu.SuspendLayout();
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_topMenu
            // 
            this.panel_topMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_topMenu.Controls.Add(this.lbl_title);
            this.panel_topMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topMenu.Location = new System.Drawing.Point(211, 24);
            this.panel_topMenu.Name = "panel_topMenu";
            this.panel_topMenu.Size = new System.Drawing.Size(1004, 46);
            this.panel_topMenu.TabIndex = 6;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(391, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(202, 27);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Admin dashboard";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel.Controls.Add(this.btn_logout);
            this.panel.Controls.Add(this.btn_services);
            this.panel.Controls.Add(this.btn_account);
            this.panel.Controls.Add(this.btn_reservations);
            this.panel.Controls.Add(this.btn_dashboard);
            this.panel.Controls.Add(this.panel_logo);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(211, 693);
            this.panel.TabIndex = 5;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Location = new System.Drawing.Point(0, 634);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(211, 59);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_services
            // 
            this.btn_services.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_services.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_services.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_services.ForeColor = System.Drawing.Color.Black;
            this.btn_services.Location = new System.Drawing.Point(0, 269);
            this.btn_services.Name = "btn_services";
            this.btn_services.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_services.Size = new System.Drawing.Size(211, 64);
            this.btn_services.TabIndex = 7;
            this.btn_services.Text = "Services";
            this.btn_services.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_services.UseVisualStyleBackColor = false;
            this.btn_services.Click += new System.EventHandler(this.btn_services_Click);
            // 
            // btn_account
            // 
            this.btn_account.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_account.ForeColor = System.Drawing.Color.Black;
            this.btn_account.Location = new System.Drawing.Point(0, 216);
            this.btn_account.Name = "btn_account";
            this.btn_account.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_account.Size = new System.Drawing.Size(211, 53);
            this.btn_account.TabIndex = 5;
            this.btn_account.Text = "Account";
            this.btn_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_account.UseVisualStyleBackColor = false;
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // btn_reservations
            // 
            this.btn_reservations.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_reservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reservations.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_reservations.ForeColor = System.Drawing.Color.Black;
            this.btn_reservations.Location = new System.Drawing.Point(0, 163);
            this.btn_reservations.Name = "btn_reservations";
            this.btn_reservations.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_reservations.Size = new System.Drawing.Size(211, 53);
            this.btn_reservations.TabIndex = 3;
            this.btn_reservations.Text = "Bookings";
            this.btn_reservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reservations.UseVisualStyleBackColor = false;
            this.btn_reservations.Click += new System.EventHandler(this.btn_reservations_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dashboard.ForeColor = System.Drawing.Color.Black;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 109);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(211, 54);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Menu";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(211, 109);
            this.panel_logo.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_menu,
            this.menuStrip_reservations,
            this.menuStrip_account,
            this.menuStrip_services,
            this.menuStrip_logout,
            this.menuStrip_exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip_menu
            // 
            this.menuStrip_menu.Name = "menuStrip_menu";
            this.menuStrip_menu.Size = new System.Drawing.Size(50, 20);
            this.menuStrip_menu.Text = "&Menu";
            this.menuStrip_menu.Click += new System.EventHandler(this.menuStrip_menu_Click);
            // 
            // menuStrip_reservations
            // 
            this.menuStrip_reservations.Name = "menuStrip_reservations";
            this.menuStrip_reservations.Size = new System.Drawing.Size(68, 20);
            this.menuStrip_reservations.Text = "&Bookings";
            this.menuStrip_reservations.Click += new System.EventHandler(this.menuStrip_reservations_Click);
            // 
            // menuStrip_account
            // 
            this.menuStrip_account.Name = "menuStrip_account";
            this.menuStrip_account.Size = new System.Drawing.Size(64, 20);
            this.menuStrip_account.Text = "&Account";
            this.menuStrip_account.Click += new System.EventHandler(this.menuStrip_account_Click);
            // 
            // menuStrip_services
            // 
            this.menuStrip_services.Name = "menuStrip_services";
            this.menuStrip_services.Size = new System.Drawing.Size(61, 20);
            this.menuStrip_services.Text = "&Services";
            this.menuStrip_services.Click += new System.EventHandler(this.menuStrip_services_Click);
            // 
            // menuStrip_logout
            // 
            this.menuStrip_logout.Name = "menuStrip_logout";
            this.menuStrip_logout.Size = new System.Drawing.Size(60, 20);
            this.menuStrip_logout.Text = "&Log out";
            this.menuStrip_logout.Click += new System.EventHandler(this.menuStrip_logout_Click);
            // 
            // menuStrip_exit
            // 
            this.menuStrip_exit.Name = "menuStrip_exit";
            this.menuStrip_exit.Size = new System.Drawing.Size(38, 20);
            this.menuStrip_exit.Text = "E&xit";
            this.menuStrip_exit.Click += new System.EventHandler(this.menuStrip_exit_Click);
            // 
            // panel_mainBackground
            // 
            this.panel_mainBackground.BackColor = System.Drawing.Color.White;
            this.panel_mainBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainBackground.Location = new System.Drawing.Point(211, 70);
            this.panel_mainBackground.Name = "panel_mainBackground";
            this.panel_mainBackground.Size = new System.Drawing.Size(1004, 647);
            this.panel_mainBackground.TabIndex = 7;
            // 
            // Frm_AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1215, 717);
            this.Controls.Add(this.panel_mainBackground);
            this.Controls.Add(this.panel_topMenu);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Frm_AdminDashboard";
            this.Text = "Admin dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_AdminDashboard_FormClosing);
            this.panel_topMenu.ResumeLayout(false);
            this.panel_topMenu.PerformLayout();
            this.panel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel_topMenu;
        private Label lbl_title;
        private Panel panel;
        private Button btn_logout;
        private Button btn_services;
        private Button btn_account;
        private Button btn_reservations;
        private Button btn_dashboard;
        private Panel panel_logo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuStrip_menu;
        private ToolStripMenuItem menuStrip_reservations;
        private ToolStripMenuItem menuStrip_account;
        private ToolStripMenuItem menuStrip_logout;
        private ToolStripMenuItem menuStrip_exit;
        private Panel panel_mainBackground;
        private ToolStripMenuItem menuStrip_services;
    }
}