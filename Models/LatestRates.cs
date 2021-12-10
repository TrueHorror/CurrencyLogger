using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyLogger.Models
{
    public class LatestRates
    {
        public int Id { get; set; }
        public string Currency { get; set; }
        public double Rate { get; set; }
        public string Date { get; set; }
    }
}
