using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace UsamaWinFormDesgineClassLibrary2
{
    public static class PlaceHolder
    {
        /// <summary>
        /// ye us event kay sath ho ga jha textBox say bahir jatay hay
        /// </summary>
        /// <param name="textbox"></param>
       public static void TextLeave(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                textbox.Text = textbox.Tag as string;

                textbox.ForeColor = Color.Silver;
            }
        }

        /// <summary>
        /// ye us event kay sath ho ga jha textBox may enter hotay hay
        /// </summary>
        /// <param name="textbox"></param>
        public static void TextEnter(TextBox textbox)
        {
            if (textbox.Text == textbox.Tag as string)
            {

                textbox.Text = "";

                textbox.ForeColor = Color.Black;
            }
        }
    }
}
