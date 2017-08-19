using System.Data.Entity;
using PJDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System;
using PJDDD.Infra.Data.Migrations;
using PJDDD.Infra.Data.EntityConfig;

namespace PJDDD.Infra.Data.Contexto
{
    public class PJDDDContext:DbContext
    {
        public PJDDDContext():base("ConnectionBD")
        {

        }
        public DbSet<Cliente> Clientes { get; set; } // Preciso de um dbset para casa entidade que vou criar uma tabela
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Remove o plural do nome das tabelas, deixando o nome definido na classe
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); // Remove o delete em cascata nos relacionamento um para muitos
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();// Remove o delete em cascata nos relacionamento muitos para muitos
            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());// defini que campo vai ser a key automaticamente
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar")); // configura que sempre que eu tiver um tipo string ele vai gravar na tabela como varchar, o padra é nvarchar
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100)); // Configura o tamanha dos campos strings como 100 como padrao
            modelBuilder.Configurations.Add(new ClienteConfiguration()); //Adciona a configuração especifica da tabela cliente
            modelBuilder.Configurations.Add(new ProdutoConfiguration()); //Adciona a configuração especifica da tabela produto

        }
        //Automatizando a data de cadastro
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry =>entry.Entity.GetType().GetProperty("DataCadastro")!=null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                else
                {
                    entry.Property("DataCadastro").IsModified = false;
                }

            }
            return base.SaveChanges();
        }
    }
    
}
