using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyPagingSystem
{
    // This class is now in charge of interacting with the data behind the curtains for the
    // Faculty Interface side.
    internal static class FacultyHandler
    {
        // Instantiate and hold the object for data queueing. Can be called by the GUI methods.
        public static QueueData data = new QueueData();

        //Open the data log using the default application set in the system.
        internal static void DataLog()
        {
            System.Diagnostics.Process.Start(data.FilePath);
        }
    }
}
