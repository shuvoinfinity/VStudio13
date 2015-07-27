using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRND
{
    class test3
    {
        //public void WriteToFile(string msg)
        //{
        //    DriveInfo();
        //    string filePath = @"D:\";
        //    //StreamWriter aWriter = new StreamWriter();
        //}
        public static void CreatFile()
        {
            string path = @"D:\";
            path = Path.Combine(path, "newtest.txt");
            if (!File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter aWriter = new StreamWriter(fs);
                aWriter.Write("Hello World");
                aWriter.Close();



            }
            else
            {
                Console.WriteLine("the path {0} is exist", path);
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                StreamReader aReader =  new StreamReader(fs);
                Console.WriteLine(aReader.ReadToEnd());
                aReader.Close();
            }
        }
    }
}
