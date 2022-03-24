using EquipmentManagement.Models;

namespace EquipmentManagement.Data
{
    public class AplicationDbInitializer
    {
        private readonly AplicationDbContext _context;
        public AplicationDbInitializer(AplicationDbContext aplicationDbContext)
        {
            this._context = aplicationDbContext;
        }
        public void Seed()
        {
            if (!_context.Products.Any()) CreateProducts(_context);
        }
        private void CreateProducts(AplicationDbContext aplicationDbContext)
        {
            var product1 = new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Opony letnie Targum",
                Type = "opony",
                Desc = "nowe opony firmy targum",
                Price = 450,
                Availability = true
            };
            var product2 = new Product()
            {
                Id = Guid.NewGuid(),
                Name = "felga stalowa Ducato",
                Type = "felga",
                Desc = "nowe felgi firmy Ducato",
                Price = 250,
                Availability = true
            };
            var product3 = new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Opony letnie Goodride",
                Type = "opony",
                Desc = "nowe opony firmy Goodride",
                Price = 550,
                Availability = true
            };
            aplicationDbContext.Products.AddRange(product1, product2, product3);
            aplicationDbContext.SaveChanges();
        }
    }
}
