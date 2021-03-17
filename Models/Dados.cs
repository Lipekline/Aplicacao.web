using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.web.Models
{
    public static class Dados
    {
        private static List<Cliente> LISTA_CLIENTES = new List<Cliente>();

        public static IEnumerable<Cliente> todos_os_dados()
        {
            return LISTA_CLIENTES;
        }

        public static void adicionarCliente(Cliente item)
        {
            //atribuir o id ao item
            item.id = 0;
            if( LISTA_CLIENTES.Count != 0)
            {
                item.id = LISTA_CLIENTES.Last<Cliente>().id + 1;
            }
            //logica de codigo... para analisar a devolução dos dados
            LISTA_CLIENTES.Add(item);
        }

        public static void deletarCliente(int id)
        {
            var item = LISTA_CLIENTES.First<Cliente>(i => i.id == id);
            LISTA_CLIENTES.Remove(item);
        }
    }

}
