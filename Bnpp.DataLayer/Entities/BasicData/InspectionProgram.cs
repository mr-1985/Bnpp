using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.DataLayer.Entities.BasicData
{
    public class InspectionProgram
    {
        [Key]
        public int InspectionProgramId { get; set; }


        [Required]
        public string Code { get; set; }

        [Required]
        public string EquipmentDocument { get; set; }

        [Required]
        public string TestMethod { get; set; }

        [Required]
        public string TechnicalDocuments { get; set; }

        [Required]
        public string ScopeofInspection  { get; set; }

        [Required]
        public string PeriodofInspection { get; set; }

        [Required]
        public string CategoryofWeldedjoints { get; set; }

        [Required]
        public string Note { get; set; }

        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
