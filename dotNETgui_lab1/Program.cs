using System;
using System.Windows.Forms;
using KnapsackGUI;
using KnapsackProblem;  // Jeœli masz projekt odwo³uj¹cy siê do konsolowego

namespace dotNETgui_lab1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // Upewnij siê, ¿e 'Form1' jest w tej przestrzeni nazw
        }
    }
}
