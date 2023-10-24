using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using ShopApplication.Entity;
using ShopApplication.Models;

namespace ShopApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReportController : ControllerBase
    {


        private readonly ApplicationDbContext _context;

        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Authorize]
        public List<ReportProducts> reportProducts([FromForm] string? sortType)
        {
            List<ReportProducts> ReportProducts = new List<ReportProducts>();

            foreach (var Product in _context.Products.ToList())
            {
                var ProductName = Product.Name;
                var price = Product.ProductPrice;
                var categoryName = _context.ProductCategory.Where(e => e.Id == Product.ProductCategoryId).FirstOrDefault().Name;
                var exits = _context.ProductReceipt.Where(e => e.ProductId == Product.Id).Select(e => e.ProductNumber).ToArray();
                var removes = _context.ProductTransfer.Where(e => e.ProductId == Product.Id).Select(e => e.ProductNumber).ToArray();
                var exitsNum = exits.Sum();
                var removesNum = removes.Sum();

                ReportProducts.Add(new Models.ReportProducts()
                {
                    ProductName = ProductName,
                    CategoryName = categoryName,
                    Quantity = exitsNum - removesNum,
                    Price = price,

                });
            }

            if (sortType != null && sortType == "price")
            {
                return ReportProducts.OrderByDescending(e => e.Price).ToList();
            }
            return ReportProducts;
            //return _context.Products.Where(e => e.Id == pid).FirstOrDefault();
        }


    }
}
