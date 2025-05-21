namespace PhotoBookingSite.Models
{
    public class Backdrop
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public string? Description { get; set; }  // Optional, e.g. "Bright white seamless paper"
    }
}
