namespace Restaurant_booking_system
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coupleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.panel_accountSubMenu = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_account = new System.Windows.Forms.Button();
            this.panel_reservationsMenu = new System.Windows.Forms.Panel();
            this.btn_eventsReservation = new System.Windows.Forms.Button();
            this.btn_familyReservation = new System.Windows.Forms.Button();
            this.btn_coupleReservation = new System.Windows.Forms.Button();
            this.btn_reservations = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_topMenu = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel_accountSubMenu.SuspendLayout();
            this.panel_reservationsMenu.SuspendLayout();
            this.panel_topMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1207, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coupleToolStripMenuItem,
            this.familyToolStripMenuItem,
            this.partyToolStripMenuItem});
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.bookingsToolStripMenuItem.Text = "&Bookings";
            // 
            // coupleToolStripMenuItem
            // 
            this.coupleToolStripMenuItem.Name = "coupleToolStripMenuItem";
            this.coupleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.coupleToolStripMenuItem.Text = "&Couple";
            // 
            // familyToolStripMenuItem
            // 
            this.familyToolStripMenuItem.Name = "familyToolStripMenuItem";
            this.familyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.familyToolStripMenuItem.Text = "F&amily";
            // 
            // partyToolStripMenuItem
            // 
            this.partyToolStripMenuItem.Name = "partyToolStripMenuItem";
            this.partyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.partyToolStripMenuItem.Text = "&Party";
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.btn_logout);
            this.panel.Controls.Add(this.btn_history);
            this.panel.Controls.Add(this.panel_accountSubMenu);
            this.panel.Controls.Add(this.btn_account);
            this.panel.Controls.Add(this.panel_reservationsMenu);
            this.panel.Controls.Add(this.btn_reservations);
            this.panel.Controls.Add(this.btn_menu);
            this.panel.Controls.Add(this.panel_logo);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(211, 776);
            this.panel.TabIndex = 1;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.IndianRed;
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_logout.Location = new System.Drawing.Point(0, 632);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(211, 64);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.Color.IndianRed;
            this.btn_history.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_history.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_history.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_history.Location = new System.Drawing.Point(0, 568);
            this.btn_history.Name = "btn_history";
            this.btn_history.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_history.Size = new System.Drawing.Size(211, 64);
            this.btn_history.TabIndex = 7;
            this.btn_history.Text = "History";
            this.btn_history.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_history.UseVisualStyleBackColor = false;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // panel_accountSubMenu
            // 
            this.panel_accountSubMenu.Controls.Add(this.button9);
            this.panel_accountSubMenu.Controls.Add(this.button8);
            this.panel_accountSubMenu.Controls.Add(this.button7);
            this.panel_accountSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_accountSubMenu.Location = new System.Drawing.Point(0, 410);
            this.panel_accountSubMenu.Name = "panel_accountSubMenu";
            this.panel_accountSubMenu.Size = new System.Drawing.Size(211, 158);
            this.panel_accountSubMenu.TabIndex = 6;
            this.panel_accountSubMenu.Visible = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.RosyBrown;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 104);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(211, 54);
            this.button9.TabIndex = 2;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.RosyBrown;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(0, 52);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(211, 52);
            this.button8.TabIndex = 1;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.RosyBrown;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(211, 52);
            this.button7.TabIndex = 0;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btn_account
            // 
            this.btn_account.BackColor = System.Drawing.Color.IndianRed;
            this.btn_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_account.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_account.Location = new System.Drawing.Point(0, 357);
            this.btn_account.Name = "btn_account";
            this.btn_account.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_account.Size = new System.Drawing.Size(211, 53);
            this.btn_account.TabIndex = 5;
            this.btn_account.Text = "Account";
            this.btn_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_account.UseVisualStyleBackColor = false;
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // panel_reservationsMenu
            // 
            this.panel_reservationsMenu.Controls.Add(this.btn_eventsReservation);
            this.panel_reservationsMenu.Controls.Add(this.btn_familyReservation);
            this.panel_reservationsMenu.Controls.Add(this.btn_coupleReservation);
            this.panel_reservationsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_reservationsMenu.Location = new System.Drawing.Point(0, 207);
            this.panel_reservationsMenu.Name = "panel_reservationsMenu";
            this.panel_reservationsMenu.Size = new System.Drawing.Size(211, 150);
            this.panel_reservationsMenu.TabIndex = 4;
            this.panel_reservationsMenu.Visible = false;
            // 
            // btn_eventsReservation
            // 
            this.btn_eventsReservation.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_eventsReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_eventsReservation.FlatAppearance.BorderSize = 0;
            this.btn_eventsReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eventsReservation.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_eventsReservation.ForeColor = System.Drawing.Color.White;
            this.btn_eventsReservation.Location = new System.Drawing.Point(0, 98);
            this.btn_eventsReservation.Name = "btn_eventsReservation";
            this.btn_eventsReservation.Size = new System.Drawing.Size(211, 51);
            this.btn_eventsReservation.TabIndex = 2;
            this.btn_eventsReservation.Text = "Events";
            this.btn_eventsReservation.UseVisualStyleBackColor = false;
            this.btn_eventsReservation.Click += new System.EventHandler(this.btn_eventsReservation_Click);
            // 
            // btn_familyReservation
            // 
            this.btn_familyReservation.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_familyReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_familyReservation.FlatAppearance.BorderSize = 0;
            this.btn_familyReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_familyReservation.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_familyReservation.ForeColor = System.Drawing.Color.White;
            this.btn_familyReservation.Location = new System.Drawing.Point(0, 49);
            this.btn_familyReservation.Name = "btn_familyReservation";
            this.btn_familyReservation.Size = new System.Drawing.Size(211, 49);
            this.btn_familyReservation.TabIndex = 1;
            this.btn_familyReservation.Text = "Family";
            this.btn_familyReservation.UseVisualStyleBackColor = false;
            this.btn_familyReservation.Click += new System.EventHandler(this.btn_familyReservation_Click);
            // 
            // btn_coupleReservation
            // 
            this.btn_coupleReservation.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_coupleReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_coupleReservation.FlatAppearance.BorderSize = 0;
            this.btn_coupleReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_coupleReservation.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_coupleReservation.ForeColor = System.Drawing.Color.White;
            this.btn_coupleReservation.Location = new System.Drawing.Point(0, 0);
            this.btn_coupleReservation.Name = "btn_coupleReservation";
            this.btn_coupleReservation.Size = new System.Drawing.Size(211, 49);
            this.btn_coupleReservation.TabIndex = 0;
            this.btn_coupleReservation.Text = "Couple";
            this.btn_coupleReservation.UseVisualStyleBackColor = false;
            this.btn_coupleReservation.Click += new System.EventHandler(this.btn_coupleReservation_Click);
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
            this.btn_reservations.Click += new System.EventHandler(this.btn_reservations_Click);
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
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Snow;
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(211, 100);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_topMenu
            // 
            this.panel_topMenu.Controls.Add(this.btn_exit);
            this.panel_topMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topMenu.Location = new System.Drawing.Point(211, 24);
            this.panel_topMenu.Name = "panel_topMenu";
            this.panel_topMenu.Size = new System.Drawing.Size(996, 33);
            this.panel_topMenu.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Firebrick;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(960, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(36, 33);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(211, 57);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(996, 743);
            this.panel_main.TabIndex = 3;
            // 
            // panel_bottom
            // 
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(211, 763);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(996, 37);
            this.panel_bottom.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 800);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_topMenu);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1120, 800);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel_accountSubMenu.ResumeLayout(false);
            this.panel_reservationsMenu.ResumeLayout(false);
            this.panel_topMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem bookingsToolStripMenuItem;
        private ToolStripMenuItem coupleToolStripMenuItem;
        private ToolStripMenuItem familyToolStripMenuItem;
        private ToolStripMenuItem partyToolStripMenuItem;
        private ToolStripMenuItem bookingsHistoryToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panel;
        private Button btn_history;
        private Panel panel_accountSubMenu;
        private Button btn_account;
        private Panel panel_reservationsMenu;
        private Button btn_reservations;
        private Button btn_menu;
        private Panel panel_topMenu;
        private Panel panel_main;
        private Button btn_eventsReservation;
        private Button btn_familyReservation;
        private Button btn_coupleReservation;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button btn_exit;
        private Panel panel_bottom;
        private Button btn_logout;
        private Panel panel_logo;
    }
}