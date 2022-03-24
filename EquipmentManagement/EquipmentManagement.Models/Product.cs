namespace EquipmentManagement.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Desc{ get; set; }
        public string Cost { get; set; }
        public string SellingPrice { get; set; }
    }
}