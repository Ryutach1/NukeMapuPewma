using Ñuke_Mapu_Pewma.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ñuke_Mapu_Pewma.Services
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly List<Cliente> _clientes = new List<Cliente>();

        public Cliente GetById(int id)
        {
            return _clientes.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _clientes;
        }

        public void Add(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        public void Update(Cliente cliente)
        {
            // Lógica de actualización
        }

        public void Delete(Cliente cliente)
        {
            _clientes.Remove(cliente);
        }
    }
}
