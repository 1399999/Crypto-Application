using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace CryptoLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }
        public static void InitializeConnections(DataBaseType Db)
        {
            if (Db == DataBaseType.Sql)
            {
                SqlConnenctor sql = new SqlConnenctor();
                Connections = sql;
            }
            else if (Db == DataBaseType.Error) 
            { 
                
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
