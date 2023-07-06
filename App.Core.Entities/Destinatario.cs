using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Entities
{
    [Table("mails_contactos")]
    public class Destinatario
    {
        public int Id { get; set; }

        public int Mail_id { get; set; }

        public int Contacto_id { get; set;}

    }
}
