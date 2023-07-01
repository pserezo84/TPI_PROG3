using App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesEF
{
    internal class MailContext:DbContext
    {
        public DbSet<Mail> Mails { get; set; }

        public DbSet<Destinatario> Destinatarios { get; set; }

        public DbSet<Contacto> Contactos { get; set; }  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
                "Persist Security Info=True;Initial Catalog=webmail;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
