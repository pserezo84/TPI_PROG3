using App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Data
{
    public class MailContext:DbContext
    {
        
        public DbSet<Mail> Mails { get; set; }

        public DbSet<Destinatario> Destinatarios { get; set; }

        public DbSet<Contacto> Contactos { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string connectionString =
        //        "Persist Security Info=True;Initial Catalog=webmail;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";
        //    optionsBuilder.UseSqlServer(connectionString);
        //}



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "Persist Security Info=True;Initial Catalog=webmail;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
