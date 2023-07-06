namespace WebAppMvc.Models
{
    public class MailViewModel
    {
        public int Id { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
        public int RemitenteId { get; set; }
        public DateTime FechaEnvio { get; set; }
    }
}
