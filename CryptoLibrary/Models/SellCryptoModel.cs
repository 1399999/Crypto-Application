using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoLibrary
{
     public class SellCryptoModel : BaseCryptoModel
    {

        public SellCryptoModel()
        {

        }
        public SellCryptoModel(string name, string fee, string uSDBought, DateTime date, string exchangeRate)
        {
            Name = name;

            int FeeValue = 0;
            int.TryParse(fee, out FeeValue);
            Fee = FeeValue;

            int USDBoughtValue = 0;
            int.TryParse(uSDBought, out USDBoughtValue);
            USDBought = USDBoughtValue;

            DateTime DateValue = DateTime.Now;
            Date = DateValue;

            int ExhangeRateValue = 0;
            int.TryParse(exchangeRate, out ExhangeRateValue);
            ExchangeRate = ExhangeRateValue;

        }
    }
}
