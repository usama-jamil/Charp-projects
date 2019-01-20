using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tutorial
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        

        private void area_Click(object sender, EventArgs e)
        {
            int length, width, area;
            length = Convert.ToInt32( txtWidth.Text);
            width = Convert.ToInt32(txtlength.Text);
            area = length * width;
            lblarea.Text = area.ToString("n");
        }

        private void cost_Click(object sender, EventArgs e)
        {
            int length, width;
            double price, roomcost;
            length = Convert.ToInt32(txtWidth.Text);
            width = Convert.ToInt32(txtlength.Text);
            price = Convert.ToDouble(txtcost.Text);
            roomcost = (length * width )* price;

            lblcost.Text = roomcost.ToString("c");

        }

        private void clear_Click(object sender, EventArgs e)
        {
            lblcost.Text = "";
            lblarea.Text = "";
           
        }
    }
}
