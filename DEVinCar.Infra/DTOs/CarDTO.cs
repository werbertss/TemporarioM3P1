﻿using System.ComponentModel.DataAnnotations;

namespace DEVinCar.Infra.DTOs
{
    public class CarDTO
    {
        [Required(ErrorMessage = "The name is required")]
        [MaxLength(255)]
        public string Name { get; set; }
        public decimal SuggestedPrice { get; set; }

    }
}
