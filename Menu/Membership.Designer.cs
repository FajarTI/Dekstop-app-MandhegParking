namespace Latihan1_DL.Menu
{
    partial class Membership
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
            tbName = new TextBox();
            label2 = new Label();
            gbField = new GroupBox();
            btnCancel = new Button();
            btnSaveEdit = new Button();
            btnSave = new Button();
            tbSearch = new TextBox();
            btnTambah = new Button();
            dtMembership = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            gbField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtMembership).BeginInit();
            SuspendLayout();
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
            // gbField
            // 
            gbField.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbField.Controls.Add(btnCancel);
            gbField.Controls.Add(btnSaveEdit);
            gbField.Controls.Add(btnSave);
            gbField.Controls.Add(tbName);
            gbField.Controls.Add(label2);
            gbField.Enabled = false;
            gbField.Location = new Point(12, 389);
            gbField.Name = "gbField";
            gbField.Size = new Size(1020, 192);
            gbField.TabIndex = 11;
            gbField.TabStop = false;
            gbField.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Maroon;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ControlLightLight;
            btnCancel.Location = new Point(915, 151);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 28);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button4_Click;
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveEdit.BackColor = Color.DarkGreen;
            btnSaveEdit.FlatAppearance.BorderSize = 0;
            btnSaveEdit.FlatStyle = FlatStyle.Flat;
            btnSaveEdit.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveEdit.ForeColor = SystemColors.ControlLightLight;
            btnSaveEdit.Location = new Point(915, 117);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new Size(99, 28);
            btnSaveEdit.TabIndex = 8;
            btnSaveEdit.Text = "Save";
            btnSaveEdit.UseVisualStyleBackColor = false;
            btnSaveEdit.Visible = false;
            btnSaveEdit.Click += btnSaveEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.DarkGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(915, 117);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 28);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearch.Location = new Point(891, 90);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Cari Data";
            tbSearch.Size = new Size(141, 23);
            tbSearch.TabIndex = 10;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.DarkGreen;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTambah.ForeColor = SystemColors.ControlLightLight;
            btnTambah.Location = new Point(12, 86);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(99, 28);
            btnTambah.TabIndex = 9;
            btnTambah.Text = "Tambah Data";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += button1_Click;
            // 
            // dtMembership
            // 
            dtMembership.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtMembership.BackgroundColor = Color.FromArgb(224, 224, 224);
            dtMembership.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtMembership.Location = new Point(12, 120);
            dtMembership.Name = "dtMembership";
            dtMembership.RowTemplate.Height = 25;
            dtMembership.Size = new Size(1020, 263);
            dtMembership.TabIndex = 8;
            dtMembership.CellContentClick += dtMembership_CellContentClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(422, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(454, 19);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 6;
            label1.Text = "MEMBERSHIP";
            label1.Click += label1_Click;
            // 
            // Membership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 601);
            Controls.Add(gbField);
            Controls.Add(tbSearch);
            Controls.Add(btnTambah);
            Controls.Add(dtMembership);
            Controls.Add(panel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Membership";
            Text = "Membership";
            Load += Membership_Load;
            gbField.ResumeLayout(false);
            gbField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtMembership).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbName;
        private Label label2;
        private GroupBox gbField;
        private TextBox tbSearch;
        private Button btnTambah;
        private DataGridView dtMembership;
        private Panel panel2;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private Button btnSaveEdit;
    }
}