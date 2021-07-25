namespace Crypto
{
    partial class SellCryptoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.USDBoughtTextBox = new System.Windows.Forms.TextBox();
            this.USDBought = new System.Windows.Forms.Label();
            this.FeeTextBox = new System.Windows.Forms.TextBox();
            this.FeeLabel = new System.Windows.Forms.Label();
            this.EthereumRadioButton = new System.Windows.Forms.RadioButton();
            this.LiteCoinRadioButton = new System.Windows.Forms.RadioButton();
            this.BitcoinCashRadioButton = new System.Windows.Forms.RadioButton();
            this.BitcoinRadioButton = new System.Windows.Forms.RadioButton();
            this.WhatCryptoLabel = new System.Windows.Forms.Label();
            this.ExchangeRateLabel = new System.Windows.Forms.Label();
            this.ExchangeRateTextBox = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(603, 520);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(113, 44);
            this.CancelButton.TabIndex = 31;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(455, 520);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(118, 42);
            this.OkButton.TabIndex = 30;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(82, 394);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(322, 32);
            this.DateLabel.TabIndex = 26;
            this.DateLabel.Text = "The date you sold your crypto:";
            // 
            // USDBoughtTextBox
            // 
            this.USDBoughtTextBox.Location = new System.Drawing.Point(366, 338);
            this.USDBoughtTextBox.Name = "USDBoughtTextBox";
            this.USDBoughtTextBox.Size = new System.Drawing.Size(172, 39);
            this.USDBoughtTextBox.TabIndex = 25;
            // 
            // USDBought
            // 
            this.USDBought.AutoSize = true;
            this.USDBought.Location = new System.Drawing.Point(82, 338);
            this.USDBought.Name = "USDBought";
            this.USDBought.Size = new System.Drawing.Size(269, 32);
            this.USDBought.TabIndex = 24;
            this.USDBought.Text = "Amount of USD you sold:";
            // 
            // FeeTextBox
            // 
            this.FeeTextBox.Location = new System.Drawing.Point(260, 274);
            this.FeeTextBox.Name = "FeeTextBox";
            this.FeeTextBox.Size = new System.Drawing.Size(172, 39);
            this.FeeTextBox.TabIndex = 23;
            // 
            // FeeLabel
            // 
            this.FeeLabel.AutoSize = true;
            this.FeeLabel.Location = new System.Drawing.Point(82, 277);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(176, 32);
            this.FeeLabel.TabIndex = 22;
            this.FeeLabel.Text = "Price of the Fee:";
            // 
            // EthereumRadioButton
            // 
            this.EthereumRadioButton.AutoSize = true;
            this.EthereumRadioButton.Location = new System.Drawing.Point(228, 208);
            this.EthereumRadioButton.Name = "EthereumRadioButton";
            this.EthereumRadioButton.Size = new System.Drawing.Size(130, 36);
            this.EthereumRadioButton.TabIndex = 21;
            this.EthereumRadioButton.TabStop = true;
            this.EthereumRadioButton.Text = "Ethereum";
            this.EthereumRadioButton.UseVisualStyleBackColor = true;
            // 
            // LiteCoinRadioButton
            // 
            this.LiteCoinRadioButton.AutoSize = true;
            this.LiteCoinRadioButton.Location = new System.Drawing.Point(228, 166);
            this.LiteCoinRadioButton.Name = "LiteCoinRadioButton";
            this.LiteCoinRadioButton.Size = new System.Drawing.Size(121, 36);
            this.LiteCoinRadioButton.TabIndex = 20;
            this.LiteCoinRadioButton.TabStop = true;
            this.LiteCoinRadioButton.Text = "Lite Coin";
            this.LiteCoinRadioButton.UseVisualStyleBackColor = true;
            // 
            // BitcoinCashRadioButton
            // 
            this.BitcoinCashRadioButton.AutoSize = true;
            this.BitcoinCashRadioButton.Location = new System.Drawing.Point(228, 124);
            this.BitcoinCashRadioButton.Name = "BitcoinCashRadioButton";
            this.BitcoinCashRadioButton.Size = new System.Drawing.Size(156, 36);
            this.BitcoinCashRadioButton.TabIndex = 19;
            this.BitcoinCashRadioButton.TabStop = true;
            this.BitcoinCashRadioButton.Text = "Bitcoin Cash";
            this.BitcoinCashRadioButton.UseVisualStyleBackColor = true;
            // 
            // BitcoinRadioButton
            // 
            this.BitcoinRadioButton.AutoSize = true;
            this.BitcoinRadioButton.Location = new System.Drawing.Point(228, 82);
            this.BitcoinRadioButton.Name = "BitcoinRadioButton";
            this.BitcoinRadioButton.Size = new System.Drawing.Size(100, 36);
            this.BitcoinRadioButton.TabIndex = 18;
            this.BitcoinRadioButton.TabStop = true;
            this.BitcoinRadioButton.Text = "Bitcoin";
            this.BitcoinRadioButton.UseVisualStyleBackColor = true;
            // 
            // WhatCryptoLabel
            // 
            this.WhatCryptoLabel.AutoSize = true;
            this.WhatCryptoLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhatCryptoLabel.Location = new System.Drawing.Point(187, 34);
            this.WhatCryptoLabel.Name = "WhatCryptoLabel";
            this.WhatCryptoLabel.Size = new System.Drawing.Size(269, 32);
            this.WhatCryptoLabel.TabIndex = 17;
            this.WhatCryptoLabel.Text = "What crypto did you sell?";
            // 
            // ExchangeRateLabel
            // 
            this.ExchangeRateLabel.AutoSize = true;
            this.ExchangeRateLabel.Location = new System.Drawing.Point(77, 452);
            this.ExchangeRateLabel.Name = "ExchangeRateLabel";
            this.ExchangeRateLabel.Size = new System.Drawing.Size(318, 32);
            this.ExchangeRateLabel.TabIndex = 32;
            this.ExchangeRateLabel.Text = "What was your Exchange rate:";
            // 
            // ExchangeRateTextBox
            // 
            this.ExchangeRateTextBox.Location = new System.Drawing.Point(401, 452);
            this.ExchangeRateTextBox.Name = "ExchangeRateTextBox";
            this.ExchangeRateTextBox.Size = new System.Drawing.Size(172, 39);
            this.ExchangeRateTextBox.TabIndex = 33;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(410, 394);
            this.DatePicker.MaxDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.DatePicker.MinDate = new System.DateTime(2009, 1, 3, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(349, 39);
            this.DatePicker.TabIndex = 34;
            // 
            // SellCryptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 589);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.ExchangeRateTextBox);
            this.Controls.Add(this.ExchangeRateLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.USDBoughtTextBox);
            this.Controls.Add(this.USDBought);
            this.Controls.Add(this.FeeTextBox);
            this.Controls.Add(this.FeeLabel);
            this.Controls.Add(this.EthereumRadioButton);
            this.Controls.Add(this.LiteCoinRadioButton);
            this.Controls.Add(this.BitcoinCashRadioButton);
            this.Controls.Add(this.BitcoinRadioButton);
            this.Controls.Add(this.WhatCryptoLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "SellCryptoForm";
            this.Text = "Sell Crypto";
            this.Load += new System.EventHandler(this.SellCryptoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox USDBoughtTextBox;
        private System.Windows.Forms.Label USDBought;
        private System.Windows.Forms.TextBox FeeTextBox;
        private System.Windows.Forms.Label FeeLabel;
        private System.Windows.Forms.RadioButton EthereumRadioButton;
        private System.Windows.Forms.RadioButton LiteCoinRadioButton;
        private System.Windows.Forms.RadioButton BitcoinCashRadioButton;
        private System.Windows.Forms.RadioButton BitcoinRadioButton;
        private System.Windows.Forms.Label WhatCryptoLabel;
        private System.Windows.Forms.Label ExchangeRateLabel;
        private System.Windows.Forms.TextBox ExchangeRateTextBox;
        private System.Windows.Forms.DateTimePicker DatePicker;
    }
}