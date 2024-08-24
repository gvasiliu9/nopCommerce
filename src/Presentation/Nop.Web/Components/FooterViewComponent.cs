using Microsoft.AspNetCore.Mvc;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;

namespace Nop.Web.Components;

public partial class FooterViewComponent : NopViewComponent
{
    protected readonly ICommonModelFactory _commonModelFactory;

    protected readonly ICatalogModelFactory _catalogModelFactory;

    public FooterViewComponent(ICommonModelFactory commonModelFactory, ICatalogModelFactory catalogModelFactory)
    {
        _commonModelFactory = commonModelFactory;
        _catalogModelFactory = catalogModelFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var topMenu = await _catalogModelFactory.PrepareTopMenuModelAsync();
        var model = await _commonModelFactory.PrepareFooterModelAsync();

        model.RecommendedCategories = topMenu.Categories;

        return View(model);
    }
}