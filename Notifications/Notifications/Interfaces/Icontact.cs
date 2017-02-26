namespace Notifications.Interfaces
{
   interface IContact
{
    void ContactClient(Client client, string subject, string message);
}
}