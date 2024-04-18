namespace Core.Entities
{
    public class Address : EntityBase
    {
        public string Street { get; set; } = string.Empty!;
        public string City { get; set; } = string.Empty!;
        public string Number { get; set; } = string.Empty!;
    }

}
