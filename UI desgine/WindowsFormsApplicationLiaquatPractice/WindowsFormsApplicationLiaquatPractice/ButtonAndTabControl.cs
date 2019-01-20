using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using UsamaWinFormDesgineClassLibrary2;

namespace WindowsFormsApplicationLiaquatPractice
{
    public partial class ButtonAndTabControl : Form
    {
        public ButtonAndTabControl()
        {
            InitializeComponent();
        }

        private void ButtonAndTabControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //tabControl1.SelectTab(tabPage4 );

            MenuIndicator.SelectTabPage(sender as Button, tabControl1, tabPage4, panel3);
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }
    }
}
