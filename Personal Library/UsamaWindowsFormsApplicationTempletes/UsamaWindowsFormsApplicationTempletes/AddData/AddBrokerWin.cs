using Project.Lib.Models;
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

namespace UsamaWindowsFormsApplicationTempletes.AddData
{
    public partial class AddBrokerWin : Form
    {
        public AddBrokerWin()
        {
            InitializeComponent();
        }


        private void buttonAddBroker_Click(object sender, EventArgs e)
        {
            ResetErrors();

            if (!IsBrokerValid())
                return;

            var broker = new Broker();
        }

        private bool IsBrokerValid()
        {
            var output = true;

            if (TextBoxName.Text == TextBoxName.Tag as string)
            {
                output = false;

                ErrorName.Text = string.Concat(ErrorName.Text, "Enter your Broker...");
                ErrorName.Visible = true;

            }
            else
            {
                ErrorName.Visible = false;
            }

            if (TextBoxAddress.Text == TextBoxAddress.Tag as string)
            {
                output = false;

                ErrorAddress.Text = string.Concat(ErrorAddress.Text, "Enter your Address...");
                ErrorAddress.Visible = true;
            }
            else
            {
                ErrorAddress.Visible = false;
            }

            if (TextBoxPhoneNo.Text ==  TextBoxPhoneNo.Tag as string)
            {
                output = false;

                ErrorPhone.Text = string.Concat(ErrorPhone.Text, "Enter  Phone No...");
                ErrorPhone.Visible = true;
            }
            else
            {
                ErrorPhone.Visible = false;
            }

            
            if (string.IsNullOrWhiteSpace( DropDownSupplier.Text))
            {
                output = false;

                ErrorSupplier.Text = string.Concat(ErrorSupplier.Text, "Enter the supplier...");
                ErrorSupplier.Visible = true;
            }
            else
            {
                ErrorSupplier.Visible = false;
            }

            return output;
        }

        private void ResetErrors()
        {
            ErrorName.Text = "*";
            ErrorAddress.Text = "*";
            ErrorPhone.Text = "*";
            ErrorSupplier.Text = "*";

        }

        private void Textbox_Enter(object sender, EventArgs e)
        {
            PlaceHolder.TextEnter(sender as TextBox);
        }

        private void Textbox_Leave(object sender, EventArgs e)
        {
            PlaceHolder.TextLeave(sender as TextBox);
        }
    }
}
