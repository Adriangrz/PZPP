using System.ComponentModel.DataAnnotations;

namespace EquipmentManagement.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        [Display(Name = "Typ")]
        public string Type { get; set; }
        [Display(Name = "Opis")]
        public string Desc { get; set; }
        [Display(Name = "Cena")]
        public decimal Price { get; set; }
        [Display(Name = "Dostępność")]
        public bool Availability { get; set; }
        [Display(Name = "Lokalizacja")]
        public string Location { get; set; }
    }
}
