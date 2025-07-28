using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class MessageUtil
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox")]
        public static extern int ShowMessageBox(int hwnd, string text, string caption, uint type);
    }
}
