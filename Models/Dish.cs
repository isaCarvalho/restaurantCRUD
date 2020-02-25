using System;
using System.ComponentModel.DataAnnotations;

namespace restaurantCRUD.Models
{
    public class Dish
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}