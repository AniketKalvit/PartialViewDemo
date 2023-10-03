namespace PartialViewDemo.Models
{
    public class ProductCRUD
    {
        private readonly ApplicationDbContext db;
        public ProductCRUD(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Product> GetProducts()
        {
            return db.Products.ToList();
        }
    }
}
