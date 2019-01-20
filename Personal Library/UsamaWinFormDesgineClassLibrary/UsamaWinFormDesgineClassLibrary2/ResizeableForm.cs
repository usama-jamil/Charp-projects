using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UsamaWinFormDesgineClassLibrary2
{
    public  class ResizeableForm
    {
        private const int cGrip = 16;
        private const int cCaption = 32;

        // Sorry We Have to copy Paste that function

        public static void WndProcProxy(Form form , ref  Message m)
        {

            if (m.Msg == 0x84)
            {
                var point = new Point(m.LParam.ToInt32());
                point = form.PointToClient(point);

                if (point.Y < cCaption)
                {
                    m.Result = (IntPtr) 2 ;
                    return;
                }

                if (point.X >= form.ClientSize.Width - cGrip && point.Y >= form.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr) 17;
                    return;
                }
            }

            
        }
    }
}
