using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoLibrary;

namespace Crypto
{
    public partial class CryptoForm : Form
    {
        List<BuyCryptoModel> models = new List<BuyCryptoModel>();
        public CryptoForm()
        {
            InitializeComponent();

            UpDateBindings();
        }
        private void SellButton_Click(object sender, EventArgs e)
        {

            SellCryptoForm Dialog = new SellCryptoForm();
            Dialog.ShowDialog();

        }

        private void BuyButton_Click(object sender, EventArgs e)
        {

            BuyCryptoForm Dialog = new BuyCryptoForm();
            Dialog.ShowDialog();

        }

        private void CryptoForm_Load(object sender, EventArgs e)
        {

        }

        private void TotalCryptoBoughtValue_Click(object sender, EventArgs e)
        {

        }

        private void UpDateBindings()
        {
            DataGridVeiw.AutoGenerateColumns = false;
            DataGridVeiw.DataSource = models;
        }

        private void CryptoForm_Shown(object sender, EventArgs e)
        {
            AmountBoughtValue.Text = GlobalConfig.Connections.GetBuyCrypto_All().Where(x => x.ISBuying == 0).Sum(x => x.USDBought).ToString("C");
            AmountSoldValue.Text = GlobalConfig.Connections.GetBuyCrypto_All().Where(x => x.ISBuying == 1).Sum(x => x.USDBought).ToString("C");
            models = GlobalConfig.Connections.GetBuyCrypto_All();
            UpDateBindings();
            
        }
        
        private void DataGridVeiw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
