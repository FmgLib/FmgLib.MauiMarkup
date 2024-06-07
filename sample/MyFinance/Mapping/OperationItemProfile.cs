namespace MyFinance.Mapping;

public class OperationItemProfile : Profile
{
    public OperationItemProfile()
    {
        CreateMaps();
    }

    private void CreateMaps()
    {
        CreateMap<OperationItem, OperationItemsVM>()
            .ForMember(dist => dist.Date, opt => opt.MapFrom(src => src.Date.ToString("dd.MM.yyyy HH:mm")))
            .ForMember(dist => dist.Color, opt => opt.MapFrom(src => src.IsIncome ? Green : Red))
            .ForMember(dist => dist.Icon, opt => opt.MapFrom(src => src.IsIncome ? "profits.png" : "loss.png"))
            .ForMember(dist => dist.Amount, opt => opt.MapFrom(src => $"{src.Amount} ₺"));
    }
}
