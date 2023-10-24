namespace ShopApplication.Services
{
    public interface IReportProduct
    {

        public List<IReportProduct> getReportProducts(Guid productId);
    }
}
