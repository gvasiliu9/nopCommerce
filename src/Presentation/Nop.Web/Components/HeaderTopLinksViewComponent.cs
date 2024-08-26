using Microsoft.AspNetCore.Mvc;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;

namespace Nop.Web.Components;

public class HeaderTopLinksViewComponent : NopViewComponent
{
    protected readonly ICommonModelFactory _commonModelFactory;

    public HeaderTopLinksViewComponent(ICommonModelFactory commonModelFactory)
    {
        _commonModelFactory = commonModelFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var model = await _commonModelFactory.PrepareHeaderTopLinksModelAsync();
        return View(model);
    }
}
