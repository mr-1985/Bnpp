using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.Core.ViewModels
{
    public class StructureListViewModel
    {
        public int StructureId { get; set; }

        [Display(Name = "ConstructionName")]
        [Required(ErrorMessage = "please insert  {0}")]
        public string ConstructionName { get; set; }

        [Display(Name = "Azk")]
        [Required(ErrorMessage = "please insert  {0}")]
        public string Azk { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
