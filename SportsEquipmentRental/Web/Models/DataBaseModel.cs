using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Web.Models
{
    namespace DataAccessPostgreSqlProvider
    {
        public class SportDbContext : DbContext
        {
            public SportDbContext()
            {
                Database.EnsureCreated();
            }

            public SportDbContext(DbContextOptions<SportDbContext> options) : base(options)
            {
            }

            public DbSet<DBSport> Sport { get; set; }

            public static string ConnectionString { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql(SportDbContext.ConnectionString);

                base.OnConfiguring(optionsBuilder);
            }
        }

        public class DBSport
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public byte[] Photo { get; set; }
            public virtual Collection<DbEquip> Journal { get; set; }
            public string Name { get; set; }
        }

        
        public class DbEquip
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            public int SportId { get; set; }
            [ForeignKey("SportId")]
            public virtual DBSport Sports { get; set; }

            /// <summary>
            /// Предметная область
            /// </summary>
            public string[] Form { get; set; }

            public override string ToString()
            {
                return $"Форма: {Form}";
            }
        }
    }
}
