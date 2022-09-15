﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.DataLayer.Entities.AgeingMechanism
{
    public class MechanismDocuments
    {
        [Key]
        public int MechanismDocumentsId { get; set; }

        public string MechanismDocumentsImage { get; set; }

        [Required]
        public string Code { get; set; }

        public bool IsDelete { get; set; }

        public DateTime CreateDate { get; set; }
        [Required]
        public string DocumentName { get; set; }

        public string Filename { get; set; }
    }
}
