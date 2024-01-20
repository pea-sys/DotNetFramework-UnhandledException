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

        private void ThrowOutOfRangeExceptionMethod()
        {
            int[] myArray = new int[0];
            Console.WriteLine(myArray[myArray.Length]);
        }

        private void threadExceptionButton_Click(object sender, EventArgs e)
        {
           Task.Run(() => ThrowOutOfRangeExceptionMethod()).Wait();
        }
    }
}
