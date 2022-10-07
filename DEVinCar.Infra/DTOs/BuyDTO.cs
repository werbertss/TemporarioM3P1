using System;
using System.ComponentModel.DataAnnotations;

namespace DEVinCar.Infra.DTOs
{
    public class BuyDTO
    {
        [Required(ErrorMessage = "The SelleId is required.")]
        public int SellerId{ get; set; }
        public DateTime SaleDate { get; set; }
    }
}


