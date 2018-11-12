using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WheelMyHood.Models
{
    public class Region
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [StringLength(4, MinimumLength = 4)]
        public string RegionCode { get; set; }
        [Required]
        public string ContinentName { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
