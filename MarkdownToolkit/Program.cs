using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Pictograms;
using System.Linq;
using System.Windows.Forms;

namespace Toolkit
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

#if DEBUG
            ImageHelper.GetEditorIcon(MaterialDesign.GetImage(MaterialDesign.IconType.wrap_text, 256, Color.White));
#endif

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FormMain());
        }
    }
}
