namespace Core.Entities
{
    public class Owner : EntityBase
    {
        public string FullName { get; set; } = string.Empty!;
        public string Profil { get; set; } = string.Empty!;
        public string Avator { get; set; } = string.Empty!;
        public Guid? AddressId { get; set; } = default!;
        public Address Address { get; set; } = default!;
    }

}