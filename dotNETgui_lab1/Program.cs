using System;
using System.Windows.Forms;
using KnapsackGUI;
using KnapsackProblem;  // Je�li masz projekt odwo�uj�cy si� do konsolowego

namespace dotNETgui_lab1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // Upewnij si�, �e 'Form1' jest w tej przestrzeni nazw
        }
    }
}
