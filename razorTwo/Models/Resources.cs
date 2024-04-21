using System.ComponentModel.DataAnnotations;

namespace razorTwo.Models
{
    public class Resources
    {
        public int Id { get; set; }

        [StringLength(60)]
        public string Name { get; set; }

        [StringLength(120)]
        public string Description { get; set; } = string.Empty;

        public int? Age { get; set; }

        public string? FavoriteDrink { get; set; }

        public string? FavoriteFood { get; set; }
    }
}
