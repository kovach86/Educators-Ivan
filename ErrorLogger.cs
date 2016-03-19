using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextHandlers
{
    public static class ErrorLogger
    {
        public static void WriteError(Exception ex)
        {
            string path = @"C:\Users\Kovach\Documents\Visual Studio 2015\Projects\Educators\TextHandlers\Text_Files\ErrorLogger.txt";
            TextWriter writer = new StreamWriter(path, true);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("------------------*----------------------");
            sb.AppendLine(DateTime.Now + " Exception: ");
            sb.AppendLine(ex.Message);
            if (ex.InnerException != null)
            {
                sb.AppendLine("- - - - - - - ");
                sb.AppendLine("Details:");
                sb.AppendLine(ex.InnerException.Message);
                sb.AppendLine(ex.InnerException.StackTrace);
            }

            writer.Write(sb.ToString());

            writer.Flush();
            writer.Close();
        }
    }
}
