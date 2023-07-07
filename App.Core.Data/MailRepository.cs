using App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace App.Core.Data
{
    public class MailRepository
    {
        public MailContext dbContext { get; set; }
        
        public MailRepository(MailContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public MailRepository()
        {
        }

        //#### Metodo para busqueda de Mail por asunto o contenido####//
        public List<Mail> SearchString(string textToSearch)
        {

            using (var context = new MailContext())
            {
                var query = from m in context.Mails
                            where m.Contenido.Contains(textToSearch) || m.Asunto.Contains(textToSearch) 
                            select m;

                return query.ToList();
            }

        }

        public List<Mail> SearchStringEnviados(string textToSearch)
        {

            using (var context = new MailContext())
            {
                var query = from m in context.Mails
                            where m.Contenido.Contains(textToSearch) || m.Asunto.Contains(textToSearch)
                            select m;

                return query.ToList();
            }

        }

        public IEnumerable<Mail> GetEntradaById(int id)
        {
            using (var context = new MailContext())
            {
                //return context.Mails.ToList();
                
                var query = from d in context.Destinatarios
                            join m in context.Mails on d.Mail_id equals m.Id into joinedMails
                            from m in joinedMails.DefaultIfEmpty()
                            where d.Contacto_id == id
                            select m;                    


                return query.ToList();

            }
            
        }
        public List<Mail> GetEnviadosById(int id)
        {
            using (var context = new MailContext())
            {
                var query = from m in context.Mails
                            where m.Remitente_id == id
                            select m;   
                return query.ToList();
            }
        }

        public void AddMail(Mail mail)
        {
            using (var context = new MailContext())
            {
                context.Mails.Add(mail);
                context.SaveChanges();
            }
        }
                
        public int GetMaxMailIdByRemitenteId(int remitenteId)
        {
            using (var context = new MailContext())
            {
                var maxId = context.Mails
                .Where(m => m.Remitente_id == remitenteId)
                .Max(m => m.Id);

                return maxId;
            }
        }

        public void AddDestinatario(Destinatario destinatario)
        {
            using (var context = new MailContext())
            {
                context.Destinatarios.Add(destinatario);
                context.SaveChanges();
            }
        }
    }


}