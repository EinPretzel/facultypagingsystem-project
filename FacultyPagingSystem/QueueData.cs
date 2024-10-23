using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// EDITS: This is to have the Queue class available
// https://www.geeksforgeeks.org/c-sharp-queue-class/
// https://www.geeksforgeeks.org/c-sharp-queue-with-examples/
using System.Collections;
using System.IO;

namespace FacultyPagingSystem
{
    public class QueueData
    {
        // EDITS: Initialize Queues here. Turn those attributes below into an Enqueue.
        private Queue qFormNumber = new Queue();
        private Queue qFacultyName = new Queue();
        private Queue qPurpose = new Queue();
        private Queue qStudentName = new Queue();
        private Queue qStudentNumber = new Queue();
        private Queue qAvailability = new Queue();
        private Queue qResponse = new Queue();

        internal DataWriter d = new DataWriter();

        //private List<string> dataRow = new List<string>();

        // EDITS JULY 1: Constructor stuff written in previous versions moved into this method.
        public void InputData(string formNumber, string facultyName, string purpose, 
            string studentName, string studentNumber)
        {
            //Save to Queue
            this.qFormNumber.Enqueue(formNumber);
            this.qFacultyName.Enqueue(facultyName);
            this.qPurpose.Enqueue(purpose);
            this.qStudentName.Enqueue(studentName);
            this.qStudentNumber.Enqueue(studentNumber);
            //this.qAvailability.Enqueue(availability);
            //this.qResponse.Enqueue(response);

            // EDITS: You can input saving to table code here.
            
            List<string> dataRow = new List<string>();

            dataRow.Add(formNumber);
            dataRow.Add(facultyName);
            dataRow.Add(purpose);
            dataRow.Add(studentName);
            dataRow.Add(studentNumber);
            //dataRow.Add(availability);
            //dataRow.Add(response);

            d.WriteData(d.filePath, dataRow);
        }

        //Assign Peek and Dequeue methods on get properties
        public string FormNumber 
        { 
            get
            {
                return this.qFormNumber.Dequeue().ToString();
            }
        }

        public string FacultyName
        {
            get
            {
                return this.qFacultyName.Dequeue().ToString();
            }
        }

        public string Purpose
        {
            get
            {
                return this.qPurpose.Dequeue().ToString();
            }
        }

        public string StudentName
        {
            get
            {
                return this.qStudentName.Dequeue().ToString();
            }
        }

        public string StudentNumber
        {
            get
            {
                return this.qStudentNumber.Dequeue().ToString();
            }
        }

        public string Availability
        {
            get
            {
                return this.qAvailability.Dequeue().ToString();
            }
        }

        public string Response
        {
            get
            {
                return this.qResponse.Dequeue().ToString();
            }
        }

        public string FilePath
        {
            get
            {
                return this.d.filePath;
            }
            set
            {
                this.d.filePath = value;
            }
        }
    }
}
