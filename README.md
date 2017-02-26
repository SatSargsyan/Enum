# Enums

```c#
namespace Notifications.Constants
{
    enum ServiceType
    {
        E_mail = 1,
        SMS,
        Viber,
        Facebook,
        VK,
        Istagram,
        Ok_ru
    }
}
```
####This is a part of the program, where defined how "Vk" has to looks .
```c#
public override void ContactClient(Client client, string subject, string message)
        {
            Console.WriteLine("Vk");

            Console.WriteLine("Client: {0}", client.Name);
            Console.WriteLine("\t♥♥♥♥ Новое письмо ♥♥♥♥");
            Console.WriteLine(message);
            Console.WriteLine();
        }
```
####This is a part of the program, where defined how "SMS" has to looks .
```c#
 public  override void ContactClient(Client client, string subject, string message)
        {
            Console.WriteLine("SMS");
            Console.WriteLine("Բաժանորդ: {0}", client.Name);
            Console.WriteLine("\t♦♦♦ Նոր հաղորդագրություն  ♦♦♦");
            Console.WriteLine(message);
            Console.WriteLine();
        }
        ```
        
![enum4](https://cloud.githubusercontent.com/assets/20840005/22841785/44992484-efec-11e6-823a-592517f1a935.gif)
