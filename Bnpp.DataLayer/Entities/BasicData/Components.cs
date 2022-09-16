using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.DataLayer.Entities.BasicData
{
    public class Components
    {
        [Key]
        public int ComponentId { get; set; }


        [Required]
        public string Item { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        public string Serial { get; set; }

        [Required]
        public string Diameter { get; set; }

        [Required]
        public string Thickness { get; set; }

        [Required]
        public string Length { get; set; }
        [Required]
        public string MaterialGrade { get; set; }

        [Required]
        public string ClassofSafety { get; set; }

        [Required]
        public string ClassificationDesignation { get; set; }

        [Required]
        public string Group { get; set; }

        [Required]
        public string SeismicCategory { get; set; }

        public string ComponentsImage { get; set; }

        public string Filename { get; set; }

        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
