using HandsOnAPIWIthEF.Entities;

namespace HandsOnAPIWIthEF.Repositories
{
    public class ProductRepository:IProductRepository
    {
        //create object to MyCotext
        private readonly MyContext context;
        public ProductRepository()
        {
            context = new MyContext();
        }
        public void Add(Product product)
        {
            try
            {
                context.Products.Add(product); //add new product to the table
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
          try
            {
                var item=context.Products.Find(id);
                context.Products.Remove(item);//item remove from the product table
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList(); //return all products
        }

        public Product GetById(int id)
        {
            var item = context.Products.Find(id);
            //var item=context.Products.SingleOrDefault(i=>i.Id==id);
            return item;
        }

        public void Update(Product product)
        {
            context.Products.Update(product); //record updated from product table
            context.SaveChanges();
        }
    }
}
