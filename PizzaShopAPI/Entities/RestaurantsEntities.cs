using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PizzaShopAPI.Entities
{
    public class RestaurantsEntities
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(100)]
        public string? name { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
    }
}
