using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ExceptionExWindowsForms
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            this.Text = RuntimeInformation.FrameworkDescription;
        }

        private void uiThreadExceptionButton_Click(object sender, EventArgs e)
        {
            ThrowOutOfRangeExceptionMethod();
        }
        private void threadExceptionButton_Click(object sender, EventArgs e)
        {
            Task.Run(() => ThrowOutOfRangeExceptionMethod()).Wait();
        }

        private void accessViolationExceptionButton_Click(object sender, EventArgs e)
        {
            ThrowAccessViolationException();
        }
        private void ThrowOutOfRangeExceptionMethod()
        {
            int[] myArray = new int[0];
            Console.WriteLine(myArray[myArray.Length]);
        }
        // ref:https://stackoverflow.com/questions/41031308/system-accessviolationexception-for-unsafe-code
        [DllImport("user32")]
        private static extern int CallWindowProc(int lpPrevWndFunc, int hWnd, int Msg, int wParam, int lParam);
        private unsafe void ThrowAccessViolationException()
        {
            byte[] b = { 0x8B };
            fixed (byte* bb = &b[0])
            {
                int bi = (int)bb;
                CallWindowProc(bi,0, 0, 0, 0);
            }
        }
    }
}
