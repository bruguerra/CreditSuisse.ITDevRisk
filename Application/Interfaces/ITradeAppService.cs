using Application.ViewModels;
using System;

namespace Application.Interfaces
{
    public interface ITradeAppService
    {
        public string ClassifyTrade(TradeViewModel trade, DateTime referenceDate);
    }
}
