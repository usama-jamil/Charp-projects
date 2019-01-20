using System;
using System.Windows.Forms;

namespace UsamaWindowsFormsControlLibrary
{
    class UTabControl : TabControl 
    {

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 4904 && !this.DesignMode)
                m.Result = (IntPtr)1;
            else
                base.WndProc(ref m);
        }
    }
}
