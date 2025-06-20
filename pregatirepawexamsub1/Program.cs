using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pregatirepawexamsub1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DataStore.LoadPackages();
            DataStore.LoadRegistrations();
            Application.Run(new Form1());
        }
    }
}
