using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Fornecedores.Models
{
    [Table("fornecedores")]
    public class Fornecedor
    {
        [Key]
        public int id { get; set; }

        public String NomeFantasia { get; set; }

        public String CNPJ { get; set; }

        public String Endereco { get; set; }

        public String Cidade { get; set; }

        public String CEP { get; set; }

        public DateTime Criacao { get; set; }

        public DateTime Exclusao { get; set; }
    }
}
