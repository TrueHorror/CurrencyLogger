using CurrencyLogger.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyLogger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LatestRatesController : ControllerBase
    {
        private IDatabaseContext _context;
        public LatestRatesController(IDatabaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(LatestRates latestRates)
        {
            _context.LatestRates.Add(latestRates);
            await _context.SaveChanges();
            return Ok(latestRates.Id);
        }
    }
}
