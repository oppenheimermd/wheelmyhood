using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WheelMyHood.Models
{
    public class City
    {
        [Required]
        [Key]
        [StringLength(4, MinimumLength = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CityCode { get; set; }

        [Required]
        [StringLength(100)]
        public string CityName { get; set; }

        [StringLength(300)] public string About { get; set; } = string.Empty;

        [Required]
        [ForeignKey("Region")]
        public string ContinentCode { get; set; }

        public Region Region { get; set; }
        public ICollection<Neighbourhood> Neighbourhood { get; set; }
    }
}
