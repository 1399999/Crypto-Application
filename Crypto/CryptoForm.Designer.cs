namespace Crypto
{
    partial class CryptoForm
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
            this.BuyButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.AccountInfoLabel = new System.Windows.Forms.Label();
            this.AmountEarnedLabel = new System.Windows.Forms.Label();
            this.AmountBoughtValue = new System.Windows.Forms.Label();
            this.TotalCryptoBoughtLabel = new System.Windows.Forms.Label();
            this.AmountSoldValue = new System.Windows.Forms.Label();
            this.DataGridVeiw = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanSellColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsdBoughtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExchangeRateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CryptoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVeiw)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyButton
            // 
            this.BuyButton.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.BuyButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BuyButton.Location = new System.Drawing.Point(724, 152);
            this.BuyButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(132, 54);
            this.BuyButton.TabIndex = 0;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // SellButton
            // 
            this.SellButton.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.SellButton.Location = new System.Drawing.Point(732, 241);
            this.SellButton.Margin = new System.Windows.Forms.Padding(4);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(124, 54);
            this.SellButton.TabIndex = 1;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // AccountInfoLabel
            // 
            this.AccountInfoLabel.AutoSize = true;
            this.AccountInfoLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.AccountInfoLabel.Location = new System.Drawing.Point(283, 31);
            this.AccountInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccountInfoLabel.Name = "AccountInfoLabel";
            this.AccountInfoLabel.Size = new System.Drawing.Size(132, 32);
            this.AccountInfoLabel.TabIndex = 2;
            this.AccountInfoLabel.Text = "Acount Info";
            // 
            // AmountEarnedLabel
            // 
            this.AmountEarnedLabel.AutoSize = true;
            this.AmountEarnedLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.AmountEarnedLabel.Location = new System.Drawing.Point(34, 98);
            this.AmountEarnedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountEarnedLabel.Name = "AmountEarnedLabel";
            this.AmountEarnedLabel.Size = new System.Drawing.Size(195, 32);
            this.AmountEarnedLabel.TabIndex = 3;
            this.AmountEarnedLabel.Text = "Amount You Sold:";
            // 
            // AmountBoughtValue
            // 
            this.AmountBoughtValue.AutoSize = true;
            this.AmountBoughtValue.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.AmountBoughtValue.Location = new System.Drawing.Point(233, 98);
            this.AmountBoughtValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountBoughtValue.Name = "AmountBoughtValue";
            this.AmountBoughtValue.Size = new System.Drawing.Size(27, 32);
            this.AmountBoughtValue.TabIndex = 4;
            this.AmountBoughtValue.Text = "0";
            // 
            // TotalCryptoBoughtLabel
            // 
            this.TotalCryptoBoughtLabel.AutoSize = true;
            this.TotalCryptoBoughtLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.TotalCryptoBoughtLabel.Location = new System.Drawing.Point(416, 98);
            this.TotalCryptoBoughtLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalCryptoBoughtLabel.Name = "TotalCryptoBoughtLabel";
            this.TotalCryptoBoughtLabel.Size = new System.Drawing.Size(224, 32);
            this.TotalCryptoBoughtLabel.TabIndex = 5;
            this.TotalCryptoBoughtLabel.Text = "Amount You Bought:";
            // 
            // AmountSoldValue
            // 
            this.AmountSoldValue.AutoSize = true;
            this.AmountSoldValue.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.AmountSoldValue.Location = new System.Drawing.Point(663, 98);
            this.AmountSoldValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountSoldValue.Name = "AmountSoldValue";
            this.AmountSoldValue.Size = new System.Drawing.Size(27, 32);
            this.AmountSoldValue.TabIndex = 6;
            this.AmountSoldValue.Text = "0";
            this.AmountSoldValue.Click += new System.EventHandler(this.TotalCryptoBoughtValue_Click);
            // 
            // DataGridVeiw
            // 
            this.DataGridVeiw.BackgroundColor = System.Drawing.Color.White;
            this.DataGridVeiw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVeiw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.CanSellColumn,
            this.UsdBoughtColumn,
            this.FeeColumn,
            this.ExchangeRateColumn,
            this.CryptoColumn});
            this.DataGridVeiw.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridVeiw.Location = new System.Drawing.Point(29, 152);
            this.DataGridVeiw.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridVeiw.MultiSelect = false;
            this.DataGridVeiw.Name = "DataGridVeiw";
            this.DataGridVeiw.ReadOnly = true;
            this.DataGridVeiw.Size = new System.Drawing.Size(673, 288);
            this.DataGridVeiw.TabIndex = 7;
            this.DataGridVeiw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridVeiw_CellContentClick);
            // 
            // DateColumn
            // 
            this.DateColumn.DataPropertyName = "Date";
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // CanSellColumn
            // 
            this.CanSellColumn.DataPropertyName = "YouColumn";
            this.CanSellColumn.HeaderText = "You";
            this.CanSellColumn.Name = "CanSellColumn";
            this.CanSellColumn.ReadOnly = true;
            // 
            // UsdBoughtColumn
            // 
            this.UsdBoughtColumn.DataPropertyName = "USDBought";
            this.UsdBoughtColumn.HeaderText = "USD Bought";
            this.UsdBoughtColumn.Name = "UsdBoughtColumn";
            this.UsdBoughtColumn.ReadOnly = true;
            this.UsdBoughtColumn.Width = 110;
            // 
            // FeeColumn
            // 
            this.FeeColumn.DataPropertyName = "Fee";
            this.FeeColumn.HeaderText = "Fee";
            this.FeeColumn.Name = "FeeColumn";
            this.FeeColumn.ReadOnly = true;
            // 
            // ExchangeRateColumn
            // 
            this.ExchangeRateColumn.DataPropertyName = "ExchangeRate";
            this.ExchangeRateColumn.HeaderText = "Exchange Rate";
            this.ExchangeRateColumn.Name = "ExchangeRateColumn";
            this.ExchangeRateColumn.ReadOnly = true;
            this.ExchangeRateColumn.Width = 120;
            // 
            // CryptoColumn
            // 
            this.CryptoColumn.DataPropertyName = "Name";
            this.CryptoColumn.HeaderText = "Crypto";
            this.CryptoColumn.Name = "CryptoColumn";
            this.CryptoColumn.ReadOnly = true;
            // 
            // CryptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 463);
            this.Controls.Add(this.DataGridVeiw);
            this.Controls.Add(this.AmountSoldValue);
            this.Controls.Add(this.TotalCryptoBoughtLabel);
            this.Controls.Add(this.AmountBoughtValue);
            this.Controls.Add(this.AmountEarnedLabel);
            this.Controls.Add(this.AccountInfoLabel);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.BuyButton);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CryptoForm";
            this.Text = "Crypto Application - version 1.0.0";
            this.Load += new System.EventHandler(this.CryptoForm_Load);
            this.Shown += new System.EventHandler(this.CryptoForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVeiw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Label AccountInfoLabel;
        private System.Windows.Forms.Label AmountEarnedLabel;
        private System.Windows.Forms.Label AmountBoughtValue;
        private System.Windows.Forms.Label TotalCryptoBoughtLabel;
        private System.Windows.Forms.Label AmountSoldValue;
        private System.Windows.Forms.DataGridView DataGridVeiw;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanSellColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsdBoughtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExchangeRateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CryptoColumn;
    }
}

