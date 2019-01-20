using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Lib.Models;
using Project.Lib;
using UsamaWinFormDesgineClassLibrary2;


namespace UsamaWindowsFormsApplicationTempletes.AddData
{
    public partial class AddExpenseWin : Form
    {
        private int _billNo;
        private decimal _amount;
        private PaymentMethod _paymentMethod = new PaymentMethod();

        public AddExpenseWin()
        {
            InitializeComponent();
        }

        private void buttonAddExpense_Click(object sender, EventArgs e)
        {
            ResetError();

            if (!IsExpenseValid())
                return;

            var Expense = new Expense
            {
                Title = TextBoxTitle.Text.Trim(),
                Description = TextBoxDescription.Text.Trim(),
                BillNo = _billNo,
                Amount = _amount,
                Date = ExpenseDate.Value,
                PaymentMethod = _paymentMethod
            };
                
        }

        private bool IsExpenseValid()
        {
           var output = true;

            if (TextBoxTitle.Text == TextBoxTitle.Tag as string)
            {
                output = false;

                ErrorTitle.Text = string.Concat(ErrorTitle.Text, "Enter the Title...");
                ErrorTitle.Visible = true;
            }
            else
            {
                ErrorTitle.Visible = false;
            }

            if (TextBoxDescription.Text == TextBoxDescription.Tag as string)
            {
                output = false;

                ErrorDescription.Text = string.Concat(ErrorDescription.Text, "Enter the Description");
                ErrorDescription.Visible = true;
            }
            else
            {
                ErrorDescription.Visible = true;
            }

            if (TextBoxBillNo.Text == TextBoxBillNo.Tag as string || !int.TryParse(TextBoxBillNo.Text,out _billNo))
            {
                output = false;

                ErrorBillNo.Text = string.Concat(ErrorBillNo.Text, "Enter the correct BillNo...");
                ErrorBillNo.Visible = true;
            }
            else
            {
                ErrorBillNo.Visible = false;
            }

            if (TextBoxAmount.Text == TextBoxAmount.Tag as string || !decimal.TryParse(TextBoxAmount.Text , out _amount))
            {
                output = false;

                ErrorAmount.Text = string.Concat(ErrorAmount.Text, "Enter the correct Amount...");
                ErrorAmount.Visible = true;
            }
            else
            {
                ErrorAmount.Visible = false;
            }

            return output;
        }

        private void ResetError()
        {
            ErrorTitle.Text = "*";
            ErrorDescription.Text = "*";
            ErrorBillNo.Text = "*";
            ErrorAmount.Text = "*";
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            PlaceHolder.TextEnter(sender as TextBox);
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            PlaceHolder.TextLeave(sender as TextBox);
        }

        private void CheckedChange(object sender, EventArgs e)
        {
            var RadioButton = sender as RadioButton;

            if (RadioButton.Text == radioButtonCash.Text)
            {
                _paymentMethod = PaymentMethod.Cash;
            }
            else if (RadioButton.Text == radioButtonChecque.Text)
            {
                _paymentMethod = PaymentMethod.Checque;
            }
            else if (RadioButton.Text == radioButtonCreditCard.Text)
            {
                _paymentMethod = PaymentMethod.CreditCard;
            }
        }
    }
}
