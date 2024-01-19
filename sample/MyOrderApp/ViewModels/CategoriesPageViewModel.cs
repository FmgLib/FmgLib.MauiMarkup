using AutoMapper;
using CommunityToolkit.Maui.Core.Extensions;
using System.Collections.ObjectModel;

namespace MyOrderApp.ViewModels;

public partial class CategoriesPageViewModel : BaseViewModel
{
    [ObservableProperty]
    private ObservableCollection<CategoryVM> _categories;

    private readonly ICategoryRepository _categoryRepository;
    private readonly ISubCategoryRepository _subCategoryRepository;
    private readonly IMapper _mapper;

    public CategoriesPageViewModel(ICategoryRepository categoryRepository, 
        ISubCategoryRepository subCategoryRepository, 
        IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _subCategoryRepository = subCategoryRepository;
        _mapper = mapper;

        GetInfo();
    }

    private void GetInfo()
    {
        var categories = _categoryRepository.GetAll(x => x.IsActive);
        var result = _mapper.Map<ObservableCollection<CategoryVM>>(categories);

        foreach (var item in result)
        {
            var sc = _subCategoryRepository.GetAll(x => x.IsActive && x.CategoryId == item.Id);
            item.SubCategories = _mapper.Map<List<SubCategoryVM>>(sc);
        }

        Categories = result;
    }
}
