using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsamaWinFormDesgineClassLibrary2
{
   public class Dragable
    {
        private bool isMoving = false;

        private int _x;
        private int _y;

        public void MouseDown(int x , int y)
        {
            _x = x;
            _y = y;

            isMoving = true;
        }

        public void MouseMove(Form Form, int mouseX, int mouseY)
        {
            if (isMoving)
            {
                Form.SetDesktopLocation(mouseX - _x, mouseY - _y);
                
            }
        }

        public void MouseUp()
        {
            isMoving = false;
        }
    }
}
