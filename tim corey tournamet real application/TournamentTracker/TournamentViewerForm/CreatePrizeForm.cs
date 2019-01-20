using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TournamentViewerForm
{
    public partial class CreatePrizeForm : Form
    {
        private IPrizeRequester callingForm;

        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void buttonCreatePrize_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                var prizeModel = new PrizeModel(
                    textBoxPlaceName.Text,
                    textBoxPlaceNumber.Text,
                    textBoxPrizeAmount.Text,
                    textBoxPrizePercentage.Text);


                GlobalConfig.Connections.CreatePrize(prizeModel);

                callingForm.PrizeComplete(prizeModel);

                this.Close();

                //textBoxPlaceName.Text = "";
                //textBoxPlaceNumber.Text = "";
                //textBoxPrizeAmount.Text = "0";
                //textBoxPrizePercentage.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }

        }

        private bool IsFormValid ()
        {
            bool output = true;
            int placeNumber = 0;
            bool isPlaceNumberValid = int.TryParse(textBoxPlaceNumber.Text, out placeNumber);

            if (! isPlaceNumberValid)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (textBoxPlaceName.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool isPrizeAmountValid = decimal.TryParse(textBoxPrizeAmount.Text, out prizeAmount);
            bool isPrizePercentegeValid = double.TryParse(textBoxPrizePercentage.Text, out prizePercentage);

            if (! isPrizeAmountValid || ! isPrizePercentegeValid)
            {
                output = false;
            }

            // TODO - Review this if statement
            if (prizeAmount == 0 && prizePercentage == 0)
            {
                output = false;
            }

            if (prizeAmount < 0 )
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
            return output;
        }
    }
}
