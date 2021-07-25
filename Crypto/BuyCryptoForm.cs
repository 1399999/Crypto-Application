using CryptoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto
{
    public partial class BuyCryptoForm : Form
    {
        public BuyCryptoForm()
        {
            InitializeComponent();
        }

        private void BuyCryptoForm_Load(object sender, EventArgs e)
        {

        }

        private void FeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void FeeTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            var ErrorMessage = ValidateForm();
            string Name = "Bitcoin";
            if (BitcoinRadioButton.Checked) {

                Name = "Bitcoin";
            }
            if (BitcoinCashRadioButton.Checked) {

                Name = "Bitcoin Cash";
            }
            if (LiteCoinRadioButton.Checked) {

                Name = "Litecoin";
            }
            if (EthereumRadioButton.Checked) {

                Name = "Ethereum";
            }
            if (ErrorMessage == "")
            {
                BuyCryptoModel model = new BuyCryptoModel(
                    Name,
                    FeeTextBox.Text,
                    USDBoughtTextBox.Text,
                    DatePicker.Value,
                    ExchangeRateTextBox.Text
                )
                {
                    
                };

                model.ISBuying = 1;
                GlobalConfig.Connections.BuyCrypto(model);
            
                this.Close();
            }
            else
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WhatCryptoLabel_Click(object sender, EventArgs e)
        {

        }

        private void USDBoughtTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private string ValidateForm()
        {
            var Output = "";
            int FeeUSD = 0;
            int USDBought = 0;
            int ExchangeRate = 0;
            bool FeeValidForm = int.TryParse(FeeTextBox.Text, out FeeUSD);
            if (!FeeValidForm)
            {
                Output = "Your FeeUSD is not a number";
            }
            if (FeeUSD < 0)
            {
                Output = "Your FeeUSD has to be greater than zero";
            }
            bool USDBoughtValidForm = int.TryParse(USDBoughtTextBox.Text, out USDBought);
            if (!USDBoughtValidForm)
            {
                Output = "Your USD Bought is not a number";
            }
            if (USDBought < 1)
            {
                Output = "Your USD Bought is less than 1";
            }
            //if (DateTextBox.TextLength == 0)
            //{
            //    Output = "Your date has no text";
            //}
            if (!BitcoinRadioButton.Checked && 
                !BitcoinCashRadioButton.Checked && 
                !LiteCoinRadioButton.Checked && 
                !EthereumRadioButton.Checked)
            {
                Output = "Check a button";
            }
            if (ExchangeRate > 1)
            {
                Output = "Your Exchange rate is less than 1";
            }
            bool ExchangeRateValidForm = int.TryParse(USDBoughtTextBox.Text, out ExchangeRate);
            if (!ExchangeRateValidForm)
            {
                Output = "Your Exchange rate is not a number";
            }
            return Output;
        }

        private void DateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LiteCoinRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WhatCryptoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
