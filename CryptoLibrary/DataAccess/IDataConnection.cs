using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoLibrary
{
    public interface IDataConnection
    {
         BuyCryptoModel BuyCrypto(BuyCryptoModel model);
         SellCryptoModel SellCrypto(SellCryptoModel model);
         List<BuyCryptoModel> GetBuyCrypto_All();
         //List<BuyCryptoModel> GetBy_Date();
    }
}
