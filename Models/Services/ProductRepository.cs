using ComputerShop.Data;
using ComputerShop.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace ComputerShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private ComputershopDbContext dbContext;
        public ProductRepository(ComputershopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return dbContext.Products;
        }

        public Product? GetProductDetail(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return dbContext.Products.OrderBy(p => Guid.NewGuid())  // ngẫu nhiên (hiệu quả hơn Random với EF)
                           .Take(3)
                           .ToList();
        }
       
    }
}
