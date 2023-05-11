namespace Latihan1_DL.Menu
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tbUsername = new TextBox();
            pictureBox3 = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            tbPassword = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            button1 = new Button();
            button3 = new Button();
            lblError1 = new Label();
            lblError2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 BlkCn BT", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(104, 171);
            label1.Name = "label1";
            label1.Size = new Size(74, 26);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.parking_lot;
            pictureBox1.Location = new Point(82, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(41, 217);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(41, 252);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 1);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.None;
            tbUsername.BackColor = Color.FromArgb(51, 51, 76);
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Cursor = Cursors.IBeam;
            tbUsername.Font = new Font("Square721 Cn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.ForeColor = Color.White;
            tbUsername.Location = new Point(73, 226);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Email";
            tbUsername.ShortcutsEnabled = false;
            tbUsername.Size = new Size(161, 23);
            tbUsername.TabIndex = 5;
            tbUsername.TabStop = false;
            tbUsername.WordWrap = false;
            tbUsername.MouseClick += tbUsername_MouseClick;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.unlock;
            pictureBox3.Location = new Point(41, 275);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Location = new Point(41, 310);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(200, 1);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.None;
            tbPassword.BackColor = Color.FromArgb(51, 51, 76);
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Cursor = Cursors.IBeam;
            tbPassword.Font = new Font("Square721 Cn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.ForeColor = Color.White;
            tbPassword.Location = new Point(73, 284);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Password";
            tbPassword.ShortcutsEnabled = false;
            tbPassword.Size = new Size(161, 23);
            tbPassword.TabIndex = 5;
            tbPassword.TabStop = false;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.WordWrap = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 150, 136);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Humnst777 BlkCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(41, 351);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 33);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(104, 387);
            label2.Name = "label2";
            label2.Size = new Size(72, 13);
            label2.TabIndex = 7;
            label2.Text = "Lupa Sandi?";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(259, 2);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 8;
            button1.Text = "O";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Yellow;
            button3.Location = new Point(236, 2);
            button3.Name = "button3";
            button3.Size = new Size(25, 23);
            button3.TabIndex = 9;
            button3.Text = "O";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblError1
            // 
            lblError1.AutoSize = true;
            lblError1.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblError1.ForeColor = Color.Red;
            lblError1.Location = new Point(41, 256);
            lblError1.Name = "lblError1";
            lblError1.Size = new Size(119, 13);
            lblError1.TabIndex = 10;
            lblError1.Text = "*Bagian Ini Wajib Diisi!";
            lblError1.Visible = false;
            // 
            // lblError2
            // 
            lblError2.AutoSize = true;
            lblError2.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblError2.ForeColor = Color.Red;
            lblError2.Location = new Point(41, 314);
            lblError2.Name = "lblError2";
            lblError2.Size = new Size(119, 13);
            lblError2.TabIndex = 11;
            lblError2.Text = "*Bagian Ini Wajib Diisi!";
            lblError2.Visible = false;
            lblError2.Click += label4_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(284, 421);
            Controls.Add(lblError2);
            Controls.Add(lblError1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(tbUsername);
            Controls.Add(pictureBox3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox tbUsername;
        private PictureBox pictureBox3;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox tbPassword;
        private Button btnLogin;
        private Label label2;
        private Button button1;
        private Button button3;
        private Label lblError1;
        private Label lblError2;
    }
}