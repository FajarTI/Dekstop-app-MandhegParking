namespace Latihan1_DL.Menu
{
    partial class Vehicle
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
            cbVehicleType = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            tbNotes = new TextBox();
            label5 = new Label();
            tbLicensePlate = new TextBox();
            label4 = new Label();
            gbField = new GroupBox();
            btnSaveEdit = new Button();
            cbMemberID = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            tbSearch = new TextBox();
            btnTambah = new Button();
            panel2 = new Panel();
            label1 = new Label();
            dtVehicle = new DataGridView();
            gbField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtVehicle).BeginInit();
            SuspendLayout();
            // 
            // cbVehicleType
            // 
            cbVehicleType.FormattingEnabled = true;
            cbVehicleType.Location = new Point(123, 22);
            cbVehicleType.Name = "cbVehicleType";
            cbVehicleType.Size = new Size(173, 23);
            cbVehicleType.TabIndex = 9;
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
            btnSave.Click += btnSave_Click;
            // 
            // tbNotes
            // 
            tbNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbNotes.Location = new Point(123, 109);
            tbNotes.Multiline = true;
            tbNotes.Name = "tbNotes";
            tbNotes.ScrollBars = ScrollBars.Vertical;
            tbNotes.Size = new Size(173, 52);
            tbNotes.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(13, 117);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 0;
            label5.Text = "Notes";
            // 
            // tbLicensePlate
            // 
            tbLicensePlate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbLicensePlate.Location = new Point(123, 80);
            tbLicensePlate.Name = "tbLicensePlate";
            tbLicensePlate.Size = new Size(173, 23);
            tbLicensePlate.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(13, 88);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 0;
            label4.Text = "License Plate";
            // 
            // gbField
            // 
            gbField.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbField.Controls.Add(btnSaveEdit);
            gbField.Controls.Add(cbMemberID);
            gbField.Controls.Add(cbVehicleType);
            gbField.Controls.Add(btnCancel);
            gbField.Controls.Add(btnSave);
            gbField.Controls.Add(tbNotes);
            gbField.Controls.Add(label5);
            gbField.Controls.Add(tbLicensePlate);
            gbField.Controls.Add(label3);
            gbField.Controls.Add(label4);
            gbField.Controls.Add(label2);
            gbField.Enabled = false;
            gbField.Location = new Point(12, 410);
            gbField.Name = "gbField";
            gbField.Size = new Size(1020, 180);
            gbField.TabIndex = 23;
            gbField.TabStop = false;
            gbField.Visible = false;
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveEdit.BackColor = Color.DarkGreen;
            btnSaveEdit.FlatAppearance.BorderSize = 0;
            btnSaveEdit.FlatStyle = FlatStyle.Flat;
            btnSaveEdit.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveEdit.ForeColor = SystemColors.ControlLightLight;
            btnSaveEdit.Location = new Point(915, 109);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new Size(99, 28);
            btnSaveEdit.TabIndex = 10;
            btnSaveEdit.Text = "Save";
            btnSaveEdit.UseVisualStyleBackColor = false;
            btnSaveEdit.Visible = false;
            btnSaveEdit.Click += btnSaveEdit_Click;
            // 
            // cbMemberID
            // 
            cbMemberID.FormattingEnabled = true;
            cbMemberID.Location = new Point(123, 51);
            cbMemberID.Name = "cbMemberID";
            cbMemberID.Size = new Size(173, 23);
            cbMemberID.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(13, 59);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 0;
            label3.Text = "Member ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(13, 30);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 0;
            label2.Text = "Vehicle Type ID";
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearch.Location = new Point(891, 72);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Cari Data";
            tbSearch.Size = new Size(141, 23);
            tbSearch.TabIndex = 22;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.DarkGreen;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTambah.ForeColor = SystemColors.ControlLightLight;
            btnTambah.Location = new Point(12, 67);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(99, 28);
            btnTambah.TabIndex = 21;
            btnTambah.Text = "Tambah Data";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(422, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 19;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(476, 10);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 18;
            label1.Text = "VEHICLE";
            // 
            // dtVehicle
            // 
            dtVehicle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtVehicle.BackgroundColor = Color.FromArgb(224, 224, 224);
            dtVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtVehicle.Location = new Point(12, 101);
            dtVehicle.Name = "dtVehicle";
            dtVehicle.RowTemplate.Height = 25;
            dtVehicle.Size = new Size(1020, 303);
            dtVehicle.TabIndex = 20;
            dtVehicle.CellContentClick += dtVehicle_CellContentClick;
            // 
            // Vehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 601);
            Controls.Add(gbField);
            Controls.Add(tbSearch);
            Controls.Add(btnTambah);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(dtVehicle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vehicle";
            Text = "Vehicle";
            Load += Vehicle_Load;
            gbField.ResumeLayout(false);
            gbField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtVehicle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rFemale;
        private RadioButton rMale;
        private DateTimePicker dtDateOfBirth;
        private ComboBox cbVehicleType;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbNotes;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbLicensePlate;
        private Label label4;
        private GroupBox gbField;
        private Label label2;
        private TextBox tbSearch;
        private Button btnTambah;
        private Panel panel2;
        private Label label1;
        private DataGridView dtVehicle;
        private ComboBox cbMemberID;
        private Label label3;
        private Button btnSaveEdit;
    }
}