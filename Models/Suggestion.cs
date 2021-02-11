using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class Suggestion
    {
        public string userName { get; set; }
        public string restaurantName { get; set; }
        public string FavoriteItem { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-]?([0-9]{3})[-]?([0-9]{4})$")]
        public string restaurantPhone { get; set; }
    }
}
