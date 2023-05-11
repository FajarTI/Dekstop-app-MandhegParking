using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1_DL.Menu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!", "New", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == string.Empty && tbPassword.Text == string.Empty)
            {
                lblError1.Visible = true;

                lblError2.Text = "*Bagian Ini Wajib Diisi!";
                lblError2.Visible = true;
                return;
            }

            string username = tbUsername.Text;
            string plainPassword = tbPassword.Text;
            string hashPassword = GetSHA256(plainPassword);

            DataTable dt = DBHelper.Login("employee", username, hashPassword);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Form1 desktopPane = new Form1();
                desktopPane.Show();
            }
            else
            {
                lblError2.Text = "Email atau Password Salah!";
                lblError2.Visible = true;
                lblError1.Visible = false;
            }
        }
        private string GetSHA256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
