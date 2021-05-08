using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Collections.Generic;
using MVCsportregistration.Models;
using System.Linq;

namespace MVCsportregistration.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")   
        {
        }

        public virtual DbSet<sportTable> sportTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sportTable>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<sportTable>()
                .Property(e => e.IdType)
                .IsUnicode(false);

            modelBuilder.Entity<sportTable>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<sportTable>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sportTable>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<sportTable>()
                .Property(e => e.Sport)
                .IsUnicode(false);

            modelBuilder.Entity<sportTable>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<sportTable>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
