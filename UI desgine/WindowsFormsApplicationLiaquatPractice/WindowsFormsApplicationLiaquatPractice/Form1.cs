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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var MyLabel = new Label
            {
                Size = new Size(30, 10),
                Location = new Point(100, 100),
                Text = "pakistan",
               
            };

            this.Controls.Add(MyLabel);
        }
    }
}
