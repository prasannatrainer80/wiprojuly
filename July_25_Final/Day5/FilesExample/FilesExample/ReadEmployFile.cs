using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FilesExample
{
    internal class ReadEmployFile
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"c:\files\Employ.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Employ employ = (Employ)binaryFormatter.Deserialize(fs);
            Console.WriteLine(employ);
        }
    }
}
