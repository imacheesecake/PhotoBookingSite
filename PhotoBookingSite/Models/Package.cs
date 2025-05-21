namespace PhotoBookingSite.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DurationMinutes { get; set; }
        public decimal Price { get; set; }
        public int MaxBackdrops { get; set; }
        public int EditedPhotos { get; set; }
    }
}
