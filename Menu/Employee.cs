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
    public partial class Employee : Form
    {
        string gender;
        string name;
        string email;
        string password;
        string hashPass;
        string numberPhone;
        string address;
        DateTime dateOfBirth;
        public int id;
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData("employee");

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            edit.HeaderText = "Edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.HeaderText = "Delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;


            dtEmployee.DataSource = dt;
            dtEmployee.Columns.Add(edit);
            dtEmployee.Columns.Add(delete);
            dtEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtEmployee.AllowUserToAddRows = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbField.Enabled = true;
            gbField.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbField.Enabled = false;
            gbField.Visible = false;
            label4.Text = "Password";
        }

        /*
         Rows = Baris
         Cells = Sel
         Columns = Kolom
         */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSaveEdit.Enabled = true;
            btnSaveEdit.Visible = true;

            id = (int)dtEmployee.Rows[e.RowIndex].Cells["id"].Value;

            //Edit
            if (dtEmployee.Columns[e.ColumnIndex] is DataGridViewColumn && dtEmployee.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex >= 0)
            {
                gbField.Enabled = true;
                gbField.Visible = true;
                label4.Text = "New Password";

                tbName.Text = dtEmployee.Rows[e.RowIndex].Cells["name"].Value.ToString();
                tbEmail.Text = dtEmployee.Rows[e.RowIndex].Cells["email"].Value.ToString();
                tbAddress.Text = dtEmployee.Rows[e.RowIndex].Cells["address"].Value.ToString();
                tbNumberPhone.Text = dtEmployee.Rows[e.RowIndex].Cells["phone_number"].Value.ToString();
                dtDateOfBirth.Value = DateTime.Parse(dtEmployee.Rows[e.RowIndex].Cells["date_of_birth"].Value.ToString());
                gender = dtEmployee.Rows[e.RowIndex].Cells["gender"].Value.ToString();

                if (gender.Equals("Male"))
                {
                    rMale.Checked = true;
                }
                else if (gender.Equals("Female"))
                {
                    rFemale.Checked = true;
                }
            }
            //Delete
            if (dtEmployee.Columns[e.ColumnIndex] is DataGridViewColumn && dtEmployee.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex >= 0)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("deleted_at", DateTime.Now);

                int result = DBHelper.Update("employee", data, "id = " + id);
                if (result != 0)
                {
                    MessageBox.Show("Success to Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataTable();
                }
                else
                    MessageBox.Show("Failed to Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            name = tbName.Text;
            email = tbEmail.Text;
            password = tbPassword.Text;
            hashPass = GetSHA256(password);
            numberPhone = tbNumberPhone.Text;
            address = tbAddress.Text;
            dateOfBirth = dtDateOfBirth.Value.Date;

            // VALIDATION 
            if (rMale.Checked)
                gender = "Male";
            else if (rFemale.Checked)
                gender = "Female";

            if (name == string.Empty && email == string.Empty && password == string.Empty && numberPhone == string.Empty && address == string.Empty)
            {
                MessageBox.Show("Silahkan Isi Fields Telebih Dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (password.Length < 6)
            {
                MessageBox.Show("Password Minimal 6 Karakter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (!password.Equals(tbComfirmPassword.Text))
            {
                MessageBox.Show("Perhatikan Password Dengan Benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            else if (rMale.Checked || rFemale.Checked)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("name", name);
                data.Add("email", email);
                data.Add("password", hashPass);
                data.Add("phone_number", numberPhone);
                data.Add("address", address);
                data.Add("gender", gender);
                data.Add("date_of_birth", dateOfBirth);

                int result = DBHelper.Insert("employee", data);
                if (result != 0)
                {
                    MessageBox.Show("Success to Add!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataTable();
                }
                else
                    MessageBox.Show("Failed to Add!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Silahkan Pilih Jenis Kelamin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void RefreshDataTable()
        {
            DataTable dt = DBHelper.GetData("employee");
            dtEmployee.DataSource = dt;
            dtEmployee.Refresh();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            name = tbName.Text;
            email = tbEmail.Text;
            password = tbPassword.Text;
            hashPass = GetSHA256(password);
            numberPhone = tbNumberPhone.Text;
            address = tbAddress.Text;
            dateOfBirth = dtDateOfBirth.Value.Date;

            // VALIDATION 
            if (rMale.Checked)
                gender = "Male";
            else if (rFemale.Checked)
                gender = "Female";

            if (name == string.Empty && email == string.Empty && password == string.Empty && numberPhone == string.Empty && address == string.Empty)
            {
                MessageBox.Show("Silahkan Isi Fields Telebih Dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (rMale.Checked || rFemale.Checked)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("name", name);
                data.Add("email", email);
                data.Add("phone_number", numberPhone);
                data.Add("address", address);
                data.Add("gender", gender);
                data.Add("date_of_birth", dateOfBirth);
                data.Add("last_updated_at", DateTime.Now);

                if (!string.IsNullOrEmpty(password))
                {
                    data.Add("password", GetSHA256(password));
                }

                int result = DBHelper.Update("employee", data, "id = " + id);
                if (result != 0)
                {
                    MessageBox.Show("Success to Update!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataTable();
                }
                else
                    MessageBox.Show("Failed to Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Silahkan Pilih Jenis Kelamin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
