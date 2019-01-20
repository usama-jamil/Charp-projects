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
using System.Text.RegularExpressions;
using UsamaWindowsFormsApplicationTempletes.Interface;
using Project.Lib.Repositories;

namespace UsamaWindowsFormsApplicationTempletes.AddData
{
    public partial class AddSupplierWin : Form
    {

        ISupplierRequester callingWin;
        public AddSupplierWin(ISupplierRequester caller)
        {
            InitializeComponent();
            callingWin = caller;

            JoinningDate.Value = DateTime.Today;
        }

        //decimal _balance;
        private bool IsSupplierValid()
        {
            var output = true;

            if (textBoxName.Text == textBoxName.Tag as string)
            {
                output = false;

                ErrorName.Text = string.Concat(ErrorName.Text, "Enter your supplier...");
                ErrorName.Visible = true;

            }
            else
            {
                ErrorName.Visible = false;
            }

            if (textBoxCompany.Text == textBoxCompany.Tag as string)
            {
                output = false;

                ErrorCompany.Text = string.Concat(ErrorCompany.Text, "Enter your company...");
                ErrorCompany.Visible = true;

            }
            else
            {
                ErrorCompany.Visible = false;
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


            if (textBoxPhone.Text == textBoxPhone.Tag as string)
            {
                output = false;

                ErrorPhone.Text = string.Concat(ErrorPhone.Text, "Enter your phone No...");
                ErrorPhone.Visible = true;

            }
            else
            {
                ErrorPhone.Visible = false;
            }


            if (textBoxProduct.Text == textBoxProduct.Tag as string)
            {
                output = false;

                ErrorProduct.Text = string.Concat(ErrorProduct.Text, "Enter your product...");
                ErrorProduct.Visible = true;

            }
            else
            {
                ErrorProduct.Visible = false;
            }


            //if (textBoxBalance.Text == textBoxBalance.Tag as string || !decimal.TryParse(textBoxBalance.Text, out _balance))
            //{
            //    output = false;

            //    ErrorBalance.Text = string.Concat(ErrorBalance.Text, "Enter your balance...");
            //    ErrorBalance.Visible = true;

            //}
            //else
            //{
            //    ErrorBalance.Visible = false;
            //}

            return output;
        }

        private void SupplierTextBox_Enter(object sender, EventArgs e)
        {
            PlaceHolder.TextEnter(sender as TextBox);
        }

        private void SupplierTextBox_Leave(object sender, EventArgs e)
        {
            PlaceHolder.TextLeave(sender as TextBox);
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            ResetErrors();

            if (!IsSupplierValid())
                return;

            var Supplier = new Supplier
            {
                Name = textBoxName.Text.Trim(),
                Address = textBoxAddress.Text.Trim(),
                PhoneNumber = textBoxPhone.Text.Trim(),
                //Balance = _balance,
                JoinningDate = JoinningDate.Value,
            };

            var supplierRepo = new SupplierRepository();
            supplierRepo.Add(Supplier);

            callingWin.CompleteSupplier(Supplier);


            this.Close();               
        }

        private void ResetErrors()
        {
                ErrorName.Text = "*";
                ErrorCompany.Text = "*";
                ErrorAddress.Text = "*";
                ErrorPhone.Text = "*";
                ErrorProduct.Text = "*";
                ErrorBalance.Text = "*";
        }
    }
}
