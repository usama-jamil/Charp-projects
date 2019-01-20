using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsamaWinFormDesgineClassLibrary2;

namespace WindowsFormsApplicationLiaquatPractice
{
    public partial class Resizeable : Form
    {
        public Resizeable()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                var point = new Point(m.LParam.ToInt32());
                point = this.PointToClient(point);

                if (point.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (point.X >= this.ClientSize.Width - cGrip && point.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }

            base.WndProc(ref m);

            this.DoubleBuffered = true;
        }
    }
}
