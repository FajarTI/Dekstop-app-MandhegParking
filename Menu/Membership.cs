using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.DataContracts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Latihan1_DL.Menu
{
    public partial class Membership : Form
    {
        string name;
        public int id;
        public Membership()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Membership_Load(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.GetData("membership");

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            edit.HeaderText = "Edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.HeaderText = "Delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;


            dtMembership.DataSource = dt;
            dtMembership.Columns.Add(edit);
            dtMembership.Columns.Add(delete);
            dtMembership.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtMembership.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbField.Enabled = true;
            gbField.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gbField.Enabled = false;
            gbField.Visible = false;
            btnSaveEdit.Enabled = false;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            name = tbName.Text;

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("name", name);
            data.Add("last_updated_at", DateTime.Now);

            int result = DBHelper.Update("membership", data,"id = " + id);
            if (result != 0)
            {
                MessageBox.Show("Success to Update!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataTable();
            }
            else
                MessageBox.Show("Failed to Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            name = tbName.Text;

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("name", name);

            if(!string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Silakan Isi Feild!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int result = DBHelper.Insert("membership", data);
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
            DataTable dt = DBHelper.GetData("membership");
            dtMembership.DataSource = dt;
            dtMembership.Refresh();
        }

        private void dtMembership_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSaveEdit.Enabled = true;
            btnSaveEdit.Visible = true;

            id = (int)dtMembership.Rows[e.RowIndex].Cells["id"].Value;

            //Edit
            if (dtMembership.Columns[e.ColumnIndex] is DataGridViewColumn && dtMembership.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex >= 0)
            {
                gbField.Enabled = true;
                gbField.Visible = true;

                tbName.Text = dtMembership.Rows[e.RowIndex].Cells["name"].Value.ToString();
            }
            //Delete
            if (dtMembership.Columns[e.ColumnIndex] is DataGridViewColumn && dtMembership.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex >= 0)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("deleted_at", DateTime.Now);

                int result = DBHelper.Update("membership", data, "id = " + id);
                if (result != 0)
                {
                    MessageBox.Show("Success to Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataTable();
                }
                else
                    MessageBox.Show("Failed to Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
