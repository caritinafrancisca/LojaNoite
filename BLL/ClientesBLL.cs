using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace BLL
{
    public class ClientesBLL
    {
        public void Incluir(ClienteInformation cliente)
        {
            // o nome do cliente é obrigatório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("o nome do cliente é obrigatorio");

            }
            // Email sempre em minúsculo
            cliente.Email = cliente.Email.ToLower();
            //Se tudo Ok, chama a rotina de inserção
            ClientesDAL obj = new ClientesDAL();
            obj.incluir(cliente);

        }   
       public void Alterar(ClienteInformation cliente)
        {
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatorio");
            }
            cliente.Email = cliente.Email.ToLower();
            ClientesDAL obj = new ClientesDAL();
            obj.Alterar(cliente);

        }
        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("selecione um cliente antes de excluí_lo");
            }
            ClientesDAL obj = new ClientesDAL();
            obj.Excluir(codigo);
        }   
    }
}
