using AutoMapper;

namespace MyOrderApp.Mappers;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMaps();
    }

    private void CreateMaps()
    {
        CreateMap<Product, ProductVM>()
            .ForMember(dist => dist.Image, opt => opt.MapFrom(src => "dotnet_bot.svg"))
            .ForMember(dist => dist.DiscountRate, opt => opt.MapFrom(src => $"-{src.DiscountRate}%"))
            .ForMember(dist => dist.Price, opt => opt.MapFrom(src => src.Price.ToString("0 ₺")))
            .ForMember(dist => dist.DiscountPrice, opt => opt.MapFrom(src => (src.Price != default! ? (src.Price-(src.Price*src.DiscountRate/100)).ToString() : "0") +" ₺"));
    }
}
