using Application.ViewModels;
using AutoMapper;
using Domain.Models;

namespace Application.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            #region ViewModelToDomain

            CreateMap<TradeViewModel, Trade>()
                .ForMember(dest => dest._value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest._clientSector, opt => opt.MapFrom(src => src.ClientSector))
                .ForMember(dest => dest._nextPaymentDate, opt => opt.MapFrom(src => src.NextPaymentDate));

            #endregion

            #region DomainToViewModel

            CreateMap<Trade, TradeViewModel>();

            #endregion
        }
    }
}
