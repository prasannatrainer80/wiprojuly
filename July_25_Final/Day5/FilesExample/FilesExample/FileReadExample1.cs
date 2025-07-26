using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FilesExample
{
    internal class FileReadExample1
    {
        static void Main()
        {
            FileStream fs =
                new FileStream(@"D:\WiproJuly\Day5\PropertiesExample\AutoImplemented.cs", FileMode.Open,
                FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string line;
            while((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            sr.Close();
            fs.Close();
        }
    }
}
