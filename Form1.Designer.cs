namespace Latihan1_DL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            btnParkingData = new Button();
            btnVehicle = new Button();
            btnMember = new Button();
            btnHourlyRates = new Button();
            btnVehicleType = new Button();
            btnMembership = new Button();
            btnEmployee = new Button();
            panelLogo = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            lblMenu = new Label();
            btnMax = new Button();
            btnMin = new Button();
            btnClose = new Button();
            label2 = new Label();
            lblTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelDekstop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnParkingData);
            panelMenu.Controls.Add(btnVehicle);
            panelMenu.Controls.Add(btnMember);
            panelMenu.Controls.Add(btnHourlyRates);
            panelMenu.Controls.Add(btnVehicleType);
            panelMenu.Controls.Add(btnMembership);
            panelMenu.Controls.Add(btnEmployee);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 681);
            panelMenu.TabIndex = 0;
            // 
            // btnParkingData
            // 
            btnParkingData.Dock = DockStyle.Top;
            btnParkingData.FlatAppearance.BorderSize = 0;
            btnParkingData.FlatStyle = FlatStyle.Flat;
            btnParkingData.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnParkingData.ForeColor = Color.Gainsboro;
            btnParkingData.Image = Properties.Resources.parking_area;
            btnParkingData.ImageAlign = ContentAlignment.MiddleLeft;
            btnParkingData.Location = new Point(0, 440);
            btnParkingData.Name = "btnParkingData";
            btnParkingData.Padding = new Padding(12, 0, 0, 0);
            btnParkingData.Size = new Size(220, 60);
            btnParkingData.TabIndex = 7;
            btnParkingData.Text = "      Parking Data";
            btnParkingData.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnParkingData.UseVisualStyleBackColor = true;
            btnParkingData.Click += btnParkingData_Click;
            // 
            // btnVehicle
            // 
            btnVehicle.Dock = DockStyle.Top;
            btnVehicle.FlatAppearance.BorderSize = 0;
            btnVehicle.FlatStyle = FlatStyle.Flat;
            btnVehicle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVehicle.ForeColor = Color.Gainsboro;
            btnVehicle.Image = Properties.Resources.car;
            btnVehicle.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehicle.Location = new Point(0, 380);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Padding = new Padding(12, 0, 0, 0);
            btnVehicle.Size = new Size(220, 60);
            btnVehicle.TabIndex = 6;
            btnVehicle.Text = "      Vehicle";
            btnVehicle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVehicle.UseVisualStyleBackColor = true;
            btnVehicle.Click += btnVehicle_Click;
            // 
            // btnMember
            // 
            btnMember.Dock = DockStyle.Top;
            btnMember.FlatAppearance.BorderSize = 0;
            btnMember.FlatStyle = FlatStyle.Flat;
            btnMember.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMember.ForeColor = Color.Gainsboro;
            btnMember.Image = Properties.Resources.customer_satisfaction;
            btnMember.ImageAlign = ContentAlignment.MiddleLeft;
            btnMember.Location = new Point(0, 320);
            btnMember.Name = "btnMember";
            btnMember.Padding = new Padding(12, 0, 0, 0);
            btnMember.Size = new Size(220, 60);
            btnMember.TabIndex = 5;
            btnMember.Text = "      Member";
            btnMember.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMember.UseVisualStyleBackColor = true;
            btnMember.Click += btnMember_Click;
            // 
            // btnHourlyRates
            // 
            btnHourlyRates.Dock = DockStyle.Top;
            btnHourlyRates.FlatAppearance.BorderSize = 0;
            btnHourlyRates.FlatStyle = FlatStyle.Flat;
            btnHourlyRates.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHourlyRates.ForeColor = Color.Gainsboro;
            btnHourlyRates.Image = Properties.Resources.rates;
            btnHourlyRates.ImageAlign = ContentAlignment.MiddleLeft;
            btnHourlyRates.Location = new Point(0, 260);
            btnHourlyRates.Name = "btnHourlyRates";
            btnHourlyRates.Padding = new Padding(12, 0, 0, 0);
            btnHourlyRates.Size = new Size(220, 60);
            btnHourlyRates.TabIndex = 4;
            btnHourlyRates.Text = "      Hourly Rates";
            btnHourlyRates.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHourlyRates.UseVisualStyleBackColor = true;
            btnHourlyRates.Click += btnHourlyRates_Click;
            // 
            // btnVehicleType
            // 
            btnVehicleType.Dock = DockStyle.Top;
            btnVehicleType.FlatAppearance.BorderSize = 0;
            btnVehicleType.FlatStyle = FlatStyle.Flat;
            btnVehicleType.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVehicleType.ForeColor = Color.Gainsboro;
            btnVehicleType.Image = Properties.Resources.vehicle1;
            btnVehicleType.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehicleType.Location = new Point(0, 200);
            btnVehicleType.Name = "btnVehicleType";
            btnVehicleType.Padding = new Padding(12, 0, 0, 0);
            btnVehicleType.Size = new Size(220, 60);
            btnVehicleType.TabIndex = 3;
            btnVehicleType.Text = "      Vehicle Type";
            btnVehicleType.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVehicleType.UseVisualStyleBackColor = true;
            btnVehicleType.Click += btnVehicleType_Click;
            // 
            // btnMembership
            // 
            btnMembership.Dock = DockStyle.Top;
            btnMembership.FlatAppearance.BorderSize = 0;
            btnMembership.FlatStyle = FlatStyle.Flat;
            btnMembership.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMembership.ForeColor = Color.Gainsboro;
            btnMembership.Image = Properties.Resources.membership;
            btnMembership.ImageAlign = ContentAlignment.MiddleLeft;
            btnMembership.Location = new Point(0, 140);
            btnMembership.Name = "btnMembership";
            btnMembership.Padding = new Padding(12, 0, 0, 0);
            btnMembership.Size = new Size(220, 60);
            btnMembership.TabIndex = 2;
            btnMembership.Text = "      Membership";
            btnMembership.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMembership.UseVisualStyleBackColor = true;
            btnMembership.Click += btnMembership_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Dock = DockStyle.Top;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.ForeColor = Color.Gainsboro;
            btnEmployee.Image = Properties.Resources.employee;
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(0, 80);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(12, 0, 0, 0);
            btnEmployee.Size = new Size(220, 60);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "      Employee";
            btnEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label3);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Image = Properties.Resources.lks1;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(3);
            label3.Size = new Size(220, 80);
            label3.TabIndex = 0;
            label3.Text = "LKS PROVINSI";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 150, 136);
            panel1.Controls.Add(lblMenu);
            panel1.Controls.Add(btnMax);
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTime);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1044, 80);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.ForeColor = SystemColors.ControlLightLight;
            lblMenu.Location = new Point(18, 28);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(0, 22);
            lblMenu.TabIndex = 5;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMax.ForeColor = Color.White;
            btnMax.Location = new Point(981, 0);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(30, 30);
            btnMax.TabIndex = 4;
            btnMax.Text = "O";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += button3_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(948, 0);
            btnMin.Margin = new Padding(0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(30, 30);
            btnMin.TabIndex = 3;
            btnMin.Text = "O";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += button2_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1014, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Image = Properties.Resources.user;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(843, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 80);
            label2.TabIndex = 1;
            label2.Text = "Hi, ADMIN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            lblTime.Dock = DockStyle.Fill;
            lblTime.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(0, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(1044, 80);
            lblTime.TabIndex = 0;
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            lblTime.Click += lblTime_Click;
            lblTime.MouseDown += panel1_MouseDown;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panelDekstop
            // 
            panelDekstop.Dock = DockStyle.Fill;
            panelDekstop.Location = new Point(220, 80);
            panelDekstop.Name = "panelDekstop";
            panelDekstop.Size = new Size(1044, 601);
            panelDekstop.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 246, 242);
            ClientSize = new Size(1264, 681);
            Controls.Add(panelDekstop);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnEmployee;
        private Panel panelLogo;
        private Button btnParkingData;
        private Button btnVehicle;
        private Button btnMember;
        private Button btnHourlyRates;
        private Button btnVehicleType;
        private Button btnMembership;
        private Panel panel1;
        private Label lblTime;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Button btnMax;
        private Button btnMin;
        private Button btnClose;
        private Panel panelDekstop;
        private Label lblMenu;
    }
}