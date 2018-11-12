using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WheelMyHood.Models
{
    public class Place
    {
        [Key]
        public int Id { get; set; }

        [StringLength(125)]
        public string Title { get; set; }

        [StringLength(150)]
        public string Address { get; set; }

        [StringLength(300)]
        public string About { get; set; }

        [StringLength(256)]
        public string Url { get; set; }

        public bool AccessibleToilet { get; set; } = false;

        [Required]
        [ForeignKey("Neighbourhood")]
        public int NeighbourhoodId { get; set; }

        [Required]
        [ForeignKey("PlaceType")]
        public string PlaceTypeCodeId { get; set; }

        public Neighbourhood Neighbourhood { get; set; }
        public PlaceType PlaceType { get; set; }

        //  LAT / LONG

        public ICollection<PlacePhoto> Images { get; set; }
    }
}
