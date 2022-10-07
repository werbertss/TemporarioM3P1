using System.ComponentModel.DataAnnotations;

namespace DEVinCar.Infra.DTOs
{
     public class CityDTO
    {     
        [Required(ErrorMessage = "The name is required")]
        [MaxLength(255)]  
        public string Name { get; set; }

       
       
    }
}