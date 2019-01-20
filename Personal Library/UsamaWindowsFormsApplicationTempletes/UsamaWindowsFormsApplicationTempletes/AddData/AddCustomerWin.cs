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
using UsamaWindowsFormsApplicationTempletes.Interface;
using Project.Lib.Repositories;

namespace UsamaWindowsFormsApplicationTempletes.AddData
{
    public partial class AddCustomerWin : Form
    {
        ICustomerRequester callingWin;
        public AddCustomerWin(ICustomerRequester caller)
        {
            InitializeComponent();
            callingWin = caller;

            JoinningDate.Value = DateTime.Today;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            PlaceHolder.TextEnter(sender as TextBox);
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            PlaceHolder.TextLeave(sender as TextBox);
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            ResetErrors();

            if (!IsCustomerValid())
                return;

            var Customer = new Customer
            {
                Name = TextBoxName.Text.Trim(),
                Address = TextBoxAddress.Text.Trim(),
                PhoneNo = TextBoxPhoneNo.Text.Trim(),
                ProductName = TextBoxProduct.Text.Trim(),
                Balance = _balance,
                JoinningDate = JoinningDate.Value
            };

            var customerRepo = new CustomerRepository();
            customerRepo.Add(Customer);

            callingWin.CompleteCustomer(Customer);

            this.Close();
        }

        decimal _balance;
        private bool IsCustomerValid()
        {
            var output = true;

            if (TextBoxName.Text == TextBoxName.Tag as string)
            {
                output = false;

                ErrorName.Text = string.Concat(ErrorName.Text, "Enter your customer...");
                ErrorName.Visible = true;
            }
            else
            {
                ErrorName.Visible = false;
            }

            if (TextBoxAddress.Text == TextBoxAddress.Tag as string)
            {
                output = false;

                ErrorAddress.Text = string.Concat(ErrorAddress.Text, "Enter your address...");
                ErrorAddress.Visible = true;
            }
            else
            {
                ErrorAddress.Visible = false;
            }

            if (TextBoxPhoneNo.Text == TextBoxPhoneNo.Tag as string)
            {
                output = false;

                ErrorPhone.Text = string.Concat(ErrorPhone.Text, "Enter your phone...");
                ErrorPhone.Visible = true;
            }
            else
            {
                ErrorPhone.Visible = false;
            }

            if (TextBoxProduct.Text == TextBoxProduct.Tag as string)
            {
                output = false;

                ErrorProduct.Text = string.Concat(ErrorProduct.Text, "Enter your product...");
                ErrorProduct.Visible = true;
            }
            else
            {
                ErrorProduct.Visible = false;
            }

            if (TextBoxBalance.Text == TextBoxBalance.Tag as string || !decimal.TryParse(TextBoxBalance.Text , out _balance))
            {
                output = false;

                ErrorBalance.Text = string.Concat(ErrorBalance.Text, "Enter your correct Balance...");
                ErrorBalance.Visible = true;
            }
            else
            {
                ErrorBalance.Visible = false;
            }

            return output;
        }

        private void ResetErrors()
        {
            ErrorName.Text = "*";
            ErrorAddress.Text = "*";
            ErrorPhone.Text = "*";
            ErrorProduct.Text = "*";
            ErrorBalance.Text = "*";
        }
    }
}
