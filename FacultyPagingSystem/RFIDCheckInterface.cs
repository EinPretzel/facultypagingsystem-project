using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyPagingSystem
{
    public partial class RFIDCheckInterface : Form
    {
        public delegate void d1(string indata);
        public RFIDCheckInterface()
        {
            InitializeComponent();
            Arduino1.Open();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            StartUpInterface form = new StartUpInterface();
            form.Show();
        }

        private void Arduino1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string indata = Arduino1.ReadLine();
            d1 writeit = new d1(Write2Form);
            Invoke(writeit, indata);
        }

        //This function handles data sent from Arduino
        public void Write2Form(string indata)
        {
            char firstchar;
            firstchar = indata[0];
            switch(firstchar)
            {
                //Tap In
                case 'i':
                    var form1 = Application.OpenForms["FacultyInterface"];
                    if (form1 == null)
                    {
                        form1 = new FacultyInterface();
                        form1.Show();
                    }
                    this.Hide();
                    break;
                //Tap Out
                /*
                case 'o':
                    var form2 = Application.OpenForms["FacultyInterface"];
                    if (form2 != null)
                    {
                        form2 = new FacultyInterface();
                        form2.Close();
                    }
                    this.Hide();
                    break;
                */
                //No Access
                case 'e':
                    MessageBox.Show("Incorrect RFID");
                    break;
            }
        }
    }
}
