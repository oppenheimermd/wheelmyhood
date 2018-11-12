using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WheelMyHood.Models
{
    public class Neighbourhood
    {
        [Key]
        public int Id { get; set; }

        [StringLength(125)]
        public string Title { get; set; }

        [StringLength(300)]
        public string About { get; set; } = string.Empty;

        [ForeignKey("City")]
        public string CityCode { get; set; }

        public City City { get; set; }

        //  Author Property
        //  MAP PROPERTIES LAT/LONG

        public ICollection<Place> Places { get; set; }
    }
}
