namespace Nop.Web.Models.Catalog;

public class FeaturedProductsModel
{
    /// <summary>
    /// Featured products by category
    /// </summary>
    public Dictionary<string, IEnumerable<ProductOverviewModel>> Products { get; set; }
}