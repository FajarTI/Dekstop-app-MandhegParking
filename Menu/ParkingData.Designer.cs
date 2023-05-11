namespace Latihan1_DL.Menu
{
    partial class ParkingData
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
            cbVehicleID = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            tbLicensePlate = new TextBox();
            label4 = new Label();
            gbField = new GroupBox();
            btnCount = new Button();
            lblAmount = new Label();
            panel1 = new Panel();
            dtTimeOut = new DateTimePicker();
            dtTimeIn = new DateTimePicker();
            cbHourlyRatesID = new ComboBox();
            cbEmployeeID = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbSearch = new TextBox();
            btnTambah = new Button();
            panel2 = new Panel();
            label1 = new Label();
            dtParkingData = new DataGridView();
            gbField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtParkingData).BeginInit();
            SuspendLayout();
            // 
            // cbVehicleID
            // 
            cbVehicleID.FormattingEnabled = true;
            cbVehicleID.Location = new Point(125, 51);
            cbVehicleID.Name = "cbVehicleID";
            cbVehicleID.Size = new Size(173, 23);
            cbVehicleID.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Maroon;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ControlLightLight;
            btnCancel.Location = new Point(915, 144);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 28);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.DarkGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(915, 110);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 28);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tbLicensePlate
            // 
            tbLicensePlate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbLicensePlate.Location = new Point(125, 22);
            tbLicensePlate.Name = "tbLicensePlate";
            tbLicensePlate.Size = new Size(173, 23);
            tbLicensePlate.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(15, 30);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 0;
            label4.Text = "License Plate";
            // 
            // gbField
            // 
            gbField.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbField.Controls.Add(btnCount);
            gbField.Controls.Add(lblAmount);
            gbField.Controls.Add(panel1);
            gbField.Controls.Add(dtTimeOut);
            gbField.Controls.Add(dtTimeIn);
            gbField.Controls.Add(cbHourlyRatesID);
            gbField.Controls.Add(cbEmployeeID);
            gbField.Controls.Add(cbVehicleID);
            gbField.Controls.Add(btnCancel);
            gbField.Controls.Add(btnSave);
            gbField.Controls.Add(label5);
            gbField.Controls.Add(label7);
            gbField.Controls.Add(tbLicensePlate);
            gbField.Controls.Add(label6);
            gbField.Controls.Add(label8);
            gbField.Controls.Add(label3);
            gbField.Controls.Add(label4);
            gbField.Controls.Add(label2);
            gbField.Enabled = false;
            gbField.Location = new Point(12, 409);
            gbField.Name = "gbField";
            gbField.Size = new Size(1020, 180);
            gbField.TabIndex = 29;
            gbField.TabStop = false;
            gbField.Visible = false;
            gbField.Enter += gbField_Enter;
            // 
            // btnCount
            // 
            btnCount.BackColor = Color.Sienna;
            btnCount.FlatAppearance.BorderSize = 0;
            btnCount.FlatStyle = FlatStyle.Flat;
            btnCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCount.ForeColor = Color.White;
            btnCount.Location = new Point(337, 79);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(284, 23);
            btnCount.TabIndex = 13;
            btnCount.Text = "COUNT";
            btnCount.UseVisualStyleBackColor = false;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(447, 112);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(33, 15);
            lblAmount.TabIndex = 12;
            lblAmount.Text = "Rp. 0";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(449, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 1);
            panel1.TabIndex = 11;
            // 
            // dtTimeOut
            // 
            dtTimeOut.Format = DateTimePickerFormat.Time;
            dtTimeOut.Location = new Point(448, 48);
            dtTimeOut.Name = "dtTimeOut";
            dtTimeOut.Size = new Size(173, 23);
            dtTimeOut.TabIndex = 10;
            // 
            // dtTimeIn
            // 
            dtTimeIn.Format = DateTimePickerFormat.Time;
            dtTimeIn.Location = new Point(448, 19);
            dtTimeIn.Name = "dtTimeIn";
            dtTimeIn.Size = new Size(173, 23);
            dtTimeIn.TabIndex = 10;
            // 
            // cbHourlyRatesID
            // 
            cbHourlyRatesID.FormattingEnabled = true;
            cbHourlyRatesID.Location = new Point(125, 109);
            cbHourlyRatesID.Name = "cbHourlyRatesID";
            cbHourlyRatesID.Size = new Size(173, 23);
            cbHourlyRatesID.TabIndex = 9;
            // 
            // cbEmployeeID
            // 
            cbEmployeeID.FormattingEnabled = true;
            cbEmployeeID.Location = new Point(125, 80);
            cbEmployeeID.Name = "cbEmployeeID";
            cbEmployeeID.Size = new Size(173, 23);
            cbEmployeeID.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(15, 117);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 0;
            label5.Text = "Hourly Rates ID";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(337, 56);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 0;
            label7.Text = "Datetime OUT";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(337, 30);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 0;
            label6.Text = "Datetime IN";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(337, 112);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 0;
            label8.Text = "Amount To Pay";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(15, 88);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 0;
            label3.Text = "Employee ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(15, 59);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Vehicle ID";
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearch.Location = new Point(891, 68);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Cari Data";
            tbSearch.Size = new Size(141, 23);
            tbSearch.TabIndex = 28;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.DarkGreen;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTambah.ForeColor = SystemColors.ControlLightLight;
            btnTambah.Location = new Point(12, 68);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(99, 28);
            btnTambah.TabIndex = 27;
            btnTambah.Text = "Tambah Data";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(422, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 25;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(448, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 24;
            label1.Text = "PARKING DATA";
            // 
            // dtParkingData
            // 
            dtParkingData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtParkingData.BackgroundColor = Color.FromArgb(224, 224, 224);
            dtParkingData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtParkingData.Location = new Point(12, 102);
            dtParkingData.Name = "dtParkingData";
            dtParkingData.RowTemplate.Height = 25;
            dtParkingData.Size = new Size(1020, 301);
            dtParkingData.TabIndex = 26;
            // 
            // ParkingData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 601);
            Controls.Add(gbField);
            Controls.Add(tbSearch);
            Controls.Add(btnTambah);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(dtParkingData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ParkingData";
            Text = "ParkingData";
            Load += ParkingData_Load;
            gbField.ResumeLayout(false);
            gbField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtParkingData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbVehicleID;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbLicensePlate;
        private Label label4;
        private GroupBox gbField;
        private ComboBox cbEmployeeID;
        private Label label3;
        private Label label2;
        private TextBox tbSearch;
        private Button btnTambah;
        private Panel panel2;
        private Label label1;
        private DataGridView dtParkingData;
        private Label lblAmount;
        private Panel panel1;
        private DateTimePicker dtTimeOut;
        private DateTimePicker dtTimeIn;
        private ComboBox cbHourlyRatesID;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private Button btnCount;
    }
}