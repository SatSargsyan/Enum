# Enums

###The<a href=https://msdn.microsoft.com/en-us/library/sbbt4032.aspx> enum keyword</a> is used to declare an enumeration, a distinct type that consists of a set of named constants called the enumerator list.
####Usually it is best to define an enum directly within a namespace so that all classes in the namespace can access it with equal convenience. However, an enum can also be nested within a class or struct, how it is shown in my example:

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

####By default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1. For example, in the following enumeration, Sat is 0, Sun is 1, Mon is 2, and so forth.
```C#
enum Days {Sun, Mercury, Venus, Earth, Mars, Jupiter,Saturn, Uranus,Neptune,Pluto};  
```
####Enumerators can use initializers to override the default values, as shown in the following example.
```C#  
enum Days {Sun=1, Mercury, Venus, Earth, Mars, Jupiter,Saturn, Uranus,Neptune,Pluto};  
```
####In this enumeration, the sequence of elements is forced to start from 1 instead of 0. However, including a constant that has the value of 0 is recommended. For more information, see Enumeration Types.
<b>Every enumeration type has an underlying type, which can be any integral type except<I> char</I></b>. The default underlying type of enumeration elements is int. To declare an enum of another integral type, such as byte, use a colon after the identifier followed by the type, as shown in the following example.
```C#
enum Days : byte {Sat=1, Sun, Mon, Tue, Wed, Thu, Fri};  
```
###The approved types for an enum are byte, sbyte, short, ushort, int, uint, long, or ulong.
A variable of type Days can be assigned any value in the range of the underlying type; the values are not limited to the named constants.
The default value of an enum E is the value produced by the expression (E)0.
System_CAPS_ICON_note.jpg Note
An enumerator cannot contain white space in its name.
The underlying type specifies how much storage is allocated for each enumerator. However, an explicit cast is necessary to convert from enum type to an integral type. For example, the following statement assigns the enumerator Sun to a variable of the type int by using a cast to convert from enum to int.
  
int x = (int)Days.Sun;  

When you apply System.FlagsAttribute to an enumeration that contains elements that can be combined with a bitwise OR operation, the 


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
