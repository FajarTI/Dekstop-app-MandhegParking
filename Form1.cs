using Latihan1_DL.Menu;
using System.Runtime.InteropServices;

namespace Latihan1_DL
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr h, int w, int wP, int lP);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void OpenForm(Form child, object sender)
        {
            this.activeForm = child;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            this.panelDekstop.Controls.Add(child);
            this.panelDekstop.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy - HH:mm:ss");
        }
        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenForm(new Employee(), sender);
        }
        private void btnMembership_Click(object sender, EventArgs e)
        {
            OpenForm(new Membership(), sender);
        }

        private void btnVehicleType_Click(object sender, EventArgs e)
        {
            OpenForm(new VehicleType(), sender);
        }

        private void btnHourlyRates_Click(object sender, EventArgs e)
        {
            OpenForm(new HourlyRates(), sender);
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            OpenForm(new Member(), sender);
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            OpenForm(new Vehicle(), sender);
        }

        private void btnParkingData_Click(object sender, EventArgs e)
        {
            OpenForm(new ParkingData(), sender);
        }
    }
}