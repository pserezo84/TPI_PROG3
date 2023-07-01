// See https://aka.ms/new-console-template for more information
using DataAccesEF;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

Console.WriteLine("Hello, World!");

var mailsCount = 0;

using (var context = new MailContext()) {

    mailsCount = context.Mails.Count();

}

Console.WriteLine($"Mail conut:{mailsCount}");



using (var context = new MailContext())
{
    var query = from m in context.Mails
                where m.Remitente_id == 4
                select m;

    foreach (var item in query.ToList())
    {
        Console.WriteLine($"Bandeja de entrada usuario {item.Asunto} {item.Contenido}");
    }

    
    
}


