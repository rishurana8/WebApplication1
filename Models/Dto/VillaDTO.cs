﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Dto
{
    public class VillaDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public int Occupancy { get; set; }

        public int Sqft { get; set; }

    }
}
