using App.Core.Entities;
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

        public List<Mail> SearchString(string textToSearch)
        {

            using (var context = new MailContext())
            {
                var query = from m in context.Mails
                            where m.Contenido.Contains(textToSearch)
                            select m;

                return query.ToList();
            }

        }

        public IEnumerable<Mail> GetAll(int id)
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
        public List<Mail> GetByRemitenteId(int id)
        {
            using (var context = new MailContext())
            {
                var query = from m in context.Mails
                            where m.Remitente_id == id
                            select m;   
                return query.ToList();
            }
        }

        public void Add(Mail mail)
        {
            using (var context = new MailContext())
            {
                dbContext.Mails.Add(mail);
                dbContext.SaveChanges();
            }
        }

    }

    
}