using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FacultyPagingSystem
{
    internal class DataWriter
    {
        public string filePath;

        // EDITS JULY 1: Changed constructor.
        public DataWriter()
        {
            this.filePath = "data.csv"; // Placeholder file name
            //Console.WriteLine(Directory.GetCurrentDirectory()); // Just so I know where it creates a file
        }

        public void WriteData(string filepath, IEnumerable<string> row)
        {
            // Writing data
            this.CreateDataFile(filepath);
            using (StreamWriter sw = File.AppendText(filepath))
            {
                sw.WriteLine(ToCsv(row));
            }

            ///// Formatting-related methods /////
            //
            // Taken from:
            // https://stackoverflow.com/questions/60400582/how-to-write-a-csv-file-without-using-external-libraries
            // with certain modifications
            //
            string ToCsv(IEnumerable<string> input)
            {
                var sb = new StringBuilder();
                sb.Append(string.Join(",", input.Select(f => SafeQuote(f))));
                return sb.ToString();
            }

            //string ToCsv(IEnumerable<IEnumerable<string>> input)
            //{
            //    var sb = new StringBuilder();
            //    foreach (var line in input)
            //    {
            //        sb.AppendLine(string.Join(",", line.Select(f => SafeQuote(f))));
            //    }
            //    return sb.ToString();
            //}

            string SafeQuote(string field)
            {
                return MustQuote(field)
                  ? @"""" + field.Replace(@"""", @"""""") + @""""
                  : field;
            }

            bool MustQuote(string field) =>
              field.Any(c => c == ',' || c == '"' || c == 13 || c == 10);
            //
            //
            /////     END OF FORMATTING-RELATED METHODS    /////
        }

        // Method to create the CSV file. Can potentially be used for changing
        //  data file location.
        public void CreateDataFile(string filename)
        {
            // If not exists, create
            if (!File.Exists(filename))
            {
                var f = File.Create(filename);
                f.Close();
            }
        }
    }
}
