using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace ClassBasics
{
    class ExceptionHandling
    {
        public static void Main()
        {
            //This line will throw FileNotFoundException
            StreamReader streamReader = new StreamReader("C:\\NonExistingFile.txt");
            //StreamReader streamReader = new StreamReader(@"C:\Sample files\Data.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            //Closes the underlying stream and releases the system resources.
            //If there is an exception before this line, the below line will never
            //be executed and the resources are not relased
            streamReader.Close();
        }
    }
}
