using System.ComponentModel.DataAnnotations;

namespace WheelMyHood.Models
{
    public class PlacePhoto
    {
        [Key]
        public int Id { get; set; }

        [StringLength(256)]
        public string Url { get; set; }

        public Place Place { get; set; }
    }
}
