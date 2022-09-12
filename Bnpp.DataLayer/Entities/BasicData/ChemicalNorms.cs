using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.DataLayer.Entities.BasicData
{
    public class ChemicalNorms
    {
        [Key]
        public int ChemicalId { get; set; }


        [Required]
        public string IndexDescription { get; set; }

        [Required]
        public string Unit { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public string Limit { get; set; }


        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
