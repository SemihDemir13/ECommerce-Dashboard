using SignalR.EntityLayer.Entities;


namespace SignalR.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();

        int TProductCount();
        int TProductByCategoryNameDrink();
        int TProductByCategoryNameHamburger();
        decimal TProductPriveAvg();
        string TProductNameByMinPrice();
        string TProductNameByMaxPrice();



    }
}
