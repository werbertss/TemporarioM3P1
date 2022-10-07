using System.ComponentModel.DataAnnotations;
using DEVinCar.Infra.Annotations;

namespace DEVinCar.Infra.DTOs
{
    public class UserLoginDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}