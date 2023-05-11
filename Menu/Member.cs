using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1_DL.Menu
{
    public partial class Member : Form
    {
        string name;
        string email;
        string phone_number;
        DateTime date_of_birth;
        string gender;
        int id;

        public Member()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            gbField.Visible = true;
            gbField.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbField.Visible = false;
            gbField.Enabled = false;
            btnSaveEdit.Visible = false;
        }

        private void Member_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData("member");

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            edit.HeaderText = "Edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.HeaderText = "Delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;

            FillComboBox();

            dtMember.DataSource = dt;
            dtMember.Columns.Add(edit);
            dtMember.Columns.Add(delete);
            dtMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtMember.AllowUserToAddRows = false;
        }

        private void FillComboBox()
        {
            string tableMember = "membership";
            DataTable dataTable = DBHelper.GetData(tableMember);

            if (dataTable != null)
            {
                cbMembership.DataSource = dataTable;
                cbMembership.ValueMember = "id";
                cbMembership.DisplayMember = "name";
            }
        }

        private void RefreshDataTable()
        {
            DataTable dt = DBHelper.GetData("member");
            dtMember.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            name = tbName.Text;
            email = tbEmail.Text;
            phone_number = tbPhoneNumber.Text;
            date_of_birth = dtDateOfBirth.Value.Date;
            int membershipId = (int)cbMembership.SelectedValue;

            // VALIDATION 
            if (rMale.Checked)
                gender = "Male";
            else if (rFemale.Checked)
                gender = "Female";

            if (name == string.Empty || email == string.Empty || phone_number == string.Empty)
            {
                MessageBox.Show("Silahkan Lengkapi Feilds!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rMale.Checked || rFemale.Checked)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();

                data.Add("membership_id", membershipId);
                data.Add("name", name);
                data.Add("email", email);
                data.Add("phone_number", phone_number);
                data.Add("gender", gender);
                data.Add("date_of_birth", date_of_birth);

                int result = DBHelper.Insert("member", data);
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

        private void dtMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSaveEdit.Enabled = true;
            btnSaveEdit.Visible = true;

            id = (int)dtMember.Rows[e.RowIndex].Cells["id"].Value;

            //Edit
            if (dtMember.Columns[e.ColumnIndex] is DataGridViewColumn && dtMember.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex >= 0)
            {
                gbField.Enabled = true;
                gbField.Visible = true;

                cbMembership.SelectedValue = dtMember.Rows[e.RowIndex].Cells["membership_id"].Value.ToString();
                tbName.Text = dtMember.Rows[e.RowIndex].Cells["name"].Value.ToString();
                tbEmail.Text = dtMember.Rows[e.RowIndex].Cells["email"].Value.ToString();
                tbPhoneNumber.Text = dtMember.Rows[e.RowIndex].Cells["phone_number"].Value.ToString();
                dtDateOfBirth.Value = DateTime.Parse(dtMember.Rows[e.RowIndex].Cells["date_of_birth"].Value.ToString());
                gender = dtMember.Rows[e.RowIndex].Cells["gender"].Value.ToString();

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
            if (dtMember.Columns[e.ColumnIndex] is DataGridViewColumn && dtMember.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex >= 0)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("deleted_at", DateTime.Now);

                int result = DBHelper.Update("member", data, "id = " + id);
                if (result != 0)
                {
                    MessageBox.Show("Success to Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataTable();
                }
                else
                    MessageBox.Show("Failed to Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            name = tbName.Text;
            email = tbEmail.Text;
            phone_number = tbPhoneNumber.Text;
            date_of_birth = dtDateOfBirth.Value.Date;
            int membershipId = (int)cbMembership.SelectedValue;

            // VALIDATION 
            if (rMale.Checked)
                gender = "Male";
            else if (rFemale.Checked)
                gender = "Female";

            if (name == string.Empty || email == string.Empty || phone_number == string.Empty)
            {
                MessageBox.Show("Silahkan Lengkapi Feilds!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rMale.Checked || rFemale.Checked)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();

                data.Add("membership_id", membershipId);
                data.Add("name", name);
                data.Add("email", email);
                data.Add("phone_number", phone_number);
                data.Add("gender", gender);
                data.Add("date_of_birth", date_of_birth);

                int result = DBHelper.Update("member", data,"id = " + id);
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
    }
}
