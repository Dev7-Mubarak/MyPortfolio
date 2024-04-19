namespace Web.ViewModels
{
    public class PortfolioViewModel
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; } = string.Empty!;
        public string Description { get; set; } = string.Empty!;
        public string ImageUrl { get; set; } = string.Empty!;
        public IFormFile File { get; set; }
    }
}
