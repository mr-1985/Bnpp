using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.DataLayer.Entities.BasicData
{
    public class Sensors
    {
        [Key]
        public int SensorId { get; set; }


        [Required]
        public string Parametertomeasure { get; set; }

        [Required]
        public string AKZ { get; set; }

        [Required]
        public string Numberofsignals { get; set; }

        [Required]
        public string KKS { get; set; }

        [Required]
        public string Quantity { get; set; }


        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
