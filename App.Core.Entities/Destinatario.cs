using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Entities
{
    [Table("dbo.mails_contactos")]
    public class Destinatario
    {
        public int Id { get; set; }

        public string Mail_id { get; set; }

        public string Contacto_id { get; set;}

    }
}
