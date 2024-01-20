using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionExWindowsForms
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
        private static string PickErrorMessageFromAggregateException(AggregateException ae, int depth = 0)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var ie in ae.InnerExceptions)
            {
                if (ie is AggregateException)
                {
                    sb.Append(PickErrorMessageFromAggregateException((AggregateException)ie, depth + 1));
                }
                else
                {
                    sb.Append(string.Format("集約エラー階層{0}", depth) + Environment.NewLine + ie.Message + Environment.NewLine + ie.StackTrace.ToString());
                }
            }
            return sb.ToString();
        }
        private static bool IsApplicationExit(ThreadExceptionEventArgs e)
        {
            return (e.Exception is AccessViolationException);
        }
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                StringBuilder errorMessageSb = new StringBuilder();
                if (e.Exception is AggregateException)
                {
                    errorMessageSb.Append(PickErrorMessageFromAggregateException((AggregateException)e.Exception).ToString());
                }
                else
                {
                    errorMessageSb.Append(e.Exception.Message + Environment.NewLine + e.Exception.StackTrace.ToString());
                }
                MessageBox.Show(errorMessageSb.ToString(), string.Format("エラースレッド番号:{0}", Thread.CurrentThread.ManagedThreadId.ToString()));       

            }
            finally
            {
                if  (IsApplicationExit(e))
                {
                    Application.Exit();
                }
                else
                {
                    Application.Restart();
                }
                
            }
        }
    }
}
