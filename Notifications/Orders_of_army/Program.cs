using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_rank
{
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Մարտիկ x;
            x.Ազգանուն = "Մարգարյան";
            x.կոչում =Մարտիկ.Զինվորական_կոչում.Սերժանտ;

            Console.WriteLine(x.կոչում+" "+x.Ազգանուն);

            Console.WriteLine();
            Console.WriteLine("for ցիկլի աշխատանքի արդյունքը՝");
            
            for (int i=1986;i<2017;i+=5)
            {
                if (x.կոչում < Մարտիկ.Զինվորական_կոչում.Գեներալ)
                    x.կոչում++;
                Console.WriteLine("Թիվ: {0} {1} {2}",i, x.կոչում, x.Ազգանուն);
            }

            Console.WriteLine();
            Console.WriteLine("Enum.GetName(typeof(Մարտիկ.Զինվորական_կոչում), 4) -ի աշխատանքի արդյունքը՝");
            Console.WriteLine(Enum.GetName(typeof(Մարտիկ.Զինվորական_կոչում), 4));

            Console.WriteLine();
            Console.WriteLine("GetValues(typeof(Մարտիկ.Զինվորական_կոչում)-ի and foreach-ի  աշխատանքի արդյունքը՝ ");
            Array values = Enum.GetValues(typeof(Մարտիկ.Զինվորական_կոչում));
            foreach (Մարտիկ.Զինվորական_կոչում elem in values)
                Console.WriteLine(" " + elem);

            Console.WriteLine();
            Console.WriteLine("Enum.IsDefined(typeof(Մարտիկ.Զինվորական_կոչում), \"Սերժանտ\")-ի աշխատանքի արդյունքը՝ ");
            if (Enum.IsDefined(typeof(Մարտիկ.Զինվորական_կոչում), "Սերժանտ"))
                Console.WriteLine("Այդ անունով հաստատուն գոյություն ունի");
            else Console.WriteLine("Այդ անունով հաստատուն գոյություն չունի");

            Console.WriteLine();
            Console.WriteLine("Enum.GetUnderlyingType(typeof(Մարտիկ.Զինվորական_կոչում))-ի աշխատանքի արդյունքը՝ ");
            Console.WriteLine(Enum.GetUnderlyingType(typeof(Մարտիկ.Զինվորական_կոչում)));

            Console.ReadKey();
        }
    }
}
