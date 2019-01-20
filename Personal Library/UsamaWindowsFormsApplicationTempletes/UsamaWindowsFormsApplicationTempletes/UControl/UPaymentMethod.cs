using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Lib;

namespace UsamaWindowsFormsApplicationTempletes.UControl
{
    public partial class UPaymentMethod : UserControl
    {
        private PaymentMethod _paymentMethod = new PaymentMethod();

        public PaymentMethod PaymentMethod { get { return _paymentMethod; } } 

        public UPaymentMethod()
        {
            InitializeComponent();
        }

        private void UPaymentMethod_Load(object sender, EventArgs e)
        {

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
