namespace Cadastro_de_Fornecedores.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fornecedores",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NomeFantasia = c.String(unicode: false),
                        CNPJ = c.String(unicode: false),
                        Endereco = c.String(unicode: false),
                        Cidade = c.String(unicode: false),
                        CEP = c.String(unicode: false),
                        Criacao = c.DateTime(nullable: false, precision: 0),
                        Exclusao = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fornecedores");
        }
    }
}
