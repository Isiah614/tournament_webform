using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

            return output;
        }
    }
}
