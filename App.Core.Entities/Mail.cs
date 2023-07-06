using System.ComponentModel.DataAnnotations.Schema;

namespace App.Core.Entities
{
    
    public class Mail
    {
        public int Id { get; set; }

        public string Asunto { get; set; }

        public string Contenido { get; set; }

        public int Remitente_id { get; set; }

        public DateTime FechaEnvio { get; set; }


    }

    
}