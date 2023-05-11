namespace Latihan1_DL.Menu
{
    partial class Employee
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
            label1 = new Label();
            panel2 = new Panel();
            dtEmployee = new DataGridView();
            button1 = new Button();
            tbSearch = new TextBox();
            gbField = new GroupBox();
            btnSaveEdit = new Button();
            rFemale = new RadioButton();
            rMale = new RadioButton();
            btnCancel = new Button();
            btnSave = new Button();
            dtDateOfBirth = new DateTimePicker();
            tbAddress = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            tbNumberPhone = new TextBox();
            label6 = new Label();
            tbComfirmPassword = new TextBox();
            label5 = new Label();
            tbPassword = new TextBox();
            label4 = new Label();
            tbEmail = new TextBox();
            label3 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtEmployee).BeginInit();
            gbField.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(468, 27);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "EMPLOYEE";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(422, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 1;
            panel2.Paint += panel1_Paint;
            // 
            // dtEmployee
            // 
            dtEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtEmployee.BackgroundColor = Color.FromArgb(224, 224, 224);
            dtEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtEmployee.Location = new Point(12, 128);
            dtEmployee.Name = "dtEmployee";
            dtEmployee.RowTemplate.Height = 25;
            dtEmployee.Size = new Size(1020, 263);
            dtEmployee.TabIndex = 2;
            dtEmployee.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(12, 94);
            button1.Name = "button1";
            button1.Size = new Size(99, 28);
            button1.TabIndex = 3;
            button1.Text = "Tambah Data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearch.Location = new Point(891, 98);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Cari Data";
            tbSearch.Size = new Size(141, 23);
            tbSearch.TabIndex = 4;
            // 
            // gbField
            // 
            gbField.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbField.Controls.Add(btnSaveEdit);
            gbField.Controls.Add(rFemale);
            gbField.Controls.Add(rMale);
            gbField.Controls.Add(btnCancel);
            gbField.Controls.Add(btnSave);
            gbField.Controls.Add(dtDateOfBirth);
            gbField.Controls.Add(tbAddress);
            gbField.Controls.Add(label7);
            gbField.Controls.Add(label9);
            gbField.Controls.Add(label8);
            gbField.Controls.Add(tbNumberPhone);
            gbField.Controls.Add(label6);
            gbField.Controls.Add(tbComfirmPassword);
            gbField.Controls.Add(label5);
            gbField.Controls.Add(tbPassword);
            gbField.Controls.Add(label4);
            gbField.Controls.Add(tbEmail);
            gbField.Controls.Add(label3);
            gbField.Controls.Add(tbName);
            gbField.Controls.Add(label2);
            gbField.Enabled = false;
            gbField.Location = new Point(12, 397);
            gbField.Name = "gbField";
            gbField.Size = new Size(1020, 192);
            gbField.TabIndex = 5;
            gbField.TabStop = false;
            gbField.Visible = false;
            gbField.Enter += groupBox1_Enter;
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveEdit.BackColor = Color.DarkGreen;
            btnSaveEdit.FlatAppearance.BorderSize = 0;
            btnSaveEdit.FlatStyle = FlatStyle.Flat;
            btnSaveEdit.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveEdit.ForeColor = SystemColors.ControlLightLight;
            btnSaveEdit.Location = new Point(915, 110);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new Size(99, 28);
            btnSaveEdit.TabIndex = 7;
            btnSaveEdit.Text = "Save";
            btnSaveEdit.UseVisualStyleBackColor = false;
            btnSaveEdit.Visible = false;
            btnSaveEdit.Click += btnSaveEdit_Click;
            // 
            // rFemale
            // 
            rFemale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            rFemale.AutoSize = true;
            rFemale.Location = new Point(527, 117);
            rFemale.Name = "rFemale";
            rFemale.Size = new Size(63, 19);
            rFemale.TabIndex = 6;
            rFemale.TabStop = true;
            rFemale.Text = "Female";
            rFemale.UseVisualStyleBackColor = true;
            // 
            // rMale
            // 
            rMale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            rMale.AutoSize = true;
            rMale.Location = new Point(391, 117);
            rMale.Name = "rMale";
            rMale.Size = new Size(51, 19);
            rMale.TabIndex = 5;
            rMale.TabStop = true;
            rMale.Text = "Male";
            rMale.UseVisualStyleBackColor = true;
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
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button3_Click;
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
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dtDateOfBirth
            // 
            dtDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtDateOfBirth.Location = new Point(391, 80);
            dtDateOfBirth.Name = "dtDateOfBirth";
            dtDateOfBirth.Size = new Size(200, 23);
            dtDateOfBirth.TabIndex = 4;
            // 
            // tbAddress
            // 
            tbAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbAddress.Location = new Point(391, 22);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.ScrollBars = ScrollBars.Vertical;
            tbAddress.Size = new Size(199, 52);
            tbAddress.TabIndex = 3;
            tbAddress.TextChanged += textBox7_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(312, 25);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 2;
            label7.Text = "Address";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(307, 117);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 0;
            label9.Text = "Gender";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(307, 86);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 0;
            label8.Text = "Date Of Birth";
            // 
            // tbNumberPhone
            // 
            tbNumberPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbNumberPhone.Location = new Point(123, 138);
            tbNumberPhone.Name = "tbNumberPhone";
            tbNumberPhone.Size = new Size(173, 23);
            tbNumberPhone.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(13, 141);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 0;
            label6.Text = "Number Phone";
            // 
            // tbComfirmPassword
            // 
            tbComfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbComfirmPassword.Location = new Point(123, 109);
            tbComfirmPassword.Name = "tbComfirmPassword";
            tbComfirmPassword.Size = new Size(173, 23);
            tbComfirmPassword.TabIndex = 1;
            tbComfirmPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(13, 112);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 0;
            label5.Text = "Confirm Password";
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbPassword.Location = new Point(123, 80);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(173, 23);
            tbPassword.TabIndex = 1;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(13, 83);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbEmail.Location = new Point(123, 51);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(173, 23);
            tbEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(13, 59);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbName.Location = new Point(123, 22);
            tbName.Name = "tbName";
            tbName.Size = new Size(173, 23);
            tbName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(13, 30);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 601);
            Controls.Add(gbField);
            Controls.Add(tbSearch);
            Controls.Add(button1);
            Controls.Add(dtEmployee);
            Controls.Add(panel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)dtEmployee).EndInit();
            gbField.ResumeLayout(false);
            gbField.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private DataGridView dtEmployee;
        private Button button1;
        private TextBox tbSearch;
        private GroupBox gbField;
        private TextBox tbComfirmPassword;
        private Label label5;
        private TextBox tbPassword;
        private Label label4;
        private TextBox tbEmail;
        private Label label3;
        private TextBox tbName;
        private Label label2;
        private TextBox tbAddress;
        private Label label7;
        private TextBox tbNumberPhone;
        private Label label6;
        private RadioButton rFemale;
        private RadioButton rMale;
        private Button btnCancel;
        private Button btnSave;
        private DateTimePicker dtDateOfBirth;
        private Label label9;
        private Label label8;
        private Button btnSaveEdit;
    }
}