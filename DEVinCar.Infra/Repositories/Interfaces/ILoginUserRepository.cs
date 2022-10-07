using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinCar.Infra.Repositories.Interfaces
{
    public interface ILoginRepository
    {
        public void ObterPorEmailESenha<T>(T entity) where T : class;
    }
}
