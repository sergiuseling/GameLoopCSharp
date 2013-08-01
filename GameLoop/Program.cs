using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform;

namespace GameLoop
{
    static class Program
    {
        //static FastLoop _fastLoop = new FastLoop(GameLoop);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void GameLoop(double elapsedTime)
        {
            //GetInput
            //Process
            //Render
            System.Console.WriteLine("Game Loop");
        }
    }
}
