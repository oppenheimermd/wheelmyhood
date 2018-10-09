using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wheelmyhood.Models
{
    public class PlaceType
    {
        [Required]
        [Key]
        [StringLength(3, MinimumLength = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string PlaceTypeCode { get; set; }

        [Required]
        public string Title { get; set; }

        [StringLength(50)]
        public string Icon { get; set; }
    }
}
