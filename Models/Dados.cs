using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.web.Models
{
    public static class Dados
    {
        private static List<Cliente> LISTA_CLIENTES = new List<Cliente>();

        //devolve todos os dados da lista
       //public static IEnumerable<Cliente> todos_os_dados
       // {
       //     get
       //     {
       //         return LISTA_CLIENTES;
       //     }
       // }

        public static IEnumerable<Cliente> todos_os_dados()
        {
            return LISTA_CLIENTES;
        }

        public static void adicionarCliente(Cliente item)
        {
            //logica de codigo... para analisar a devolução dos dados
            LISTA_CLIENTES.Add(item);
        }
    }

}
