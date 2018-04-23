// Developer Express Code Central Example:
// How to obtain only values cells that are visible
// 
// This task can be accomplished by using the GridViewInfo class. This class
// provides collections of the visible rows (the GridRowInfoCollection) and visible
// columns (the GridColumnsInfo).
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1243

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsApplication1 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

		         Application.Run(new Form1());
        }
    }
}