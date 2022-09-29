using Domain.Models;
using Services.Interfaces;
using System;

namespace Services
{
    public class TradeService : ITradeService
    {
        public string ClassifyTrade(Trade trade, DateTime referenceDate)
        {
            TimeSpan interval = new TimeSpan(trade.NextPaymentDate.Subtract(referenceDate).Ticks);

            if (interval.TotalDays < -30) return "EXPIRED";

            if (trade.Value > 1000000 && trade.ClientSector == "Private") return "HIGHRISK";

            if (trade.Value > 1000000 && trade.ClientSector == "Public") return "MEDIUMRISK";

            //if (trade.IsPoliticallyExposed) return "PEP";

            return "";
        }
    }
}
