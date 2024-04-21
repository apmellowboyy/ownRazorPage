using Microsoft.EntityFrameworkCore;
using razorTwo.Data;

namespace razorTwo.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new razorTwoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<razorTwoContext>>()))

                if (context == null || context.Resources == null)
                {
                    if (context == null || context.Resources == null)
                    {
                        throw new ArgumentException("Null webApplication2Context");
                    }
                    if (context.Resources.Any())
                    {
                        return;
                    }
                    context.Resources.AddRange(
                        new Resources
                        {
                            Id = 1,
                            Name = "Johnny",
                            Description ="",
                            Age = 22,
                            FavoriteDrink = "Sprite",
                            FavoriteFood = "Pizza"
                        },

                        new Resources
                        {
                            Id = 3,
                            Name = "Jeremy",
                            Description ="",
                            Age = 21,
                            FavoriteDrink = "Coke",
                            FavoriteFood = "Tacos"
                        },
                        new Resources
                        {
                            Id = 2,
                            Name = "Denji",
                            Description ="",
                            Age = 19,
                            FavoriteDrink = "Water",
                            FavoriteFood = "Chili"
                        },

                        new Resources
                        {
                            Id = 4,
                            Name = "Shelby",
                            Description ="",
                            Age = 23,
                            FavoriteDrink = "Orange Juice",
                            FavoriteFood = "Burrito"
                        }
                        );
                    context.SaveChanges();
                }
            }
        }
    }
