using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.DataLayer.Entities.BasicData
{
    public class DesignData
    {
        [Key]
        public int DesignId { get; set; }


        [Required]
        public string ParameterName { get; set; }

        [Required]
        public string unit { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public string Description { get; set; }


        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
