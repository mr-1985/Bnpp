using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Bnpp.DataLayer.Entities.BasicData
{
    public class GeneralData
    {
        [Key]
        public int  GeneralId { get; set; }

        [Required]
        public string DesignationOfParameters { get; set; }

        [Required]
        public string Value { get; set; }

        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
