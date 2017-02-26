using Notifications.Constants;

namespace Notifications.Services
{
    class ContactServiceManaging
    {
        public Contacts Create(ServiceType st)
        {
            Contacts service;
            switch(st)
            {
                case ServiceType.E_mail:
                    service = new E_mail();
                    break;

            }
                

        }
    }
}
