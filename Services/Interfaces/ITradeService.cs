using Domain.Models;
using System;

namespace Services.Interfaces
{
    public interface ITradeService
    {
        public string ClassifyTrade(Trade trade, DateTime referenceDate);
    }
}
