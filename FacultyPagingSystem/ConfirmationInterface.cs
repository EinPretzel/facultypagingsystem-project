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
    public partial class ConfirmationInterface : Form
    {
        public int formNum;
        public string formTxt;
        public int queueLength;
        public string inQueue;
        private string formNumber;
        private string facultyName;
        private string purpose;
        private string studentName;
        private string studentNumber;

        public ConfirmationInterface()
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Clear Student Interface
            StudentInterface.Instance.stb1.Text = String.Empty;
            StudentInterface.Instance.stb2.Text = String.Empty;
            StudentInterface.Instance.stb3.Text = String.Empty;
            StudentInterface.Instance.stb4.Text = String.Empty;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Open or Update Faculty Interface
            //Need to change to peer to peer communication type opening of form (LAN)
            //https://docs.microsoft.com/en-us/previous-versions/dotnet/articles/cc297274(v=msdn.10)?redirectedfrom=MSDN
            
            var form = Application.OpenForms["FacultyInterface"];
            if (form == null)
            {
                form = new FacultyInterface();
                form.Show();
            }
            
            //Save Form Data to Local
            formNumber = StudentInterface.Instance.sLab1.Text;
            facultyName = StudentInterface.Instance.stb1.Text;
            purpose = StudentInterface.Instance.stb2.Text;
            studentName = StudentInterface.Instance.stb3.Text;
            studentNumber = StudentInterface.Instance.stb4.Text;

            // EDITS JULY 1: Instantiation of the QueueData object has been moved to Faculty Handler,
            //  a new class that is intended to directly interact with the Data Log. This move is an
            //  attempt to separate the Student Interface and Faculty Interface for the network
            //  functionality.
            //  This is also to facilitate easier merging of code during collab; GUI work is separate
            //  from "behind-the-scenes" functionality.
            //
            // //Save Form Data to Global
            // //QueueData data = new QueueData(formNumber, facultyName, purpose, studentName, studentNumber);
            StudentHandler.PushData(formNumber, facultyName, purpose, studentName, studentNumber);

            //Transfer Data to Faculty Interface if clear
            if (String.IsNullOrEmpty(FacultyInterface.Instance.ftb1.Text))
            {
                FacultyInterface.Instance.fLab1.Text = FacultyHandler.data.FormNumber;
                FacultyInterface.Instance.ftb1.Text = FacultyHandler.data.FacultyName;
                FacultyInterface.Instance.ftb2.Text = FacultyHandler.data.Purpose;
                FacultyInterface.Instance.ftb3.Text = FacultyHandler.data.StudentName;
                FacultyInterface.Instance.ftb4.Text = FacultyHandler.data.StudentNumber;
            }

            //Update Student Form Number
            formNum = int.Parse(StudentInterface.Instance.sLab1.Text);
            formNum = formNum + 1;
            if (formNum < 10)
            {
                formTxt = "000" + formNum.ToString();
            }
            else if (formNum >= 10 && formNum < 100)
            {
                formTxt = "00" + formNum.ToString();
            }
            else if (formNum >= 100 && formNum < 1000)
            {
                formTxt = "0" + formNum.ToString();
            }
            else if (formNum >= 1000)
            {
                formTxt = formNum.ToString();
            }
            StudentInterface.Instance.sLab1.Text = formTxt;

            //Update Faculty InQueue Number
            queueLength = int.Parse(FacultyInterface.Instance.fLab2.Text);
            queueLength = queueLength + 1;
            if (queueLength < 10)
            {
                inQueue = "0" + queueLength.ToString();
            }
            else if (queueLength >= 10)
            {
                inQueue = queueLength.ToString();
            }
            FacultyInterface.Instance.fLab2.Text = inQueue;

            //Clear Student Interface
            StudentInterface.Instance.stb1.Text = String.Empty;
            StudentInterface.Instance.stb2.Text = String.Empty;
            StudentInterface.Instance.stb3.Text = String.Empty;
            StudentInterface.Instance.stb4.Text = String.Empty;

            this.Close();
        }
    }
}
