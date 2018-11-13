using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WheelMyHood.Models
{
    public class Guide
    {
        public Guide()
        {
            this.TimeStamp = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [StringLength(125)]
        public string Title { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser Author { get; set; }

        [Required]
        [ForeignKey("City")]
        public string CityCode { get; set; }

        [StringLength(400)]
        public string GuideAbout { get; set; }

        public DateTime TimeStamp { get; set; }

        public City City { get; set; }


        public ICollection<Neighbourhood> Neighbourhood { get; set; }
    }
}
