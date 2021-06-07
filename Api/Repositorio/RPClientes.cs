using System.Collections.Generic;
using System.Linq;
using APIREST.Models;

namespace APIREST.Repositorio
{
    public class RPClientes
    {
        public static List<Cliente> _listaClientes = new List<Cliente>()
        {
            new Cliente() { Id = 1, Nombre = "Jorge" , Apellido = "Rodriguez" },
            new Cliente() { Id = 2, Nombre = "Luciano" , Apellido = "Loverso" },
            new Cliente() { Id = 3, Nombre = "Vanina" , Apellido = "Gutierrez" }
        };
        public IEnumerable<Cliente> ObtenerClientes()
        {
            return _listaClientes;
        }

        public Cliente ObtenerCliente(int id)
        {
            var cliente = _listaClientes.Where(cli => cli.Id == id);

            return cliente.FirstOrDefault();
        }

        public void Agregar(Cliente nuevoCliente)
        {
            _listaClientes.Add(nuevoCliente);
        }
    }
}
