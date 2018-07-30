using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImportApp.Model;
using MySql.Data.Entity;

namespace ImportApp
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ImportContext : DbContext
    {
        public ImportContext() : base()
        {
            
        }

        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Person> Persons { get; set; }      // People?
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<FinancialState> FinancialStates { get; set; }


        // Constructor to use on a DbConnection that is already opened
        public ImportContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        
            modelBuilder.Entity<Person>().HasOptional(s => s.Adress);
            modelBuilder.Entity<Adress>().HasMany(a => a.Persons);

            base.OnModelCreating(modelBuilder);

            // Configure StudentId as PK for StudentAddress
            //  modelBuilder.Entity<Adress>()
            //     .HasKey(e => e.PersonId);

            // Configure StudentId as FK for StudentAddress
            //  modelBuilder.Entity<Person>()
            //     .HasRequired(s => s.Adress)
            //     .WithRequiredPrincipal(ad => ad.Person);

            //modelBuilder.Entity<Adress>().MapToStoredProcedures();
            //modelBuilder.Entity<Person>().MapToStoredProcedures();
            // modelBuilder.Entity<Adress>().p.HasColumnType("VARCHAR");



        }
    }
}
