using DesignPattern.Observer.DAL;
using DesignPattern.Observer.ObserverPattern.Observer;
using System;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.Messages.Add(new Message
            {
                FullName = appUser.Name + " " + appUser.Surname,
                Content = "Dergi Bültenimize Kayıt Olduğunuz İçin Çok Teşekkür Ederiz, Dergilerimize Web Sitemizden Ulaşabilirsiniz."
            });
 
            context.SaveChanges();
        }
    }
}