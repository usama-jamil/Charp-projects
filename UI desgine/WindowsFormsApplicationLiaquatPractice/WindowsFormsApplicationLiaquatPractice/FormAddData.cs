using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationLiaquatPractice
{
    public partial class FormAddData : Form
    {
        public FormAddData()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextLeave(sender as TextBox);
        }

       

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextEnter(sender as TextBox);
        }
        private void TextLeave(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                textbox.Text = textbox.Tag as string;

                textbox.ForeColor = Color.Silver;
            }
        }
        private void TextEnter(TextBox textbox)
        {
            if (textbox.Text == textbox.Tag as string)
            {

                textbox.Text = "";

                textbox.ForeColor = Color.Black;
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
