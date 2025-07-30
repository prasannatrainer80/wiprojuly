using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples
{
    class Data
    {
        public void Show(string name)
        {
            lock (this)
            {
                Console.Write("Hello  " + name);
                Thread.Sleep(1000);
                Console.WriteLine(" How are You..."); 
            }
        }
    }
    public class SyncExample1
    {
        Data data;
        SyncExample1(Data data)
        {
            this.data = data;
        }

        public void Rajesh()
        {
            data.Show("Rajesh");
        }

        public void Venkata()
        {
            data.Show("Venkata");
        }

        static void Main()
        {
            SyncExample1 syncExample1 = new SyncExample1(new Data());
            ThreadStart th1 = new ThreadStart(syncExample1.Rajesh);
            ThreadStart th2 = new ThreadStart(syncExample1.Venkata);
            Thread t1 = new Thread(th1);
            Thread t2 = new Thread(th2);

            t1.Start();
            t2.Start();
        }
    }
}
