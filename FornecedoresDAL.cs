using Cadastro_de_Fornecedores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Fornecedores
{
    public class FornecedoresDAL
    {
        Context Context = new Context();

        public void Salvar(Fornecedor fornecedor)
        {
            try
            {
                Context.fornecedores.Add(fornecedor);
                Context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro ao adicionar o fornecedor na base de dados. Erro: {0}", e);
            }
        }

    }
}
