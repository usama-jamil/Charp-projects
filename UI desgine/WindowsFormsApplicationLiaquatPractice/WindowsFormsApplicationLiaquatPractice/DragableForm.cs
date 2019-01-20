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
    public partial class DragableForm : Form
    {
        Dragable drag = new Dragable();

        public DragableForm()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
                drag.MouseDown(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            drag.MouseMove(this, MousePosition.X, MousePosition.Y); 
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag.MouseUp();
        }
    }
}
