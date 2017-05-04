using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MS_Win32_API_Practice
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int MessageBox(int h, string m, string c, int type);

        static void Main(string[] args)
        {
            MessageBox(0, "Hello Win32 API", "qizl", 4);

            //System.Windows.Forms.Cursor.Clip = new Rectangle(1, 1, 1, 1);
            Console.Read();
        }
    }
}
