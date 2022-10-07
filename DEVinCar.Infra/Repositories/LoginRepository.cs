using DEVinCar.Infra.DTOs;
using DEVinCar.Infra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.Infra.Repositories
{
    public static class LoginRepository
    {

        private static List<User> usuariosCadastrados = new List<User>
        {
            new User
            {
                Id = 102,
                Email = "Pedro@email.com",
                Password = "12345",
                Name = "Pedro",
                Role = "admin",
                BirthDate = new DateTime(2001, 06, 07)
            }
        };

        public static User? VerificarEmailESenha(UserLoginDTO dto)
        {
            var user = usuariosCadastrados.FirstOrDefault
                (
                    x => x.Email == dto.Email && x.Password == dto.Password
                );
            return user;
        }
    }
}
