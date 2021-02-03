using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace homework3.Models
{
    public class MovieModel 
    {
        [Required]
        public string category { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public long year { get; set; }

        [Required]
        public string director { get; set; }

        [Required]
        public string rating { get; set; }

        public string lentto { get; set; }

        public bool edited { get; set; }

        [MaxLength(25)]
        public string notes { get; set; }

    }
}
