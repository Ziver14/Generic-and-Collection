using System.Collections;
using System.ComponentModel.Design;

namespace Generic_and_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List <string> list = new List<string> (); //динамический массив
            Stack<string> stack = new Stack<string>();//стек
            Queue<string> queue = new Queue<string>();//очередь
            Dictionary<int,string > keyValuePairs = new Dictionary<int, string> ();//map
            ArrayList arrayList = new ArrayList ();
            HashSet<int> visited = new HashSet<int>();//set

            list.Add("asd");
            list.Remove("asd");
            list.Contains("asd");//ищет первый элемент
            list.Clear();
            int c = list.Count;//возвращает колличество элементов в списке

            keyValuePairs.Clear();
            int c2 = keyValuePairs.Count;
            keyValuePairs.Add(1, "Alice");
            keyValuePairs.Remove(1);
            keyValuePairs.ContainsKey(1);

            Dictionary<string, string> RusToEng = new Dictionary<string, string>()
            {
                {"Россия","Russia" },
                {"Франция","France" },
                {"США","USA" }

            };

            Dictionary<string, string> EngToRus = new Dictionary<string, string>()
            {
                {"Russia","Россия" },
                {"France","Франция" },
                {"USA","США" }

            };
            Console.WriteLine("Выберите направление перевода");
            Console.WriteLine("1.Английский->Русский");
            Console.WriteLine("2.Русский -> Английский");
            int choise = int.Parse(Console.ReadLine());

            if (choise == 1)
            {
                Console.WriteLine("Введите слово на английском");
                string word = Console.ReadLine();

                if (EngToRus.ContainsKey(word))
                {
                    Console.WriteLine($"Перевод на русский: {EngToRus[word]}");
                }
                else Console.WriteLine("Перевод не найден");

            }

            else if (choise == 2)
            {
                Console.WriteLine("Введите слово на русском");
                string word = Console.ReadLine();

                if (EngToRus.ContainsKey(word))
                {
                    Console.WriteLine($"Перевод на русский: {RusToEng[word]}");
                }
                else Console.WriteLine("Перевод не найден");

            }
            else Console.WriteLine("Нет такой команды");*/

            //Создание обобщений

            /*
             class ClassName<T1,T2, . . . TN>{
            Реализация методов и полей класса которые работают с T
            }
             */

            Point3D point = new Point3D(3, 4, 2);
            Console.WriteLine(point.ToString());

            Sword sword = new Sword("Резня",50,"Резать",2);
            Person <Sword> elf = new Person <Sword>("SAD","Elf",sword); 
            elf.Print();

            

             
             
             



        }
    }
}
