﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.DataLayer.Entities.Maintenance
{
    public class DefectionReports
    {
        [Key]
        public int DefectionReportsId { get; set; }

        public string DefectionReportsImage { get; set; }

        [Required]
        public string Code { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        [Required]
        public string DocumentName { get; set; }
        public string Filename { get; set; }
    }
}
