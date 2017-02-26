# Enums

###The<a href=https://msdn.microsoft.com/en-us/library/sbbt4032.aspx> enum keyword</a> is used to declare an enumeration, a distinct type that consists of a set of named constants called the enumerator list.
####Usually it is best to define an enum directly within a namespace so that all classes in the namespace can access it with equal convenience. However, an enum can also be nested within a class or struct.
####By default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1. For example, in the following enumeration, Sat is 0, Sun is 1, Mon is 2, and so forth.





```C#
struct Մարտիկ
    {
        public enum Զինվորական_կոչում
        {
            Շարքային,
            Սերժանտ,
            Լեյտենանտ,
            Ավագ_լեյտենանտ,
            Կապիտան,
            Մայոր,
            Փոխգնդապետ,
            Գնդապետ,
            Գեներալ
        }
        public string Ազգանուն;
        public Զինվորական_կոչում կոչում;
    }
```


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
