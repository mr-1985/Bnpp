using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.DataLayer.Entities.BasicData
{
    public class GeneralData
    {
        [Key]
        public int  GeneralId { get; set; }

        public string DesignationOfParameters { get; set; }
        public string Value { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
