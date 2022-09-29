using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Models;
using Services.Interfaces;
using System;

namespace Application.AppServices
{
    public class TradeAppService : ITradeAppService
    {
        private readonly ITradeService _tradeService;
        private readonly IMapper _mapper;

        public TradeAppService(ITradeService tradeService, IMapper mapper)
        {
            _tradeService = tradeService;
            _mapper = mapper;
        }
        public string ClassifyTrade(TradeViewModel tradeViewModel, DateTime referenceDate)
        {
            var trade = _mapper.Map<Trade>(tradeViewModel);
            return _tradeService.ClassifyTrade(trade, referenceDate);
        }
    }
}
