using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyPagingSystem
{
    // This class is now in charge of interacting with the data behind the curtains for the
    // Student Interface side.
    internal static class StudentHandler
    {
        // This method pushes the data to the Faculty Handler, which directly interacts
        // with the Data Log.
        public static void PushData
            (string formNumber,
             string facultyName,
             string purpose,
             string studentName,
             string studentNumber)
        {
            FacultyHandler.data.InputData(formNumber, facultyName, purpose, studentName, studentNumber);
        }
    }
}
