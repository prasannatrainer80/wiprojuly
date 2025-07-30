using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class IndexerEx2
    {
        Emp[] arr = new Emp[5];
        public Emp this[int id]
        {
            get
            {
                return arr[id];
            }
            set 
            { 
                arr[id] = value; 
            }
        }

        static void Main()
        {
            IndexerEx2 obj = new IndexerEx2();
            obj[0] = new Emp { Empno = 1, Name = "Rajesh", Basic = 82334 };
            obj[1] = new Emp { Empno = 2, Name = "Yamini", Basic = 88222 };
            obj[2] = new Emp { Empno = 3, Name = "Uday", Basic = 88231 };
            obj[3] = new Emp { Empno = 4, Name = "Pralavi", Basic = 82144 };

            foreach(var v in obj.arr)
            {
                Console.WriteLine(v);
            }
        }
    }
}
