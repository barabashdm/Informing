using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informing
{
    static class Program
    {
        internal static Form1 f1;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            f1 = new Form1();
            Application.Run(f1);
        }
    }

    static class Data
    {
        public static int Value { get; set; }
    }
}
