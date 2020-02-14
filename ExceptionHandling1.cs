using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ClassBasics
{
    class ExceptionHandling1
    {
        public static void Main()
        {
            StreamReader streamReader = null;
            try
            {
                // This line will throw FileNotFoundException
                streamReader = new StreamReader("C:\\NonExistingFile.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            // This catch block handles only FileNotFoundException
            catch (FileNotFoundException fileNotFoundException)
            {
                // Log or email the exception
                // Code to log or email exception details
                WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", fileNotFoundException.StackTrace, DateTime.Now));
                Console.WriteLine("Log is Written Successfully !!!");
                //Console.WriteLine(fileNotFoundException.);
                Console.ReadLine();
                
                // Display meaningful error message to the end user
                Console.WriteLine("Please check if the file \"{0}\" is present", fileNotFoundException.FileName);
            }
            // This catch block handles all the other exceptions
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }
    }
    class WriteLogFile
    {
        public static bool WriteLog(string strFileName, string strMessage)
        {
            try
            {
                FileStream objFilestream = new FileStream(string.Format("{0}\\{1}", Path.GetTempPath(), strFileName), FileMode.Append, FileAccess.Write);
                
                StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
                objStreamWriter.WriteLine(strMessage);
                objStreamWriter.Close();
                objFilestream.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
