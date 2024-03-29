﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_g02efy22.Models
{
    public class MovieResponse
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public byte Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        public char Notes { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
