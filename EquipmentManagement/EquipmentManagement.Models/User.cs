namespace EquipmentManagement.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string UserType { get; set; }
    }
}