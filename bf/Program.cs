using System;
using System.Windows.Forms;

namespace bf
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Brainfuck brainfuck = new Brainfuck();

            Application.Run(brainfuck);
        }
    }
}
