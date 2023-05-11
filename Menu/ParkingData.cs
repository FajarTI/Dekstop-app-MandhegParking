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
    public partial class ParkingData : Form
    {
        public ParkingData()
        {
            InitializeComponent();
        }

        private void gbField_Enter(object sender, EventArgs e)
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


            dtParkingData.DataSource = dt;
            dtParkingData.Columns.Add(edit);
            dtParkingData.Columns.Add(delete);
            dtParkingData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtParkingData.AllowUserToAddRows = false;
        }
    }
}
