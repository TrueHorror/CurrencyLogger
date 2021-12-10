using CurrencyLogger.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CurrencyLogger
{
    public interface IDatabaseContext
    {
        DbSet<LatestRates> LatestRates { get; set; }

        Task<int> SaveChanges();
    }
}