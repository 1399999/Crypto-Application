using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoLibrary
{
    public class BaseCryptoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public decimal USDBought { get; set; }
        public DateTime Date { get; set; }
        public int CurrencyTypeId { get; set; }
        public decimal ExchangeRate { get; set; }
        public int ISBuying { get; set; }
        public string YouColumn { get; set; }
    }
}
