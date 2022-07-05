namespace OLA_CAB_Management_Syatem
{
    partial class frm_MDI_OlaCab
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MDI_OlaCab));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPassengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPassengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bikeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVehicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bIkePassengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carPassengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_User_Logged_In = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.pnl_Back_Slider = new System.Windows.Forms.Panel();
            this.pb_Slider = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnl_Back_Slider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Slider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.vehicalToolStripMenuItem,
            this.driverToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1370, 45);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPassengerToolStripMenuItem,
            this.viewPassengerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(113, 41);
            this.customerToolStripMenuItem.Text = "Passenger";
            this.customerToolStripMenuItem.Visible = false;
            // 
            // addPassengerToolStripMenuItem
            // 
            this.addPassengerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bikeToolStripMenuItem,
            this.carToolStripMenuItem});
            this.addPassengerToolStripMenuItem.Name = "addPassengerToolStripMenuItem";
            this.addPassengerToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.addPassengerToolStripMenuItem.Text = "Add Passenger";
            // 
            // bikeToolStripMenuItem
            // 
            this.bikeToolStripMenuItem.Name = "bikeToolStripMenuItem";
            this.bikeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.bikeToolStripMenuItem.Text = "Bike";
            this.bikeToolStripMenuItem.Click += new System.EventHandler(this.bikeToolStripMenuItem_Click);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.carToolStripMenuItem.Text = "Car";
            this.carToolStripMenuItem.Click += new System.EventHandler(this.carToolStripMenuItem_Click);
            // 
            // viewPassengerToolStripMenuItem
            // 
            this.viewPassengerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bikeToolStripMenuItem1,
            this.carToolStripMenuItem1});
            this.viewPassengerToolStripMenuItem.Name = "viewPassengerToolStripMenuItem";
            this.viewPassengerToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.viewPassengerToolStripMenuItem.Text = "View Passenger";
            // 
            // bikeToolStripMenuItem1
            // 
            this.bikeToolStripMenuItem1.Name = "bikeToolStripMenuItem1";
            this.bikeToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.bikeToolStripMenuItem1.Text = "Bike";
            this.bikeToolStripMenuItem1.Click += new System.EventHandler(this.bikeToolStripMenuItem1_Click);
            // 
            // carToolStripMenuItem1
            // 
            this.carToolStripMenuItem1.Name = "carToolStripMenuItem1";
            this.carToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.carToolStripMenuItem1.Text = "Car";
            this.carToolStripMenuItem1.Click += new System.EventHandler(this.carToolStripMenuItem1_Click);
            // 
            // vehicalToolStripMenuItem
            // 
            this.vehicalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicalToolStripMenuItem,
            this.viewVehicalToolStripMenuItem});
            this.vehicalToolStripMenuItem.Name = "vehicalToolStripMenuItem";
            this.vehicalToolStripMenuItem.Size = new System.Drawing.Size(82, 41);
            this.vehicalToolStripMenuItem.Text = "Vehical";
            this.vehicalToolStripMenuItem.Visible = false;
            // 
            // addVehicalToolStripMenuItem
            // 
            this.addVehicalToolStripMenuItem.Name = "addVehicalToolStripMenuItem";
            this.addVehicalToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.addVehicalToolStripMenuItem.Text = "Add Vehical";
            this.addVehicalToolStripMenuItem.Click += new System.EventHandler(this.addVehicalToolStripMenuItem_Click);
            // 
            // viewVehicalToolStripMenuItem
            // 
            this.viewVehicalToolStripMenuItem.Name = "viewVehicalToolStripMenuItem";
            this.viewVehicalToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.viewVehicalToolStripMenuItem.Text = "View Vehical";
            this.viewVehicalToolStripMenuItem.Click += new System.EventHandler(this.viewVehicalToolStripMenuItem_Click);
            // 
            // driverToolStripMenuItem
            // 
            this.driverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDriverToolStripMenuItem,
            this.updateDriverToolStripMenuItem,
            this.viewDriverToolStripMenuItem});
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(74, 41);
            this.driverToolStripMenuItem.Text = "Driver";
            this.driverToolStripMenuItem.Visible = false;
            // 
            // addDriverToolStripMenuItem
            // 
            this.addDriverToolStripMenuItem.Name = "addDriverToolStripMenuItem";
            this.addDriverToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addDriverToolStripMenuItem.Text = "Add Driver";
            this.addDriverToolStripMenuItem.Click += new System.EventHandler(this.addDriverToolStripMenuItem_Click);
            // 
            // updateDriverToolStripMenuItem
            // 
            this.updateDriverToolStripMenuItem.Name = "updateDriverToolStripMenuItem";
            this.updateDriverToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.updateDriverToolStripMenuItem.Text = "Update Driver";
            this.updateDriverToolStripMenuItem.Click += new System.EventHandler(this.updateDriverToolStripMenuItem_Click);
            // 
            // viewDriverToolStripMenuItem
            // 
            this.viewDriverToolStripMenuItem.Name = "viewDriverToolStripMenuItem";
            this.viewDriverToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.viewDriverToolStripMenuItem.Text = "View Driver";
            this.viewDriverToolStripMenuItem.Click += new System.EventHandler(this.viewDriverToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAreaToolStripMenuItem,
            this.updateAreaToolStripMenuItem,
            this.viewAreaToolStripMenuItem});
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(62, 41);
            this.areaToolStripMenuItem.Text = "Area";
            this.areaToolStripMenuItem.Visible = false;
            // 
            // addAreaToolStripMenuItem
            // 
            this.addAreaToolStripMenuItem.Name = "addAreaToolStripMenuItem";
            this.addAreaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.addAreaToolStripMenuItem.Text = "Add Area";
            this.addAreaToolStripMenuItem.Click += new System.EventHandler(this.addAreaToolStripMenuItem_Click);
            // 
            // updateAreaToolStripMenuItem
            // 
            this.updateAreaToolStripMenuItem.Name = "updateAreaToolStripMenuItem";
            this.updateAreaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.updateAreaToolStripMenuItem.Text = "Update Area";
            this.updateAreaToolStripMenuItem.Click += new System.EventHandler(this.updateAreaToolStripMenuItem_Click);
            // 
            // viewAreaToolStripMenuItem
            // 
            this.viewAreaToolStripMenuItem.Name = "viewAreaToolStripMenuItem";
            this.viewAreaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewAreaToolStripMenuItem.Text = "View Area";
            this.viewAreaToolStripMenuItem.Click += new System.EventHandler(this.viewAreaToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(181, 41);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Visible = false;
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bIkePassengerToolStripMenuItem,
            this.carPassengerToolStripMenuItem,
            this.vehicleDetailsToolStripMenuItem,
            this.driverDetailsToolStripMenuItem,
            this.areaDetailsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(81, 41);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Visible = false;
            // 
            // bIkePassengerToolStripMenuItem
            // 
            this.bIkePassengerToolStripMenuItem.Name = "bIkePassengerToolStripMenuItem";
            this.bIkePassengerToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.bIkePassengerToolStripMenuItem.Text = "Bike Passenger";
            this.bIkePassengerToolStripMenuItem.Click += new System.EventHandler(this.bIkePassengerToolStripMenuItem_Click);
            // 
            // carPassengerToolStripMenuItem
            // 
            this.carPassengerToolStripMenuItem.Name = "carPassengerToolStripMenuItem";
            this.carPassengerToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.carPassengerToolStripMenuItem.Text = "Car Passenger";
            this.carPassengerToolStripMenuItem.Click += new System.EventHandler(this.carPassengerToolStripMenuItem_Click);
            // 
            // vehicleDetailsToolStripMenuItem
            // 
            this.vehicleDetailsToolStripMenuItem.Name = "vehicleDetailsToolStripMenuItem";
            this.vehicleDetailsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.vehicleDetailsToolStripMenuItem.Text = "Vehicle Details";
            this.vehicleDetailsToolStripMenuItem.Click += new System.EventHandler(this.vehicleDetailsToolStripMenuItem_Click);
            // 
            // driverDetailsToolStripMenuItem
            // 
            this.driverDetailsToolStripMenuItem.Name = "driverDetailsToolStripMenuItem";
            this.driverDetailsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.driverDetailsToolStripMenuItem.Text = "Driver Details";
            this.driverDetailsToolStripMenuItem.Click += new System.EventHandler(this.driverDetailsToolStripMenuItem_Click);
            // 
            // areaDetailsToolStripMenuItem
            // 
            this.areaDetailsToolStripMenuItem.Name = "areaDetailsToolStripMenuItem";
            this.areaDetailsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.areaDetailsToolStripMenuItem.Text = "Area Details";
            this.areaDetailsToolStripMenuItem.Click += new System.EventHandler(this.areaDetailsToolStripMenuItem_Click);
            // 
            // lbl_User_Logged_In
            // 
            this.lbl_User_Logged_In.AutoSize = true;
            this.lbl_User_Logged_In.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Logged_In.Location = new System.Drawing.Point(902, 9);
            this.lbl_User_Logged_In.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_User_Logged_In.Name = "lbl_User_Logged_In";
            this.lbl_User_Logged_In.Size = new System.Drawing.Size(116, 20);
            this.lbl_User_Logged_In.TabIndex = 3;
            this.lbl_User_Logged_In.Text = "Logging User";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Yellow;
            this.btn_Logout.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(1165, 1);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(126, 40);
            this.btn_Logout.TabIndex = 74;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // pnl_Back_Slider
            // 
            this.pnl_Back_Slider.Controls.Add(this.pb_Slider);
            this.pnl_Back_Slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Back_Slider.Location = new System.Drawing.Point(0, 45);
            this.pnl_Back_Slider.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Back_Slider.Name = "pnl_Back_Slider";
            this.pnl_Back_Slider.Size = new System.Drawing.Size(1370, 704);
            this.pnl_Back_Slider.TabIndex = 76;
            // 
            // pb_Slider
            // 
            this.pb_Slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Slider.Image = ((System.Drawing.Image)(resources.GetObject("pb_Slider.Image")));
            this.pb_Slider.Location = new System.Drawing.Point(0, 0);
            this.pb_Slider.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Slider.Name = "pb_Slider";
            this.pb_Slider.Size = new System.Drawing.Size(1370, 704);
            this.pb_Slider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Slider.TabIndex = 0;
            this.pb_Slider.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_MDI_OlaCab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnl_Back_Slider);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_User_Logged_In);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MDI_OlaCab";
            this.Text = "Ola Cab Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_MDI_OlaCab_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Back_Slider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPassengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPassengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVehicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bikeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bIkePassengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carPassengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverDetailsToolStripMenuItem;
        private System.Windows.Forms.Label lbl_User_Logged_In;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel pnl_Back_Slider;
        private System.Windows.Forms.PictureBox pb_Slider;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem areaDetailsToolStripMenuItem;
    }
}