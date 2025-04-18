using Ñuke_Mapu_Pewma.Models;
using System.Collections.Generic;

namespace Ñuke_Mapu_Pewma.Services
{
    public interface IClienteRepositorio
    {
        Cliente GetById(int id);
        IEnumerable<Cliente> GetAll();
        void Add(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(Cliente cliente);
    }
}
