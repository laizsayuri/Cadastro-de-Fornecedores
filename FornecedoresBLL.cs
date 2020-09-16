using Cadastro_de_Fornecedores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Fornecedores
{

    public class FornecedoresBLL
    {
        private FornecedoresDAL fornecedoresDAL;

        public FornecedoresBLL()
        {
            fornecedoresDAL = new FornecedoresDAL();
        }

        public void AdicionarFornecedor(string NomeFantasia, string Endereco, string CNPJ, string Cidade, string CEP)
        {         
            if(string.IsNullOrEmpty(NomeFantasia) || string.IsNullOrWhiteSpace(NomeFantasia))
                throw new Exception("Campo NomeFantasia não pode ser vazio!");

            if(string.IsNullOrEmpty(Endereco) || string.IsNullOrWhiteSpace(Endereco))
                throw new Exception("Campo Endereço não pode ser vazio!");

            if(string.IsNullOrEmpty(CNPJ) || string.IsNullOrWhiteSpace(CNPJ))
                throw new Exception("Campo CNPJ não pode ser vazio!");

            if(string.IsNullOrEmpty(Cidade) || string.IsNullOrWhiteSpace(Cidade))
                throw new Exception("Campo Cidade não pode ser vazio!");

            if(string.IsNullOrEmpty(CEP) || string.IsNullOrWhiteSpace(CEP))
                throw new Exception("Campo CEP não pode ser vazio!");

            Fornecedor fornecedor = new Fornecedor();
            fornecedor.NomeFantasia = NomeFantasia;
            fornecedor.CNPJ = CNPJ;
            fornecedor.Endereco = Endereco;
            fornecedor.Cidade = Cidade;
            fornecedor.CEP = CEP;

            fornecedoresDAL.Salvar(fornecedor);
        }
    }
}
