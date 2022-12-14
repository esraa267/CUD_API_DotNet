using CRUD_Api.CRUD.EF.Data;
using CRUD_Api.Dto;
using CRUD_Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CRUD_Api.CRUD.BLL
{
    public class ProductRepo : IProductRepo
    {
        private readonly ApplicationDBContext _context;
        public ProductRepo(ApplicationDBContext  context)
        {

            _context = context; 
                
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            
            return await _context.products!.OrderBy(g=>g.Name).ToListAsync();
        }
      public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.products!.SingleOrDefaultAsync(p=>p.Id==id);
        }
        public async Task<Product> CheckExists(Expression< Func<Product,bool>> expression)
        {
            return await _context.products!.Where(expression!).FirstOrDefaultAsync();
        }
        public async Task AddAsync(ProductDto proudct)
        {
            var Product = new Product
            {
                Name = proudct.Name!,
                Price = proudct.Price!,
                Description = proudct.Description!
            };
            await _context.products!.AddAsync(Product);
            
            await _context.SaveChangesAsync();


        

        }
        public async Task< Product> Update(Product product)
        {
            _context.products!.Update(product);
           await _context.SaveChangesAsync();
            return product;
          
        }

        public async Task<Product> Delete(Product product)
        {
            _context.Remove(product);
          await  _context.SaveChangesAsync();
            return product;
        }

      
    }
}
