namespace Crypto
{
    partial class BuyCryptoForm
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
            this.WhatCryptoLabel = new System.Windows.Forms.Label();
            this.FeeLabel = new System.Windows.Forms.Label();
            this.FeeTextBox = new System.Windows.Forms.TextBox();
            this.USDBought = new System.Windows.Forms.Label();
            this.USDBoughtTextBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EthereumRadioButton = new System.Windows.Forms.RadioButton();
            this.LiteCoinRadioButton = new System.Windows.Forms.RadioButton();
            this.BitcoinRadioButton = new System.Windows.Forms.RadioButton();
            this.BitcoinCashRadioButton = new System.Windows.Forms.RadioButton();
            this.ExchangeRateTextBox = new System.Windows.Forms.TextBox();
            this.ExchangeRateLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // WhatCryptoLabel
            // 
            this.WhatCryptoLabel.AutoSize = true;
            this.WhatCryptoLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhatCryptoLabel.Location = new System.Drawing.Point(196, 31);
            this.WhatCryptoLabel.Name = "WhatCryptoLabel";
            this.WhatCryptoLabel.Size = new System.Drawing.Size(341, 32);
            this.WhatCryptoLabel.TabIndex = 0;
            this.WhatCryptoLabel.Text = "What crypto would did you buy?";
            this.WhatCryptoLabel.Click += new System.EventHandler(this.WhatCryptoLabel_Click);
            // 
            // FeeLabel
            // 
            this.FeeLabel.AutoSize = true;
            this.FeeLabel.Location = new System.Drawing.Point(91, 274);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(176, 32);
            this.FeeLabel.TabIndex = 7;
            this.FeeLabel.Text = "Price of the Fee:";
            // 
            // FeeTextBox
            // 
            this.FeeTextBox.Location = new System.Drawing.Point(269, 273);
            this.FeeTextBox.Name = "FeeTextBox";
            this.FeeTextBox.Size = new System.Drawing.Size(172, 39);
            this.FeeTextBox.TabIndex = 8;
            this.FeeTextBox.TextChanged += new System.EventHandler(this.FeeTextBox_TextChanged);
            // 
            // USDBought
            // 
            this.USDBought.AutoSize = true;
            this.USDBought.Location = new System.Drawing.Point(91, 335);
            this.USDBought.Name = "USDBought";
            this.USDBought.Size = new System.Drawing.Size(301, 32);
            this.USDBought.TabIndex = 9;
            this.USDBought.Text = "Amount of USD you bought:";
            this.USDBought.Click += new System.EventHandler(this.FeeLabel_Click);
            // 
            // USDBoughtTextBox
            // 
            this.USDBoughtTextBox.Location = new System.Drawing.Point(398, 332);
            this.USDBoughtTextBox.Name = "USDBoughtTextBox";
            this.USDBoughtTextBox.Size = new System.Drawing.Size(172, 39);
            this.USDBoughtTextBox.TabIndex = 10;
            this.USDBoughtTextBox.TextChanged += new System.EventHandler(this.USDBoughtTextBox_TextChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(91, 394);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(395, 32);
            this.DateLabel.TabIndex = 11;
            this.DateLabel.Text = "The date you purschased your crypto:";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(482, 515);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(118, 42);
            this.OkButton.TabIndex = 15;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(631, 515);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(113, 44);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EthereumRadioButton
            // 
            this.EthereumRadioButton.AutoSize = true;
            this.EthereumRadioButton.Location = new System.Drawing.Point(238, 210);
            this.EthereumRadioButton.Name = "EthereumRadioButton";
            this.EthereumRadioButton.Size = new System.Drawing.Size(130, 36);
            this.EthereumRadioButton.TabIndex = 4;
            this.EthereumRadioButton.TabStop = true;
            this.EthereumRadioButton.Text = "Ethereum";
            this.EthereumRadioButton.UseVisualStyleBackColor = true;
            // 
            // LiteCoinRadioButton
            // 
            this.LiteCoinRadioButton.AutoSize = true;
            this.LiteCoinRadioButton.Location = new System.Drawing.Point(238, 168);
            this.LiteCoinRadioButton.Name = "LiteCoinRadioButton";
            this.LiteCoinRadioButton.Size = new System.Drawing.Size(121, 36);
            this.LiteCoinRadioButton.TabIndex = 3;
            this.LiteCoinRadioButton.TabStop = true;
            this.LiteCoinRadioButton.Text = "Lite Coin";
            this.LiteCoinRadioButton.UseVisualStyleBackColor = true;
            this.LiteCoinRadioButton.CheckedChanged += new System.EventHandler(this.LiteCoinRadioButton_CheckedChanged);
            // 
            // BitcoinRadioButton
            // 
            this.BitcoinRadioButton.AutoSize = true;
            this.BitcoinRadioButton.Location = new System.Drawing.Point(238, 84);
            this.BitcoinRadioButton.Name = "BitcoinRadioButton";
            this.BitcoinRadioButton.Size = new System.Drawing.Size(100, 36);
            this.BitcoinRadioButton.TabIndex = 1;
            this.BitcoinRadioButton.TabStop = true;
            this.BitcoinRadioButton.Text = "Bitcoin";
            this.BitcoinRadioButton.UseVisualStyleBackColor = true;
            // 
            // BitcoinCashRadioButton
            // 
            this.BitcoinCashRadioButton.AutoSize = true;
            this.BitcoinCashRadioButton.Location = new System.Drawing.Point(238, 126);
            this.BitcoinCashRadioButton.Name = "BitcoinCashRadioButton";
            this.BitcoinCashRadioButton.Size = new System.Drawing.Size(156, 36);
            this.BitcoinCashRadioButton.TabIndex = 2;
            this.BitcoinCashRadioButton.TabStop = true;
            this.BitcoinCashRadioButton.Text = "Bitcoin Cash";
            this.BitcoinCashRadioButton.UseVisualStyleBackColor = true;
            // 
            // ExchangeRateTextBox
            // 
            this.ExchangeRateTextBox.Location = new System.Drawing.Point(415, 449);
            this.ExchangeRateTextBox.Name = "ExchangeRateTextBox";
            this.ExchangeRateTextBox.Size = new System.Drawing.Size(172, 39);
            this.ExchangeRateTextBox.TabIndex = 37;
            // 
            // ExchangeRateLabel
            // 
            this.ExchangeRateLabel.AutoSize = true;
            this.ExchangeRateLabel.Location = new System.Drawing.Point(91, 449);
            this.ExchangeRateLabel.Name = "ExchangeRateLabel";
            this.ExchangeRateLabel.Size = new System.Drawing.Size(318, 32);
            this.ExchangeRateLabel.TabIndex = 36;
            this.ExchangeRateLabel.Text = "What was your Exchange rate:";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(492, 394);
            this.DatePicker.MaxDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.DatePicker.MinDate = new System.DateTime(2009, 1, 3, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(349, 39);
            this.DatePicker.TabIndex = 38;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // BuyCryptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 584);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.ExchangeRateTextBox);
            this.Controls.Add(this.ExchangeRateLabel);
            this.Controls.Add(this.BitcoinCashRadioButton);
            this.Controls.Add(this.BitcoinRadioButton);
            this.Controls.Add(this.LiteCoinRadioButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EthereumRadioButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.USDBoughtTextBox);
            this.Controls.Add(this.USDBought);
            this.Controls.Add(this.FeeTextBox);
            this.Controls.Add(this.FeeLabel);
            this.Controls.Add(this.WhatCryptoLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "BuyCryptoForm";
            this.Text = "Buy Crypto";
            this.Load += new System.EventHandler(this.BuyCryptoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WhatCryptoLabel;
        private System.Windows.Forms.Label FeeLabel;
        private System.Windows.Forms.TextBox FeeTextBox;
        private System.Windows.Forms.Label USDBought;
        private System.Windows.Forms.TextBox USDBoughtTextBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.RadioButton EthereumRadioButton;
        private System.Windows.Forms.RadioButton LiteCoinRadioButton;
        private System.Windows.Forms.RadioButton BitcoinRadioButton;
        private System.Windows.Forms.RadioButton BitcoinCashRadioButton;
        private System.Windows.Forms.TextBox ExchangeRateTextBox;
        private System.Windows.Forms.Label ExchangeRateLabel;
        private System.Windows.Forms.DateTimePicker DatePicker;
    }
}