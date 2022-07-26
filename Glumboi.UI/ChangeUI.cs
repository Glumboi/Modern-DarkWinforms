﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Glumboi.UI.Ex;

namespace Glumboi.UI
{
    public class UIChanger
    {
        //Must be called in protected override void OnHandleCreated(EventArgs e) in order to work properly
        public static void ChangeTitlebarToDark(IntPtr handle)
        {
            DarkTitle.ChangeTitleBarToDark(handle);
        }

        public static void ChangeControlsToDark(Control form)
        {
            DarkControls.ChangeControlsToDark(form);
        }

    }
}
