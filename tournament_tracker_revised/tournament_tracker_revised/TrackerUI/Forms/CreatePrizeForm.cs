using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI.Forms
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// TODO: Create a method to deal with this
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void placeNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// TODO: Create a method to deal with this
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNumberTextBox.Text, 
                    placeNumberTextBox.Text, 
                    prizeAmountTextBox.Text, 
                    prizeAmountTextBox.Text);
                foreach(IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
            }
        }

        private bool ValidateForm()
        {
            bool output = false;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberTextBox.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }
            if (placeNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmout = 0;
            int prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountTextBox.Text, out prizeAmout);
            bool prizePercentageValid = int.TryParse(prizePercentageTextBox.Text, out prizePercentage);

            if(prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if(prizeAmout <= 0 && prizePercentage <= 0)
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
