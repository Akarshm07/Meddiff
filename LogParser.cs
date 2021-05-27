using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Meddiff
{
    class LogParser
    {

        public LogParser()
        {

        }

        public void Parse(String fileName)
        {
            using (StreamWriter sw1 = File.CreateText("Error.txt"))
            using (StreamWriter sw2 = File.CreateText("Warnings.txt"))
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    //assuming the error logs start with ERROR: and Warnings start with Warnings:
                    if(s.StartsWith("ERROR:"))
                    {
                        sw1.WriteLine(s);
                        Console.WriteLine("error file -> "+s);
                    }
                    else if(s.StartsWith("Warnings:"))
                    {
                        sw2.WriteLine(s);
                        Console.WriteLine("warning file -> "+s);
                    }
                }
            }
            
        }
    }
}
