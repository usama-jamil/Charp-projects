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
using Project.Lib.Models;
using Project.Lib.Repositories;

namespace UsamaWindowsFormsApplicationTempletes.AddData
{
    public partial class AddSalePerson : Form
    {
        public AddSalePerson()
        {
            InitializeComponent();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            PlaceHolder.TextEnter(sender as TextBox);
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            PlaceHolder.TextLeave(sender as TextBox);
        }

        private void buttonAddSalePerson_Click(object sender, EventArgs e)
        {
            ResetErrors();

            if (!IsSalePersonValid())
                return;
            var SalePerson = new SalePerson();

            var salePersonRepo = new SalePersonRepository();
            salePersonRepo.Add(SalePerson);


            this.Close();

        }
        decimal _salary ;
        private bool IsSalePersonValid()
        {
            var output = true;

            if (TextBoxName.Text == TextBoxName.Tag as string)
            {
                output = false;

                ErrorName.Text = string.Concat(ErrorName.Text, "Enter your sale person...");
                ErrorName.Visible = true;
            }
            else
            {
                ErrorName.Visible = false;
            }


            if (textBoxAddress.Text == textBoxAddress.Tag as string)
            {
                output = false;

                ErrorAddress.Text = string.Concat(ErrorAddress.Text, "Enter your address...");
                ErrorAddress.Visible = true;
            }
            else
            {
                ErrorAddress.Visible = false;
            }

            if (textBoxCNIC.Text == textBoxCNIC.Tag as string)
            {
                output = false;

                ErrorCNIC.Text = string.Concat(ErrorCNIC.Text, "Enter your CNIC...");
                ErrorCNIC.Visible = true;
            }
            else
            {
                ErrorCNIC.Visible = false;
            }

            if (textBoxPhoneNo.Text == textBoxPhoneNo.Tag as string)
            {
                output = false;

                ErrorPhoneNo.Text = string.Concat(ErrorPhoneNo.Text, "Enter your PhoneNp...");
                ErrorPhoneNo.Visible = true;
            }
            else
            {
                ErrorPhoneNo.Visible = false;
            }


            if (textBoxSalary.Text == textBoxSalary.Tag as string ||
                !decimal.TryParse(textBoxSalary.Text,out _salary) || 
                _salary <= 0)
            {
                output = false;

                ErrorSalary.Text = string.Concat(ErrorSalary.Text, "Enter your Salary...");
                ErrorSalary.Visible = true;
            }
            else
            {
                ErrorSalary.Visible = false;
            }

            return output;
        }

        private void ResetErrors()
        {
            ErrorName.Text =
            ErrorAddress.Text =
            ErrorCNIC.Text =
            ErrorPhoneNo.Text =
            ErrorSalary.Text = "*";
        }
    }
}
