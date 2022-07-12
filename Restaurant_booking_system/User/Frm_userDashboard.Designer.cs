namespace Restaurant_booking_system
{
    partial class Frm_userDashboard
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
            this.bookingsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_reservations = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_topMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel_topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingsToolStripMenuItem,
            this.bookingsHistoryToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.bookingsToolStripMenuItem.Text = "&Menu";
            // 
            // bookingsHistoryToolStripMenuItem
            // 
            this.bookingsHistoryToolStripMenuItem.Name = "bookingsHistoryToolStripMenuItem";
            this.bookingsHistoryToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bookingsHistoryToolStripMenuItem.Text = "&Booking";
            this.bookingsHistoryToolStripMenuItem.Click += new System.EventHandler(this.bookingsHistoryToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "&Account";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "&History";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "&Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
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
            this.panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel.Controls.Add(this.btn_logout);
            this.panel.Controls.Add(this.btn_history);
            this.panel.Controls.Add(this.btn_account);
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
            this.btn_logout.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Location = new System.Drawing.Point(0, 324);
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
            this.btn_history.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_history.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_history.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_history.ForeColor = System.Drawing.Color.Black;
            this.btn_history.Location = new System.Drawing.Point(0, 260);
            this.btn_history.Name = "btn_history";
            this.btn_history.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_history.Size = new System.Drawing.Size(211, 64);
            this.btn_history.TabIndex = 7;
            this.btn_history.Text = "History";
            this.btn_history.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_history.UseVisualStyleBackColor = false;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_account
            // 
            this.btn_account.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_account.ForeColor = System.Drawing.Color.Black;
            this.btn_account.Location = new System.Drawing.Point(0, 207);
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
            this.btn_reservations.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reservations.ForeColor = System.Drawing.Color.Black;
            this.btn_reservations.Location = new System.Drawing.Point(0, 154);
            this.btn_reservations.Name = "btn_reservations";
            this.btn_reservations.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_reservations.Size = new System.Drawing.Size(211, 53);
            this.btn_reservations.TabIndex = 3;
            this.btn_reservations.Text = "Booking";
            this.btn_reservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reservations.UseVisualStyleBackColor = false;
            this.btn_reservations.Click += new System.EventHandler(this.btn_reservations_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_menu.ForeColor = System.Drawing.Color.Black;
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
            this.panel_logo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(211, 100);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_topMenu
            // 
            this.panel_topMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_topMenu.Controls.Add(this.label1);
            this.panel_topMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topMenu.Location = new System.Drawing.Point(211, 24);
            this.panel_topMenu.Name = "panel_topMenu";
            this.panel_topMenu.Size = new System.Drawing.Size(1173, 60);
            this.panel_topMenu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(369, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motel room booking application";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(211, 84);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1173, 716);
            this.panel_main.TabIndex = 3;
            // 
            // Frm_userDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 800);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_topMenu);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1120, 800);
            this.Name = "Frm_userDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel_topMenu.ResumeLayout(false);
            this.panel_topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem bookingsToolStripMenuItem;
        private ToolStripMenuItem bookingsHistoryToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panel;
        private Button btn_history;
        private Button btn_account;
        private Button btn_reservations;
        private Button btn_menu;
        private Panel panel_topMenu;
        private Panel panel_main;
        private Button btn_logout;
        private Panel panel_logo;
        private Label label1;
        private ToolStripMenuItem historyToolStripMenuItem;
    }
}