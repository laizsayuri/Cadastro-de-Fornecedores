using Cadastro_de_Fornecedores.Models;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Fornecedores
{
    
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class Context : DbContext
    {
        public DbSet<Fornecedor> fornecedores { get; set; }

        public Context() : base("sistemaFuncionarioDBConnetionString")
        {
            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
            Database.Initialize(true);
            Database.CreateIfNotExists();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>().ToTable("Fornecedores");
            base.OnModelCreating(modelBuilder);
        }

    }
}
