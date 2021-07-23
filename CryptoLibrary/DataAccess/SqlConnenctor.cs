using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using CryptoLibrary;
using System.Linq;

namespace CryptoLibrary
{
    
    class SqlConnenctor : IDataConnection
    {

        string C = "Crypto";
        public BuyCryptoModel BuyCrypto(BuyCryptoModel model)
        {
            if (model.Name == "Bitcoin")
            {
                model.CurrencyTypeId = 1;
            }
            if (model.Name == "Bitcoin Cash")
            {
                model.CurrencyTypeId = 2;
            }
            if (model.Name == "Litecoin")
            {
                model.CurrencyTypeId = 3;
            }
            if (model.Name == "Ethereum")
            {
                model.CurrencyTypeId = 4;
            }

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(C)))
            {
                var ParameterOrders = new DynamicParameters();
                ParameterOrders.Add("@CurrencyTypeId", model.CurrencyTypeId);
                ParameterOrders.Add("@ExchangeRate", model.ExchangeRate);
                ParameterOrders.Add("@AmountUSD", model.USDBought);
                ParameterOrders.Add("@Fee", model.Fee);
                ParameterOrders.Add("@Date", model.Date);
                ParameterOrders.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                ParameterOrders.Add("@IsBuying", model.ISBuying);

                connection.Execute("dbo.spCurrencyOrders_Insert", ParameterOrders, commandType: CommandType.StoredProcedure);

                model.Id = ParameterOrders.Get<Int32>("@Id");

                return model;
            }
        }

        public List<BuyCryptoModel> GetBuyCrypto_All()
        {
            List<BuyCryptoModel> Output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(C)))
            {
                Output = connection.Query<BuyCryptoModel>("dbo.SpCurrencyOrders_GetAll").ToList();
            }
            return Output;
        }
        public SellCryptoModel SellCrypto(SellCryptoModel model)
        {
            if (model.Name == "Bitcoin")
            {
                model.CurrencyTypeId = 1;
            }
            if (model.Name == "Bitcoin Cash")
            {
                model.CurrencyTypeId = 2;
            }
            if (model.Name == "Litecoin")
            {
                model.CurrencyTypeId = 3;
            }
            if (model.Name == "Ethereum")
            {
                model.CurrencyTypeId = 4;
            }

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(C)))
            {
                var ParameterOrders = new DynamicParameters();
                ParameterOrders.Add("@CurrencyTypeId", model.CurrencyTypeId);
                ParameterOrders.Add("@ExchangeRate", model.ExchangeRate);
                ParameterOrders.Add("@AmountUSD", model.USDBought);
                ParameterOrders.Add("@Fee", model.Fee);
                ParameterOrders.Add("@Date", model.Date);
                ParameterOrders.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                ParameterOrders.Add("@IsBuying", model.ISBuying);

                connection.Execute("dbo.spCurrencyOrders_Insert", ParameterOrders, commandType:CommandType.StoredProcedure);

                model.Id = ParameterOrders.Get<Int32>("@Id");

                return model;
            }
        }
    }
}
