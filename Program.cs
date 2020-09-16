using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Fornecedores
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Digite o Nome: ");
            //String NomeFantasia = Console.Read().ToString();
            //Console.WriteLine("Digite o CNPJ: ");
            //String CNPJ = Console.Read().ToString();
            //Console.WriteLine("Digite o Endereço: ");
            //String Endereco = Console.Read().ToString();
            //Console.WriteLine("Digite a Cidade: ");
            //String Cidade = Console.Read().ToString();
            //Console.WriteLine("Digite o CEP: ");
            //String CEP = Console.Read().ToString();


            FornecedoresBLL fornecedoresBLL = new FornecedoresBLL();
            fornecedoresBLL.AdicionarFornecedor("Loja AZ Informática", "Rua Abcd, 1222", "90000-0000", "São Paulo", "00.0000-0000");
        }
    }
}
