using System.Data;
using System.Xml.Linq;

namespace Latihan1_DL.Menu
{
    public partial class HourlyRates : Form
    {
        public HourlyRates()
        {
            InitializeComponent();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void HourlyRates_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData("hourlyrates");

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            edit.HeaderText = "Edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.HeaderText = "Delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;

            FillComboBox();

            dtHourlyRates.DataSource = dt;
            dtHourlyRates.Columns.Add(edit);
            dtHourlyRates.Columns.Add(delete);
            dtHourlyRates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtHourlyRates.AllowUserToAddRows = false;
        }
        public int id;
        private void dtHourlyRates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSaveEdit.Enabled = true;
            btnSaveEdit.Visible = true;

            id = (int)dtHourlyRates.Rows[e.RowIndex].Cells["id"].Value;

            //Edit
            if (dtHourlyRates.Columns[e.ColumnIndex] is DataGridViewColumn && dtHourlyRates.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex >= 0)
            {
                gbField.Enabled = true;
                gbField.Visible = true;

                tbValue.Text = dtHourlyRates.Rows[e.RowIndex].Cells["value"].Value.ToString();
                cbMembershipID.SelectedValue = dtHourlyRates.Rows[e.RowIndex].Cells["membership_id"].Value.ToString();
                cbVehicleTypeID.SelectedValue = dtHourlyRates.Rows[e.RowIndex].Cells["vehicle_type_id"].Value.ToString();
            }
            //Delete
            if (dtHourlyRates.Columns[e.ColumnIndex] is DataGridViewColumn && dtHourlyRates.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex >= 0)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("deleted_at", DateTime.Now);

                int result = DBHelper.Update("hourlyrates", data, "id = " + id);
                if (result != 0)
                {
                    MessageBox.Show("Success to Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataTable();
                }
                else
                    MessageBox.Show("Failed to Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FillComboBox()
        {
            string tableMembership = "membership";
            string tableVehicleType = "vehicletype";

            DataTable dtMembership = DBHelper.GetData(tableMembership);
            if (dtMembership != null)
            {
                cbMembershipID.DataSource = dtMembership;
                cbMembershipID.ValueMember = "id";
                cbMembershipID.DisplayMember = "name";
            }
            DataTable dtVehicletype = DBHelper.GetData(tableVehicleType);
            if (dtMembership != null)
            {
                cbVehicleTypeID.DataSource = dtVehicletype;
                cbVehicleTypeID.ValueMember = "id";
                cbVehicleTypeID.DisplayMember = "name";
            }
        }
        private void RefreshDataTable()
        {
            DataTable dt = DBHelper.GetData("hourlyrates");
            dtHourlyRates.DataSource = dt;
            dtHourlyRates.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int membershipID = (int)cbMembershipID.SelectedValue;
            int vehicleTypeID = (int)cbVehicleTypeID.SelectedValue;
            string value = tbValue.Text;

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("value", value);
            data.Add("membership_id", membershipID);
            data.Add("vehicle_type_id", vehicleTypeID);

            int result = DBHelper.Insert("hourlyrates", data);
            if (result != 0)
            {
                MessageBox.Show("Success to Add!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataTable();
            }
            else
                MessageBox.Show("Failed to Add!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            int membershipID = (int)cbMembershipID.SelectedValue;
            int vehicleTypeID = (int)cbVehicleTypeID.SelectedValue;
            string value = tbValue.Text;

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("value", value);
            data.Add("membership_id", membershipID);
            data.Add("vehicle_type_id", vehicleTypeID);
            data.Add("last_updated_at", DateTime.Now);

            int result = DBHelper.Update("hourlyrates", data, "id = " + id); ;
            if (result != 0)
            {
                MessageBox.Show("Success to Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataTable();
            }
            else
                MessageBox.Show("Failed to Updated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
