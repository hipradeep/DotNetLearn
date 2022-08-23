using DotNetLearn.windosform;
using System;
using System.Windows.Forms;

namespace DotNetLearn
{
    static class App
    {
        ///<summary> 
        /// The main entry point for the application. 
        ///</summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new welcome()); // for sdi
            Application.Run(new windosform.mdi.Index()); // for mdi

        }
    }
}
