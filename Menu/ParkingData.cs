using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1_DL.Menu
{
    public partial class ParkingData : Form
    {
        int id;
        public ParkingData()
        {
            InitializeComponent();
        }

        private void gbField_Enter(object sender, EventArgs e)
        {

        }

        private void FillComboBox()
        {
            DataTable dt;

            dt = DBHelper.GetData("vehicle");
            if (dt != null)
            {
                cbVehicleID.DataSource = dt;
                cbVehicleID.ValueMember = "id";
                cbVehicleID.DisplayMember = "id";

                cbLicense.DataSource = dt;
                cbLicense.DisplayMember = "license_plate";
                cbLicense.ValueMember = "license_plate";

            }

            dt = DBHelper.GetData("employee");
            if (dt != null)
            {
                cbEmployeeID.DataSource = dt;
                cbEmployeeID.ValueMember = "id";
                cbEmployeeID.DisplayMember = "name";
            }

            dt = DBHelper.GetData("hourlyrates");
            if (dt != null)
            {
                cbHourlyRatesID.DataSource = dt;
                cbHourlyRatesID.ValueMember = "id";
                cbHourlyRatesID.DisplayMember = "value";
            }
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
            btnSaveEdit.Visible = false;
            btnSaveEdit.Enabled = false;
        }

        private void ParkingData_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData("parkingdata");

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            edit.HeaderText = "Edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.HeaderText = "Delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;

            FillComboBox();

            dtParkingData.DataSource = dt;
            dtParkingData.Columns.Add(edit);
            dtParkingData.Columns.Add(delete);
            dtParkingData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtParkingData.AllowUserToAddRows = false;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            DateTime dateIn = dtTimeIn.Value;
            DateTime dateOut = dtTimeOut.Value;

            TimeSpan duration = dateOut - dateIn;
            double totalHours = duration.TotalHours;

            //Format lblAmount
            string strPrice = cbHourlyRatesID.Text;
            string strPriceR = strPrice.Replace(",", "");
            int commaIndex = strPrice.IndexOf(",");
            if (commaIndex != -1)
            {
                strPriceR = strPriceR.Substring(0, commaIndex);
            }

            //Count Price
            int price = Convert.ToInt32(strPriceR);
            double total = totalHours * price;
            int amount = (int)total;

            lblAmount.Text = "Rp. " + amount.ToString();

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void RefreshPane()
        {
            DataTable dt = DBHelper.GetData("parkingdata");
            dtParkingData.DataSource = dt;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            var license_plate = cbLicense.SelectedValue.ToString();
            int vehicle_id = (int)cbVehicleID.SelectedValue;
            int employee_id = (int)cbEmployeeID.SelectedValue;
            int hourlyrates_id = (int)cbHourlyRatesID.SelectedValue;

            DateTime timeIn = dtTimeIn.Value;
            DateTime timeOut = dtTimeOut.Value;

            string amount = lblAmount.Text;
            string strAmount = amount.Replace("Rp. ", "");

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("license_plate", license_plate);
            data.Add("vehicle_id", vehicle_id);
            data.Add("employee_id", employee_id);
            data.Add("hourly_rates_id", hourlyrates_id);
            data.Add("datetime_in", timeIn);
            data.Add("datetime_out", timeOut);
            data.Add("amount_to_pay", strAmount);
            data.Add("last_updated_at", DateTime.Now);

            int result = DBHelper.Update("parkingdata", data, "id = " + id);
            if (result > 0)
            {
                MessageBox.Show("Success to updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshPane();
            }
            else
            {
                MessageBox.Show("failed to updated", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var license_plate = cbLicense.SelectedValue.ToString();
            int vehicle_id = (int)cbVehicleID.SelectedValue;
            int employee_id = (int)cbEmployeeID.SelectedValue;
            int hourlyrates_id = (int)cbHourlyRatesID.SelectedValue;

            DateTime timeIn = dtTimeIn.Value;
            DateTime timeOut = dtTimeOut.Value;

            string amount = lblAmount.Text;
            string strAmount = amount.Replace("Rp. ", "");

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("license_plate", license_plate);
            data.Add("vehicle_id", vehicle_id);
            data.Add("employee_id", employee_id);
            data.Add("hourly_rates_id", hourlyrates_id);
            data.Add("datetime_in", timeIn);
            data.Add("datetime_out", timeOut);
            data.Add("amount_to_pay", strAmount);

            int result = DBHelper.Insert("parkingdata", data);
            if (result > 0)
            {
                MessageBox.Show("Success to Insert", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshPane();
            }
            else
            {
                MessageBox.Show("failed to Insert", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dtParkingData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gbField.Enabled = true;
            gbField.Visible = true;

            id = (int)dtParkingData.Rows[e.RowIndex].Cells["id"].Value;

            if (dtParkingData.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dtParkingData.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex >= 0)
            {
                btnSaveEdit.Visible = true;
                btnSaveEdit.Enabled = true;

                string price = dtParkingData.Rows[e.RowIndex].Cells["amount_to_pay"].Value.ToString();
                string strPrice = price.Replace(",", "");
                int commaIndex = price.IndexOf(",");
                if (commaIndex != -1)
                {
                    strPrice = strPrice.Substring(0, commaIndex);
                }

                cbLicense.SelectedValue = dtParkingData.Rows[e.RowIndex].Cells["license_plate"].Value;
                cbHourlyRatesID.SelectedValue = dtParkingData.Rows[e.RowIndex].Cells["hourly_rates_id"].Value;
                cbEmployeeID.SelectedValue = dtParkingData.Rows[e.RowIndex].Cells["employee_id"].Value;
                cbVehicleID.SelectedValue = dtParkingData.Rows[e.RowIndex].Cells["vehicle_id"].Value;
                dtTimeIn.Value = DateTime.Parse(dtParkingData.Rows[e.RowIndex].Cells["datetime_in"].Value.ToString());
                dtTimeOut.Value = DateTime.Parse(dtParkingData.Rows[e.RowIndex].Cells["datetime_out"].Value.ToString());
                lblAmount.Text = "Rp. " + strPrice;

            }

            if (dtParkingData.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dtParkingData.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex >= 0)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("deleted_at", DateTime.Now);

                int result = DBHelper.Update("parkingdata", data, "id=" + id);
                if (result > 0)
                {
                    MessageBox.Show("Success to Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPane();
                }
                else
                {
                    MessageBox.Show("Failed to Deleted", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
