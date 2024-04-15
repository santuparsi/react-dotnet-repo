using HandsOnAPIWIthEF.Entities;

namespace HandsOnAPIWIthEF.Repositories
{
    public interface IProductRepository
    {
        //write functionalities to wrt Product table
        void Add(Product product); //Add Product
        void Update(Product product); // Update Product By Id
        void Delete(int id); //Delete Product By Id
        List<Product> GetAll(); //Get All Products
        Product GetById(int id); //Get Product by ProductId
    }
}
