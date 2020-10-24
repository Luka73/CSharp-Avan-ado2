using Aula03.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Interfaces
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        List<Cliente> SelectAll(string nome);
    }
}
