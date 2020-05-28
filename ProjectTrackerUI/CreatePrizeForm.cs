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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace ProjectTrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNumberValueTextbox.Text,
                    placeNameValueTextbox.Text,
                    prizeAmountTextBox.Text,
                    prizePercentageTbox.Text);

                model = GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();

                //placeNumberValueTextbox.Text = "";
                //placeNameValueTextbox.Text = "";
                //prizeAmountTextBox.Text = "0";
                //prizePercentageTbox.Text = "0";


            }
            else 
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
       

        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValueTextbox.Text, out placeNumber);

            if (!placeNumberValidNumber) 
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameValueTextbox.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            int prizePercentage = 0;

            bool prizeAmountValidNumber = decimal.TryParse(prizeAmountTextBox.Text, out prizeAmount);
            bool prizePercentageValidNumber = int.TryParse(prizePercentageTbox.Text, out prizePercentage);



            if (!prizeAmountValidNumber || !prizePercentageValidNumber) 
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizeAmount < 0 || prizePercentage > 100)
            {
                output = false;
            }






            return output;
        }
    }
}
