using System;
using System.ComponentModel.DataAnnotations;

namespace PhotoBookingSite.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string ClientName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Session Date & Time")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Selected Package")]
        public string Package { get; set; }

        [Display(Name = "Backdrop Color")]
        public string BackdropColor { get; set; }

        [Display(Name = "Additional Notes")]
        public string? Notes { get; set; }
    }
}
