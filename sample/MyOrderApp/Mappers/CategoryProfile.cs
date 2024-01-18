using AutoMapper;

namespace MyOrderApp.Mappers;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMaps();
    }

    private void CreateMaps()
    {
        CreateMap<SubCategory, SubCategoryVM>()
            .ForMember(dist => dist.Icon, opt => opt.MapFrom(src => "dotnet_bot.svg"));

        CreateMap<Category, CategoryVM>();
    }
}
