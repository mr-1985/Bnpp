using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.DataLayer.Entities.ONOFF
{
    public class ChangeState
    {
        [Key]
        public int ChangeStateId { get; set; }



        public string Description { get; set; }

        public DateTime ChangeStateDate { get; set; }

        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }

        public ChangingInState ChangingInState { get; set; }
    }
}
