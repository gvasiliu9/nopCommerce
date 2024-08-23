using Microsoft.AspNetCore.Mvc;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;

namespace Nop.Web.Components;

public class FeaturedProductsViewComponent : NopViewComponent
{
    private readonly ICatalogModelFactory _catalogModelFactory;

    public FeaturedProductsViewComponent(ICatalogModelFactory catalogModelFactory)
    {
        _catalogModelFactory = catalogModelFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var model = await _catalogModelFactory.PrepareFeaturedProductsModelAsync();

        if (!model.Products?.Any() ?? true)
            return Content("");

        return View(model);
    }
}
