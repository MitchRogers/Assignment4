using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class Restaurant
    {
        public Restaurant(int ranking)
        {
            Rank = ranking;
        }

        [Required]
        public int Rank { get; }
        [Required]
        public string Name { get; set; }
        public string? FavoriteDish { get; set; }
        [Required]
        public string Address { get; set; }
        [Phone]
        public string? PhoneNumber { get; set; }
        public string? Website { get; set; } = "coming soon!";
        
        public static Restaurant[] TopFiveRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                Name = "Maria Bonita",
                FavoriteDish = "Carne Asada Burrito",
                Address = "167 Canyon Pkwy",
                PhoneNumber = "801-426-9328",
                Website = "mariabonitagrill.com"
            };

            Restaurant r2 = new Restaurant(2)
            {
                Name = "In-n-Out",
                FavoriteDish = "Double Double, Protein Style",
                Address = "350 E University Pkwy",
                PhoneNumber = "800-786-1000",
            };

            Restaurant r3 = new Restaurant(3)
            {
                Name = "Mo'Bettahs",
                FavoriteDish = "Mixed Plate, Teriyaki Chicken & Teriyaki Steak",
                Address = "1385 S State Street",
                PhoneNumber = "801-960-4616",
                Website = "mobettahs.com"
            };

            Restaurant r4 = new Restaurant(4)
            {
                Name = "Cafe Rio",
                FavoriteDish = "Sweet Pork Burrito, Enchilada Style",
                Address = "2244 N University Pkwy",
                PhoneNumber = "801-375-5133",
                Website = "caferio.com/locations/provo-1"
            };

            Restaurant r5 = new Restaurant(5)
            {
                Name = "Jersey Mikes",
                FavoriteDish = "Chipotle Cheese Steak",
                Address = "73 S State Street",
                PhoneNumber = "801-770-1299",
                Website = "jerseymikes.com/42006/orem-ut"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
