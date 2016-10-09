using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persian_NationalID_Validator
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //***********************************************************************************
        private void checkIdButton_Click(object sender, EventArgs e)
        {

            if ((nationalIdTextbox.Text.Length <= 10) && (nationalIdTextbox.Text.Length >= 8))
            {            
                //Change to Standart Format for Small String Between 8 and 9
                //***********************************************************************************
                    string strNationalId = nationalIdTextbox.Text;

                if (strNationalId.Length == 8)
                {
                    strNationalId = "00" + strNationalId;
                }
                else if (strNationalId.Length == 9)
                {
                    strNationalId = "0" + strNationalId;
                }


                //Parse Text To Array And Convert it To int
                //***********************************************************************************
                string[] stringNationalIdArray = strNationalId.Select(c => c.ToString()).ToArray();
                int[] intNationalIdArray = Array.ConvertAll(stringNationalIdArray, s => int.Parse(s));


                //Validation Formula
                //***********************************************************************************
                int intSum = 0;
                for (int index = 8; index >= 0; index--)
                {
                    int i = 10 - index;
                    intNationalIdArray[index] = intNationalIdArray[index] * i;
                    intSum = intSum + intNationalIdArray[index];
                }
                int intControlValue = 0;
                intControlValue = intNationalIdArray[9];
                int intMod = intSum % 11;
                int intCorrectControlValue = 0;
                if (intMod <= 2)
                {
                    intCorrectControlValue = intMod;
                }
                else if (intMod > 2)
                {
                    intCorrectControlValue = 11 - intMod;
                }

                if (intControlValue == intCorrectControlValue)
                {
                    messageLable.Text = "Correct Information!";
                }
                else
                {
                    messageLable.Text = "Incorrect Information!";
                }

            }
            else
            {
                messageLable.Text = "Textbox length must be between 8 to 10 character";
            }
        }
        //***********************************************************************************
        private void resetButton_Click(object sender, EventArgs e)
        {
            nationalIdTextbox.Text = string.Empty;

        }

        private void nationalIdTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 8)) == false)
            {
                e.Handled = true;
            }
        }

    }
}
