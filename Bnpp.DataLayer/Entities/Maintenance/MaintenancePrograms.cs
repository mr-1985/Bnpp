﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.DataLayer.Entities.Maintenance
{
    public class MaintenancePrograms
    {


        [Key]
        public int ProgramsId { get; set; }

        [Required]
        public string MaintenanceType { get; set; }

        [Required]
        public string RR { get; set; }

        [Required]
        public string IR { get; set; }

        [Required]
        public string OVH { get; set; }
        

        public DateTime CreateDate { get; set; }

        public bool IsDelete { get; set; }
    }
}
