using Notifications.Constants;
using Notifications.Interfaces;

namespace Notifications.Services
{
   abstract class Contacts:IContact
    {
        public abstract ServiceType ServiceType { get; }
        public abstract void Contactclient(Client client, 
            string subject, string message);

        //private static ContactServiceFactory factory;
        //public static ContactServiceFactory Factory
        //{
        //    get
        //    {
        //        if (factory == null)
        //            factory = new ContactServiceFactory();
        //        return factory;
        //    }
        //}
    }
}
