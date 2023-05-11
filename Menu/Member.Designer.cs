namespace Latihan1_DL.Menu
{
    partial class Member
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
            dtMember = new DataGridView();
            label2 = new Label();
            gbField = new GroupBox();
            btnSaveEdit = new Button();
            rFemale = new RadioButton();
            rMale = new RadioButton();
            dtDateOfBirth = new DateTimePicker();
            cbMembership = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            tbPhoneNumber = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tbEmail = new TextBox();
            label4 = new Label();
            tbName = new TextBox();
            label3 = new Label();
            tbSearch = new TextBox();
            btnTambah = new Button();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtMember).BeginInit();
            gbField.SuspendLayout();
            SuspendLayout();
            // 
            // dtMember
            // 
            dtMember.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtMember.BackgroundColor = Color.FromArgb(224, 224, 224);
            dtMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtMember.Location = new Point(12, 100);
            dtMember.Name = "dtMember";
            dtMember.RowTemplate.Height = 25;
            dtMember.Size = new Size(1020, 303);
            dtMember.TabIndex = 14;
            dtMember.CellContentClick += dtMember_CellContentClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(13, 30);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 0;
            label2.Text = "Membership ID";
            // 
            // gbField
            // 
            gbField.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbField.Controls.Add(btnSaveEdit);
            gbField.Controls.Add(rFemale);
            gbField.Controls.Add(rMale);
            gbField.Controls.Add(dtDateOfBirth);
            gbField.Controls.Add(cbMembership);
            gbField.Controls.Add(btnCancel);
            gbField.Controls.Add(btnSave);
            gbField.Controls.Add(tbPhoneNumber);
            gbField.Controls.Add(label7);
            gbField.Controls.Add(label6);
            gbField.Controls.Add(label5);
            gbField.Controls.Add(tbEmail);
            gbField.Controls.Add(label4);
            gbField.Controls.Add(tbName);
            gbField.Controls.Add(label3);
            gbField.Controls.Add(label2);
            gbField.Enabled = false;
            gbField.Location = new Point(12, 409);
            gbField.Name = "gbField";
            gbField.Size = new Size(1020, 180);
            gbField.TabIndex = 17;
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
            btnSaveEdit.Location = new Point(915, 104);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new Size(99, 28);
            btnSaveEdit.TabIndex = 12;
            btnSaveEdit.Text = "Save";
            btnSaveEdit.UseVisualStyleBackColor = false;
            btnSaveEdit.Visible = false;
            btnSaveEdit.Click += btnSaveEdit_Click;
            // 
            // rFemale
            // 
            rFemale.AutoSize = true;
            rFemale.Location = new Point(547, 59);
            rFemale.Name = "rFemale";
            rFemale.Size = new Size(63, 19);
            rFemale.TabIndex = 11;
            rFemale.TabStop = true;
            rFemale.Text = "Female";
            rFemale.UseVisualStyleBackColor = true;
            // 
            // rMale
            // 
            rMale.AutoSize = true;
            rMale.Location = new Point(430, 59);
            rMale.Name = "rMale";
            rMale.Size = new Size(51, 19);
            rMale.TabIndex = 11;
            rMale.TabStop = true;
            rMale.Text = "Male";
            rMale.UseVisualStyleBackColor = true;
            // 
            // dtDateOfBirth
            // 
            dtDateOfBirth.Location = new Point(430, 24);
            dtDateOfBirth.Name = "dtDateOfBirth";
            dtDateOfBirth.Size = new Size(180, 23);
            dtDateOfBirth.TabIndex = 10;
            // 
            // cbMembership
            // 
            cbMembership.FormattingEnabled = true;
            cbMembership.Location = new Point(123, 22);
            cbMembership.Name = "cbMembership";
            cbMembership.Size = new Size(173, 23);
            cbMembership.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Maroon;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ControlLightLight;
            btnCancel.Location = new Point(915, 143);
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
            btnSave.Location = new Point(915, 105);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 28);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbPhoneNumber.Location = new Point(123, 109);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(173, 23);
            tbPhoneNumber.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(326, 59);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 0;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(326, 30);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 0;
            label6.Text = "Date Of Birth";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(13, 117);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 0;
            label5.Text = "Phone Number";
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbEmail.Location = new Point(123, 80);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(173, 23);
            tbEmail.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(13, 88);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 0;
            label4.Text = "Email";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbName.Location = new Point(123, 51);
            tbName.Name = "tbName";
            tbName.Size = new Size(173, 23);
            tbName.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(13, 59);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Name";
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearch.Location = new Point(891, 71);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Cari Data";
            tbSearch.Size = new Size(141, 23);
            tbSearch.TabIndex = 16;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.DarkGreen;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTambah.ForeColor = SystemColors.ControlLightLight;
            btnTambah.Location = new Point(12, 66);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(99, 28);
            btnTambah.TabIndex = 15;
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
            panel2.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(476, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 12;
            label1.Text = "MEMBER";
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 601);
            Controls.Add(dtMember);
            Controls.Add(gbField);
            Controls.Add(tbSearch);
            Controls.Add(btnTambah);
            Controls.Add(panel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Member";
            Text = "Member";
            Load += Member_Load;
            ((System.ComponentModel.ISupportInitialize)dtMember).EndInit();
            gbField.ResumeLayout(false);
            gbField.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtMember;
        private Label label2;
        private GroupBox gbField;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbSearch;
        private Button btnTambah;
        private Panel panel2;
        private Label label1;
        private RadioButton rFemale;
        private RadioButton rMale;
        private DateTimePicker dtDateOfBirth;
        private ComboBox cbMembership;
        private TextBox tbPhoneNumber;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbEmail;
        private Label label4;
        private TextBox tbName;
        private Label label3;
        private Button btnSaveEdit;
    }
}