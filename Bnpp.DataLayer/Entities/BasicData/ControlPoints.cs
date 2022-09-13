using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.DataLayer.Entities.BasicData
{
    public class ControlPoints
    {
        [Key]
        public int PointId { get; set; }


        [Required]
        public string Parameter { get; set; }

        [Required]
        public string NumberCheckPoints { get; set; }

        [Required]
        public string MeasurementRange { get; set; }

        [Required]
        public string Remarks { get; set; }


        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
