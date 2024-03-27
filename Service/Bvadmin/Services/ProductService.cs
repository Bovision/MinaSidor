using AutoMapper;
using Core.DataCore;
using Data;
using Microsoft.EntityFrameworkCore;
using Service.Bvadmin.Interfaces;

namespace Service.Bvadmin.Services
    {
    public class ProductService : Interfaces.IProduct
        {
        private ApplicationDbContext _ApplicationDbContext;

        public ProductService(ApplicationDbContext applicationDbContext)
            {
            _ApplicationDbContext= applicationDbContext;
            }
        public async Task<bool> createProduct(Product product)
            {
            try { 
            await _ApplicationDbContext.Products.AddAsync(product);
            await _ApplicationDbContext.SaveChangesAsync();
            return true;
                }
            catch (Exception ex)
                {
                return false;
                }

            }

        public async Task<bool> deleteProduct(int productId)
            {
            var Product = await _ApplicationDbContext.Products.FindAsync(productId);
            if (Product != null)
                {
                _ApplicationDbContext.Products.Remove(Product);
                await _ApplicationDbContext.SaveChangesAsync();
                return true;
                }
            return false;

            }

        public async Task<Product> FindProduct(Param SearchParam)
            {
            return await _ApplicationDbContext.Products.FindAsync(SearchParam);

            }

        public async Task<Product> getProduct(int productId)
            {
            return await _ApplicationDbContext.Products.FindAsync(productId);
            }

        public async Task<List<Product>> getProducts()
            {
            return await _ApplicationDbContext.Products.ToListAsync();
            }

        public async Task<bool> updateProduct(Product product)
            {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Product, Product>(); // Customer är den typ som ska mappas
            });

            // Skapa en IMapper-instans med hjälp av konfigurationen
            var mapper = new Mapper(config);
            var Product = await _ApplicationDbContext.Products.FindAsync(product.Id);
            mapper.Map(product, Product);
            if (Product != null)
                {
                _ApplicationDbContext.Products.Update(Product);
                await _ApplicationDbContext.SaveChangesAsync();
                return true;
                }
            return false;
            }
        }
    }
