using System;
using System.Windows.Forms;

namespace ProductosElectronicos
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Asegúrate de que está llamando a Form1
        }
    }
}
