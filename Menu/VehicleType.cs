using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Latihan1_DL.Menu
{
    public partial class VehicleType : Form
    {
        string name;
        public int id;
        public VehicleType()
        {
            InitializeComponent();
        }

        private void VehicleType_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData("vehicletype");

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            edit.HeaderText = "Edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.HeaderText = "Delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;


            dtVehicleType.DataSource = dt;
            dtVehicleType.Columns.Add(edit);
            dtVehicleType.Columns.Add(delete);
            dtVehicleType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtVehicleType.AllowUserToAddRows = false;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            name = tbName.Text;

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("name", name);

            if (!string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Silakan Isi Feild!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int result = DBHelper.Insert("vehicletype", data);
            if (result != 0)
            {
                MessageBox.Show("Success to Add!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataTable();
            }
            else
                MessageBox.Show("Failed to Add!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void RefreshDataTable()
        {
            DataTable dt = DBHelper.GetData("vehicletype");
            dtVehicleType.DataSource = dt;
            dtVehicleType.Refresh();
        }

        private void dtVehicleType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSaveEdit.Enabled = true;
            btnSaveEdit.Visible = true;

            id = (int)dtVehicleType.Rows[e.RowIndex].Cells["id"].Value;

            //Edit
            if (dtVehicleType.Columns[e.ColumnIndex] is DataGridViewColumn && dtVehicleType.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex >= 0)
            {
                gbField.Enabled = true;
                gbField.Visible = true;

                tbName.Text = dtVehicleType.Rows[e.RowIndex].Cells["name"].Value.ToString();
            }
            //Delete
            if (dtVehicleType.Columns[e.ColumnIndex] is DataGridViewColumn && dtVehicleType.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex >= 0)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("deleted_at", DateTime.Now);

                int result = DBHelper.Update("vehicletype", data, "id = " + id);
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

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("name", name);
            data.Add("last_updated_at", DateTime.Now);

            if (!string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Silakan Isi Feild!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int result = DBHelper.Update("vehicletype", data, "id = " + id);
            if (result != 0)
            {
                MessageBox.Show("Success to Add!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataTable();
            }
            else
                MessageBox.Show("Failed to Add!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
