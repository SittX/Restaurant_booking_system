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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.panel_accountSubMenu = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_accountMenu = new System.Windows.Forms.Button();
            this.panel_reservationsMenu = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_reservationsMenu = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_accountSubMenu.SuspendLayout();
            this.panel_reservationsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_logOut);
            this.panel1.Controls.Add(this.panel_accountSubMenu);
            this.panel1.Controls.Add(this.btn_accountMenu);
            this.panel1.Controls.Add(this.panel_reservationsMenu);
            this.panel1.Controls.Add(this.btn_reservationsMenu);
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 776);
            this.panel1.TabIndex = 1;
            // 
            // btn_logOut
            // 
            this.btn_logOut.BackColor = System.Drawing.Color.IndianRed;
            this.btn_logOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logOut.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logOut.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_logOut.Location = new System.Drawing.Point(0, 565);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_logOut.Size = new System.Drawing.Size(211, 64);
            this.btn_logOut.TabIndex = 7;
            this.btn_logOut.Text = "Log out";
            this.btn_logOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logOut.UseVisualStyleBackColor = false;
            // 
            // panel_accountSubMenu
            // 
            this.panel_accountSubMenu.Controls.Add(this.button9);
            this.panel_accountSubMenu.Controls.Add(this.button8);
            this.panel_accountSubMenu.Controls.Add(this.button7);
            this.panel_accountSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_accountSubMenu.Location = new System.Drawing.Point(0, 407);
            this.panel_accountSubMenu.Name = "panel_accountSubMenu";
            this.panel_accountSubMenu.Size = new System.Drawing.Size(211, 158);
            this.panel_accountSubMenu.TabIndex = 6;
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
            // btn_accountMenu
            // 
            this.btn_accountMenu.BackColor = System.Drawing.Color.IndianRed;
            this.btn_accountMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_accountMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accountMenu.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_accountMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_accountMenu.Location = new System.Drawing.Point(0, 354);
            this.btn_accountMenu.Name = "btn_accountMenu";
            this.btn_accountMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_accountMenu.Size = new System.Drawing.Size(211, 53);
            this.btn_accountMenu.TabIndex = 5;
            this.btn_accountMenu.Text = "Account";
            this.btn_accountMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_accountMenu.UseVisualStyleBackColor = false;
            this.btn_accountMenu.Click += new System.EventHandler(this.btn_accountMenu_Click);
            // 
            // panel_reservationsMenu
            // 
            this.panel_reservationsMenu.Controls.Add(this.button6);
            this.panel_reservationsMenu.Controls.Add(this.button5);
            this.panel_reservationsMenu.Controls.Add(this.button1);
            this.panel_reservationsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_reservationsMenu.Location = new System.Drawing.Point(0, 204);
            this.panel_reservationsMenu.Name = "panel_reservationsMenu";
            this.panel_reservationsMenu.Size = new System.Drawing.Size(211, 150);
            this.panel_reservationsMenu.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RosyBrown;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(211, 51);
            this.button6.TabIndex = 2;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RosyBrown;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 49);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_reservationsMenu
            // 
            this.btn_reservationsMenu.BackColor = System.Drawing.Color.IndianRed;
            this.btn_reservationsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reservationsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reservationsMenu.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reservationsMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_reservationsMenu.Location = new System.Drawing.Point(0, 151);
            this.btn_reservationsMenu.Name = "btn_reservationsMenu";
            this.btn_reservationsMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_reservationsMenu.Size = new System.Drawing.Size(211, 53);
            this.btn_reservationsMenu.TabIndex = 3;
            this.btn_reservationsMenu.Text = "Reservations";
            this.btn_reservationsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reservationsMenu.UseVisualStyleBackColor = false;
            this.btn_reservationsMenu.Click += new System.EventHandler(this.btn_reservationsMenu_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.IndianRed;
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_menu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_menu.Location = new System.Drawing.Point(0, 97);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_menu.Size = new System.Drawing.Size(211, 54);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.Text = "Menu";
            this.btn_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 97);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(211, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 33);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(211, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 743);
            this.panel3.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1120, 800);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_accountSubMenu.ResumeLayout(false);
            this.panel_reservationsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
        private Panel panel1;
        private Button btn_logOut;
        private Panel panel_accountSubMenu;
        private Button btn_accountMenu;
        private Panel panel_reservationsMenu;
        private Button btn_reservationsMenu;
        private Button btn_menu;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Button button6;
        private Button button5;
        private Button button1;
        private Button button9;
        private Button button8;
        private Button button7;
        private FileSystemWatcher fileSystemWatcher1;
    }
}