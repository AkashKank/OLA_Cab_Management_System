namespace OLA_CAB_Management_Syatem
{
    partial class frm_Update_Driver
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_Charges = new System.Windows.Forms.Label();
            this.tb_Charges = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Email_ID = new System.Windows.Forms.Label();
            this.lbl_Experience = new System.Windows.Forms.Label();
            this.lbl_Alternate_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Driver_ID = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Email_ID = new System.Windows.Forms.TextBox();
            this.tb_Experience = new System.Windows.Forms.TextBox();
            this.tb_Alternate_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Age = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Driver_ID = new System.Windows.Forms.TextBox();
            this.gb_Driver = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_Driver.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(660, 483);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(156, 48);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Yellow;
            this.btn_Update.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(402, 483);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(152, 48);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_Charges
            // 
            this.lbl_Charges.AutoSize = true;
            this.lbl_Charges.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Charges.Location = new System.Drawing.Point(643, 396);
            this.lbl_Charges.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Charges.Name = "lbl_Charges";
            this.lbl_Charges.Size = new System.Drawing.Size(97, 23);
            this.lbl_Charges.TabIndex = 70;
            this.lbl_Charges.Text = "Charges";
            // 
            // tb_Charges
            // 
            this.tb_Charges.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Charges.Location = new System.Drawing.Point(801, 394);
            this.tb_Charges.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Charges.Name = "tb_Charges";
            this.tb_Charges.Size = new System.Drawing.Size(246, 30);
            this.tb_Charges.TabIndex = 10;
            this.tb_Charges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numerics);
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(643, 230);
            this.lbl_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(95, 23);
            this.lbl_Address.TabIndex = 66;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Email_ID
            // 
            this.lbl_Email_ID.AutoSize = true;
            this.lbl_Email_ID.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_ID.Location = new System.Drawing.Point(639, 150);
            this.lbl_Email_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Email_ID.Name = "lbl_Email_ID";
            this.lbl_Email_ID.Size = new System.Drawing.Size(103, 23);
            this.lbl_Email_ID.TabIndex = 67;
            this.lbl_Email_ID.Text = "Email ID";
            // 
            // lbl_Experience
            // 
            this.lbl_Experience.AutoSize = true;
            this.lbl_Experience.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Experience.Location = new System.Drawing.Point(643, 322);
            this.lbl_Experience.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Experience.Name = "lbl_Experience";
            this.lbl_Experience.Size = new System.Drawing.Size(129, 23);
            this.lbl_Experience.TabIndex = 64;
            this.lbl_Experience.Text = "Experience";
            // 
            // lbl_Alternate_Mobile_No
            // 
            this.lbl_Alternate_Mobile_No.AutoSize = true;
            this.lbl_Alternate_Mobile_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Alternate_Mobile_No.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alternate_Mobile_No.Location = new System.Drawing.Point(114, 396);
            this.lbl_Alternate_Mobile_No.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Alternate_Mobile_No.Name = "lbl_Alternate_Mobile_No";
            this.lbl_Alternate_Mobile_No.Size = new System.Drawing.Size(226, 23);
            this.lbl_Alternate_Mobile_No.TabIndex = 63;
            this.lbl_Alternate_Mobile_No.Text = "Alternate Mobile No";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(114, 319);
            this.lbl_Mobile_No.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(117, 23);
            this.lbl_Mobile_No.TabIndex = 62;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Age.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.Location = new System.Drawing.Point(114, 228);
            this.lbl_Age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(51, 23);
            this.lbl_Age.TabIndex = 61;
            this.lbl_Age.Text = "Age";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(114, 150);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(72, 23);
            this.lbl_Name.TabIndex = 60;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Driver_ID
            // 
            this.lbl_Driver_ID.AutoSize = true;
            this.lbl_Driver_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Driver_ID.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Driver_ID.Location = new System.Drawing.Point(233, 44);
            this.lbl_Driver_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Driver_ID.Name = "lbl_Driver_ID";
            this.lbl_Driver_ID.Size = new System.Drawing.Size(106, 23);
            this.lbl_Driver_ID.TabIndex = 59;
            this.lbl_Driver_ID.Text = "Driver Id";
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(801, 228);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(246, 30);
            this.tb_Address.TabIndex = 8;
            // 
            // tb_Email_ID
            // 
            this.tb_Email_ID.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_ID.Location = new System.Drawing.Point(801, 145);
            this.tb_Email_ID.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Email_ID.Name = "tb_Email_ID";
            this.tb_Email_ID.Size = new System.Drawing.Size(246, 30);
            this.tb_Email_ID.TabIndex = 7;
            // 
            // tb_Experience
            // 
            this.tb_Experience.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Experience.Location = new System.Drawing.Point(801, 319);
            this.tb_Experience.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Experience.Name = "tb_Experience";
            this.tb_Experience.Size = new System.Drawing.Size(246, 30);
            this.tb_Experience.TabIndex = 9;
            // 
            // tb_Alternate_Mobile_No
            // 
            this.tb_Alternate_Mobile_No.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alternate_Mobile_No.Location = new System.Drawing.Point(353, 394);
            this.tb_Alternate_Mobile_No.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Alternate_Mobile_No.Name = "tb_Alternate_Mobile_No";
            this.tb_Alternate_Mobile_No.Size = new System.Drawing.Size(247, 30);
            this.tb_Alternate_Mobile_No.TabIndex = 6;
            this.tb_Alternate_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numerics);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Malgun Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Header.Location = new System.Drawing.Point(450, -8);
            this.lbl_Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(487, 89);
            this.lbl_Header.TabIndex = 12;
            this.lbl_Header.Text = "Update Driver";
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(353, 314);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(247, 30);
            this.tb_Mobile_No.TabIndex = 5;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numerics);
            // 
            // tb_Age
            // 
            this.tb_Age.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Age.Location = new System.Drawing.Point(353, 225);
            this.tb_Age.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Age.Name = "tb_Age";
            this.tb_Age.Size = new System.Drawing.Size(247, 30);
            this.tb_Age.TabIndex = 4;
            this.tb_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numerics);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(353, 145);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(247, 30);
            this.tb_Name.TabIndex = 3;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Driver_ID
            // 
            this.tb_Driver_ID.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Driver_ID.Location = new System.Drawing.Point(472, 44);
            this.tb_Driver_ID.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Driver_ID.Name = "tb_Driver_ID";
            this.tb_Driver_ID.Size = new System.Drawing.Size(189, 30);
            this.tb_Driver_ID.TabIndex = 1;
            this.tb_Driver_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numerics);
            // 
            // gb_Driver
            // 
            this.gb_Driver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(100)))));
            this.gb_Driver.Controls.Add(this.btn_Search);
            this.gb_Driver.Controls.Add(this.btn_Refresh);
            this.gb_Driver.Controls.Add(this.btn_Update);
            this.gb_Driver.Controls.Add(this.lbl_Charges);
            this.gb_Driver.Controls.Add(this.tb_Charges);
            this.gb_Driver.Controls.Add(this.lbl_Address);
            this.gb_Driver.Controls.Add(this.lbl_Email_ID);
            this.gb_Driver.Controls.Add(this.lbl_Experience);
            this.gb_Driver.Controls.Add(this.lbl_Alternate_Mobile_No);
            this.gb_Driver.Controls.Add(this.lbl_Mobile_No);
            this.gb_Driver.Controls.Add(this.lbl_Age);
            this.gb_Driver.Controls.Add(this.lbl_Name);
            this.gb_Driver.Controls.Add(this.lbl_Driver_ID);
            this.gb_Driver.Controls.Add(this.tb_Address);
            this.gb_Driver.Controls.Add(this.tb_Email_ID);
            this.gb_Driver.Controls.Add(this.tb_Experience);
            this.gb_Driver.Controls.Add(this.tb_Alternate_Mobile_No);
            this.gb_Driver.Controls.Add(this.tb_Mobile_No);
            this.gb_Driver.Controls.Add(this.tb_Age);
            this.gb_Driver.Controls.Add(this.tb_Name);
            this.gb_Driver.Controls.Add(this.tb_Driver_ID);
            this.gb_Driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Driver.Location = new System.Drawing.Point(121, 113);
            this.gb_Driver.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Driver.Name = "gb_Driver";
            this.gb_Driver.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Driver.Size = new System.Drawing.Size(1128, 641);
            this.gb_Driver.TabIndex = 0;
            this.gb_Driver.TabStop = false;
            this.gb_Driver.Text = "Driver Details";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(716, 31);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(160, 48);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(222)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1727, 81);
            this.panel1.TabIndex = 50;
            // 
            // frm_Update_Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Driver);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Update_Driver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Driver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numerics);
            this.gb_Driver.ResumeLayout(false);
            this.gb_Driver.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_Charges;
        private System.Windows.Forms.TextBox tb_Charges;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Email_ID;
        private System.Windows.Forms.Label lbl_Experience;
        private System.Windows.Forms.Label lbl_Alternate_Mobile_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Driver_ID;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Email_ID;
        private System.Windows.Forms.TextBox tb_Experience;
        private System.Windows.Forms.TextBox tb_Alternate_Mobile_No;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Age;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Driver_ID;
        private System.Windows.Forms.GroupBox gb_Driver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Search;
    }
}