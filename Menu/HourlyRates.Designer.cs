namespace Latihan1_DL.Menu
{
    partial class HourlyRates
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
            gbField = new GroupBox();
            cbVehicleTypeID = new ComboBox();
            cbMembershipID = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            tbValue = new TextBox();
            label4 = new Label();
            lbl = new Label();
            label2 = new Label();
            tbSearch = new TextBox();
            btnTambah = new Button();
            dtHourlyRates = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            btnSaveEdit = new Button();
            gbField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtHourlyRates).BeginInit();
            SuspendLayout();
            // 
            // gbField
            // 
            gbField.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbField.Controls.Add(btnSaveEdit);
            gbField.Controls.Add(cbVehicleTypeID);
            gbField.Controls.Add(cbMembershipID);
            gbField.Controls.Add(btnCancel);
            gbField.Controls.Add(btnSave);
            gbField.Controls.Add(tbValue);
            gbField.Controls.Add(label4);
            gbField.Controls.Add(lbl);
            gbField.Controls.Add(label2);
            gbField.Enabled = false;
            gbField.Location = new Point(4, 405);
            gbField.Name = "gbField";
            gbField.Size = new Size(1036, 192);
            gbField.TabIndex = 23;
            gbField.TabStop = false;
            gbField.Visible = false;
            // 
            // cbVehicleTypeID
            // 
            cbVehicleTypeID.FormattingEnabled = true;
            cbVehicleTypeID.Location = new Point(123, 80);
            cbVehicleTypeID.Name = "cbVehicleTypeID";
            cbVehicleTypeID.Size = new Size(173, 23);
            cbVehicleTypeID.TabIndex = 9;
            // 
            // cbMembershipID
            // 
            cbMembershipID.FormattingEnabled = true;
            cbMembershipID.Location = new Point(123, 51);
            cbMembershipID.Name = "cbMembershipID";
            cbMembershipID.Size = new Size(173, 23);
            cbMembershipID.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Maroon;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ControlLightLight;
            btnCancel.Location = new Point(931, 151);
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
            btnSave.Location = new Point(931, 117);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 28);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbValue
            // 
            tbValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbValue.Location = new Point(123, 22);
            tbValue.Name = "tbValue";
            tbValue.Size = new Size(173, 23);
            tbValue.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(13, 88);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 0;
            label4.Text = "Vehicle Type ID";
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl.AutoSize = true;
            lbl.Location = new Point(13, 59);
            lbl.Name = "lbl";
            lbl.Size = new Size(88, 15);
            lbl.TabIndex = 0;
            lbl.Text = "Membership ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(13, 30);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 0;
            label2.Text = "Value";
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearch.Location = new Point(899, 67);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Cari Data";
            tbSearch.Size = new Size(141, 23);
            tbSearch.TabIndex = 22;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.DarkGreen;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTambah.ForeColor = SystemColors.ControlLightLight;
            btnTambah.Location = new Point(4, 63);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(99, 28);
            btnTambah.TabIndex = 21;
            btnTambah.Text = "Tambah Data";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // dtHourlyRates
            // 
            dtHourlyRates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtHourlyRates.BackgroundColor = Color.FromArgb(224, 224, 224);
            dtHourlyRates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtHourlyRates.Location = new Point(4, 97);
            dtHourlyRates.Name = "dtHourlyRates";
            dtHourlyRates.RowTemplate.Height = 25;
            dtHourlyRates.Size = new Size(1036, 302);
            dtHourlyRates.TabIndex = 20;
            dtHourlyRates.CellContentClick += dtHourlyRates_CellContentClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(422, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 19;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(448, 10);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 18;
            label1.Text = "HOURLY RATES";
            label1.Click += label1_Click;
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveEdit.BackColor = Color.DarkGreen;
            btnSaveEdit.FlatAppearance.BorderSize = 0;
            btnSaveEdit.FlatStyle = FlatStyle.Flat;
            btnSaveEdit.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveEdit.ForeColor = SystemColors.ControlLightLight;
            btnSaveEdit.Location = new Point(929, 117);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new Size(99, 28);
            btnSaveEdit.TabIndex = 10;
            btnSaveEdit.Text = "Save";
            btnSaveEdit.UseVisualStyleBackColor = false;
            btnSaveEdit.Visible = false;
            btnSaveEdit.Click += btnSaveEdit_Click;
            // 
            // HourlyRates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 601);
            Controls.Add(gbField);
            Controls.Add(tbSearch);
            Controls.Add(btnTambah);
            Controls.Add(dtHourlyRates);
            Controls.Add(panel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HourlyRates";
            Text = "HourlyRates";
            Load += HourlyRates_Load;
            gbField.ResumeLayout(false);
            gbField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtHourlyRates).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbField;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbValue;
        private Label label2;
        private TextBox tbSearch;
        private Button btnTambah;
        private DataGridView dtHourlyRates;
        private Panel panel2;
        private Label label1;
        private ComboBox cbVehicleTypeID;
        private ComboBox cbMembershipID;
        private Label label4;
        private Label lbl;
        private Button btnSaveEdit;
    }
}