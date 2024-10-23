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
    public partial class StudentInterface : Form
    {
        public static StudentInterface Instance;
        public ComboBox stb1;
        public TextBox stb2;
        public TextBox stb3;
        public TextBox stb4;
        public Label sLab1;
        public Label sLab2;
        public Label sLab3;
        public Label sLab4;

        public StudentInterface()
        {
            InitializeComponent();
            Instance = this;
            stb1 = facultyName;
            stb2 = purpose;
            stb3 = studentName;
            stb4 = studentNumber;
            sLab1 = formNumber;
            sLab2 = displayQueue;
            sLab3 = response;
            sLab4 = response2;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms["StartUpInterface"];
            if (form.Visible == false)
            {
                form = new StartUpInterface();
                form.Show();
            }
            this.Close();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
          //Open Confirmation Interface
            ConfirmationInterface form = new ConfirmationInterface();
            form.Show();
        }
    }
}
