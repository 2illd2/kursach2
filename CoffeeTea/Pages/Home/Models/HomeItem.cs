namespace CoffeeTea.Pages.Home.Models
{
    public class HomeItem
    {
        public List<CardItem> Cards { get; set; } = new();
    }

    public class CardItem
    {
        public string Title { get; set; } = default!;
        public string Text { get; set; } = default!;
        public string? ImageUrl { get; set; }
        public string? Link { get; set; }
        public string? Badge { get; set; } 
    }
}
