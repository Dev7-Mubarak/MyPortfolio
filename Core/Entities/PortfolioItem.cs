namespace Core.Entities
{
    public class PortfolioItem : EntityBase
    {
        public string ProjectName { get; set; } = string.Empty!;
        public string Description { get; set; } = string.Empty!;
        public string ImageUrl { get; set; } = string.Empty!;
    }

}
