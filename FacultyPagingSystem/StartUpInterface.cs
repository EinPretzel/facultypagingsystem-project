using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyPagingSystem
{
    public partial class StartUpInterface : Form
    {
        public StartUpInterface()
        {
            InitializeComponent();
        }

        //Move Screen
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;

        //Open Student Interface
        private void btnStudent_Click(object sender, EventArgs e)
        {
            var Sform = Application.OpenForms["StudentInterface"];
            if (Sform == null)
            {
                Sform = new StudentInterface();
                Sform.Show();
            }
            this.Hide();
        }
        //Open RFIDCheck Interface
        private void btnFaculty_Click(object sender, EventArgs e)
        {
            // Actual form to open when the RFID code in arduino is finally working
            
            var form = Application.OpenForms["RFIDCheckInterface"];
            if (form == null)
            {
                form = new RFIDCheckInterface();
                form.Show();
            }
            
            //Place holder code that opens faculty gui directly for testing
            /*
            var Fform = Application.OpenForms["FacultyInterface"];
            if (Fform == null)
            {
                Fform = new FacultyInterface();
                Fform.Show();
            }
            */
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
