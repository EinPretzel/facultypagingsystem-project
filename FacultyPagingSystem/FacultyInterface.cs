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
    public partial class FacultyInterface : Form
    {
        public static FacultyInterface Instance;
        public TextBox ftb1;
        public TextBox ftb2;
        public TextBox ftb3;
        public TextBox ftb4;  
        public Label fLab1;
        public Label fLab2;
        public int queueLength;
        public string pInQueue;

        public FacultyInterface()
        {
            InitializeComponent();
            if (!Arduino1.IsOpen)
            {
                try
                {
                    Arduino1.Open();
                }
                catch
                {
                    Arduino1.Close();
                }
            }
            Instance = this;
            ftb1 = facultyName;
            ftb2 = purpose;
            ftb3 = studentName;
            ftb4 = studentNumber;
            fLab1 = formNumber;
            fLab2 = inQueue;
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

        //Prompt Response from Availability
        private void cboAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAvailability.SelectedIndex == 0)
            {
                response.Text = "Proceed to -Location-";
            }
            else if (cboAvailability.SelectedIndex == 1)
            {
                response.Text = "-Insert Date/Time of Availability-";
            }
            else
            {
                response.Text = String.Empty;
            }
        }

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

        private void btnRespond_Click(object sender, EventArgs e)
        {
            //Need to change to peer to peer communication type opening of form (LAN)
            //https://docs.microsoft.com/en-us/previous-versions/dotnet/articles/cc297274(v=msdn.10)?redirectedfrom=MSDN

            //Response Check
            if (cboAvailability.SelectedItem != null)
            {
                //Queue Error Check
                queueLength = int.Parse(inQueue.Text);
                if (queueLength != 0)
                {
                    //Update Student Form Status 
                    if (formNumber.Text == StudentInterface.Instance.sLab2.Text)
                    {
                        StudentInterface.Instance.sLab3.Text = cboAvailability.Text;
                        StudentInterface.Instance.sLab4.Text = response.Text; 
                        //If available response would prompt the input of location of meetup
                        //If unavailable response would prompt the input of date and time of availability
                    }
                    else
                    {
                        StudentInterface.Instance.sLab2.Text = formNumber.Text;
                        StudentInterface.Instance.sLab3.Text = cboAvailability.Text;
                        StudentInterface.Instance.sLab4.Text = response.Text;
                    }

                    //Update inQueue Number
                    queueLength = queueLength - 1;
                    if (queueLength < 10)
                    {
                        pInQueue = "0" + queueLength.ToString();
                    }
                    else if (queueLength >= 10)
                    {
                        pInQueue = queueLength.ToString();
                    }
                    FacultyInterface.Instance.fLab2.Text = pInQueue;

                    //Clear Form
                    facultyName.Text = String.Empty;
                    purpose.Text = String.Empty;
                    studentName.Text = String.Empty;
                    studentNumber.Text = String.Empty;
                    cboAvailability.SelectedItem = null;
                    response.Text = String.Empty;

                    // EDITS: Changed to try and catch to avoid crashing in empty queue
                    try
                    {
                        FacultyInterface.Instance.fLab1.Text = FacultyHandler.data.FormNumber;
                        FacultyInterface.Instance.ftb1.Text = FacultyHandler.data.FacultyName;
                        FacultyInterface.Instance.ftb2.Text = FacultyHandler.data.Purpose;
                        FacultyInterface.Instance.ftb3.Text = FacultyHandler.data.StudentName;
                        FacultyInterface.Instance.ftb4.Text = FacultyHandler.data.StudentNumber;
                        //.Instance.cboAvailability.Text = FacultyHandler.data.Availability;
                        //FacultyInterface.Instance.response.Text = FacultyHandler.data.Response;
                    }
                    catch (Exception) { }
                }
            }
        }

        private void dataLog_Click(object sender, EventArgs e)
        {
            //Open DataLog
            FacultyHandler.DataLog();
        }

        //Handles Buzzer Notification Everytime text is updated
        //Transfered here from confirmation interface to have the arduino only connected to one pc
        private void facultyName_TextChanged(object sender, EventArgs e)
        {
            if (facultyName.Text != string.Empty)
            {
                //Send Signal to Arduino
                //This character'A' will turn on the buzzer
                //Comment this out and the Arduino1.Open() if no port is connected to prevent errors
                try
                {
                    Arduino1.Write("A");
                }
                catch
                {
                    if (!Arduino1.IsOpen)
                    {
                        try
                        {
                            Arduino1.Open();
                        }
                        catch
                        {
                            Arduino1.Close();
                        }
                    }
                }
            }
            
        }
    }
}
