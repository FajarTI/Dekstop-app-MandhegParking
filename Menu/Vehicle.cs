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
    public partial class Vehicle : Form
    {

        int id, member_id, vehicle_type_id;
        string license_plate, notes;

        public Vehicle()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            gbField.Enabled = true;
            gbField.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbField.Enabled = false;
            gbField.Visible = false;
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData("vehicle");

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            edit.HeaderText = "Edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.HeaderText = "Delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;

            FillComboBox();

            dtVehicle.DataSource = dt;
            dtVehicle.Columns.Add(edit);
            dtVehicle.Columns.Add(delete);
            dtVehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtVehicle.AllowUserToAddRows = false;
        }

        private void FillComboBox()
        {
            DataTable dt = DBHelper.GetData("vehicletype");
            if (dt != null)
            {
                cbVehicleType.DataSource = dt;
                cbVehicleType.DisplayMember = "name";
                cbVehicleType.ValueMember = "id";
            }

            DataTable td = DBHelper.GetData("member");
            if (td != null)
            {
                cbMemberID.DataSource = td;
                cbMemberID.DisplayMember = "name";
                cbMemberID.ValueMember = "id";
            }

        }

        private void dtVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSaveEdit.Enabled = true;
            btnSaveEdit.Visible = true;

            id = (int)dtVehicle.Rows[e.RowIndex].Cells["id"].Value;

            if (dtVehicle.Columns[e.ColumnIndex] is DataGridViewColumn && dtVehicle.Columns[e.ColumnIndex].HeaderText == "Edit" && e.ColumnIndex >= 0)
            {
                gbField.Enabled = true;
                gbField.Visible = true;

                cbMemberID.SelectedValue = dtVehicle.Rows[e.RowIndex].Cells["member_id"].Value.ToString();
                cbVehicleType.SelectedValue = dtVehicle.Rows[e.RowIndex].Cells["vehicle_type_id"].Value.ToString();
                tbLicensePlate.Text = dtVehicle.Rows[e.RowIndex].Cells["license_plate"].Value.ToString();
                tbNotes.Text = dtVehicle.Rows[e.RowIndex].Cells["notes"].Value.ToString();
            }
            else if (dtVehicle.Columns[e.ColumnIndex] is DataGridViewColumn && dtVehicle.Columns[e.ColumnIndex].HeaderText == "Delete" && e.ColumnIndex >= 0)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("deleted_at", DateTime.Now);

                int result = DBHelper.Update("vehicle", data, "id = " + id);
                if (result > 0)
                {
                    MessageBox.Show("Success to Delete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPane();
                }
                else
                {
                    MessageBox.Show("Failed to Delete!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void RefreshPane()
        {
            DataTable dt = DBHelper.GetData("vehicle");
            dtVehicle.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            member_id = (int)cbMemberID.SelectedValue;
            vehicle_type_id = (int)cbVehicleType.SelectedValue;
            license_plate = tbLicensePlate.Text;
            notes = tbNotes.Text;

            if (license_plate == string.Empty)
            {
                MessageBox.Show("Silahkan Masukan Plat Nomer!");
                return;
            }

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("member_id", member_id);
            data.Add("vehicle_type_id", vehicle_type_id);
            data.Add("license_plate", license_plate);
            data.Add("notes", notes);

            int result = DBHelper.Insert("vehicle", data);
            if (result > 0)
            {
                MessageBox.Show("Success to Insert!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshPane();
            }
            else
            {
                MessageBox.Show("Failed to Insert!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            member_id = (int)cbMemberID.SelectedValue;
            vehicle_type_id = (int)cbVehicleType.SelectedValue;
            license_plate = tbLicensePlate.Text;
            notes = tbNotes.Text;

            if (license_plate == string.Empty)
            {
                MessageBox.Show("Silahkan Masukan Plat Nomer!");
                return;
            }

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("member_id", member_id);
            data.Add("vehicle_type_id", vehicle_type_id);
            data.Add("license_plate", license_plate);
            data.Add("notes", notes);
            data.Add("last_updated_at", DateTime.Now);

            int result = DBHelper.Update("vehicle", data, "id = " + id);
            if (result > 0)
            {
                MessageBox.Show("Success to Update!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshPane();
            }
            else
            {
                MessageBox.Show("Failed to Update!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
