using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Glumboi.UI.Ex
{
    internal class DarkTitle
    {
        [DllImport("DwmApi")] //System.Runtime.InteropServices
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        //Must be used in protected override void OnHandleCreated(EventArgs e) in order to work on a form
        internal static void ChangeTitleBarToDark(IntPtr handle)
        {
            if (DwmSetWindowAttribute(handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(handle, 20, new[] { 1 }, 4);
        }
    }
}
