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

        public List<Mail> Search(string textToSearch)
        {

            using (var context = new MailContext())
            {
                var query = from m in context.Mails
                            where m.Asunto.Contains(textToSearch)
                            select m;

                return query.ToList();
            }

        }

        public IEnumerable<Mail> GetAll()
        {
            using (var context = new MailContext())
            {
                return context.Mails.ToList();
                //return dbContext.Mails.ToList();
            }
            
        }
        public Mail GetById(int id)
        {
            using (var context = new MailContext())
            {
                return dbContext.Mails.Find(id);
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