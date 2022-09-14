using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{

    internal class Program
    {
        public class Book
        {
            public string Pisatel { get; set; }
            public string Name { get; set; }
        }


        static void Main(string[] args)
        {

            List<string> avtor = new List<string>() { };
            List<Book> books = new List<Book>();
            int del;
            int add;
            string poisk;
            string avt;
            string name;

            Console.WriteLine("Введите цифру необходимого действия:\n1.Добавить автора/Удалить автора\n2.Добавить произведение\n3.Поиск произведений автора");
            add = int.Parse(Console.ReadLine());

            if (add == 1)
            {
                Console.WriteLine("Добавить автора");
                Console.WriteLine("Введите ФИО автора");
                string writer = Console.ReadLine();
                Console.WriteLine("");
                avtor.Add(writer);
                avtor.Add("Александр Пушкин");
                avtor.Add("Алексей Толстой");
                avtor.Add("Антон Чехов");
                avtor.Add("Валентин Катаев");
                foreach (string s in avtor)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("Удалить автора?\n1.Да\n2.Нет");
                del = int.Parse(Console.ReadLine());
                if (del == 1)
                {
                    Console.WriteLine("Введите ФИО автора");
                    string writer1 = Console.ReadLine();
                    Console.WriteLine("Удалить автора - " + writer1);
                    avtor.Remove(writer1);
                    foreach (string s in avtor)
                    {
                        Console.WriteLine(s);
                    }
                }
                Console.ReadKey();
            }
            else if (add == 2)
            {
                Console.WriteLine("Введите Автора и Название книги через Enter чтобы добавить книгу");
                avt = Console.ReadLine();
                name = Console.ReadLine();
                books.Add(new Book() { Pisatel = avt, Name = name });
                books.Add(new Book() { Pisatel = "Александр Пушкин", Name = "Сказка о золотом петушке" });
                books.Add(new Book() { Pisatel = "Алексей Толстой", Name = "Иван-царевич и серый волк" });
                books.Add(new Book() { Pisatel = "Антон Чехов", Name = "Каштанка" });
                books.Add(new Book() { Pisatel = "Валентин Катаев", Name = "Сын полка" });
                Console.ReadKey();
            }
            else if (add == 3)
            {// заполняем книги

                Console.WriteLine("Введите Автора или название книги");
                poisk = Console.ReadLine();
                books.Add(new Book() { Pisatel = "Александр Пушкин", Name = "Сказка о золотом петушке" });
                books.Add(new Book() { Pisatel = "Алексей Толстой", Name = "Иван-царевич и серый волк" });
                books.Add(new Book() { Pisatel = "Антон Чехов", Name = "Каштанка" });
                books.Add(new Book() { Pisatel = "Валентин Катаев", Name = "Сын полка" });
                // ищем 1 элемент
                Book found = books.Find(item => item.Pisatel == poisk || item.Name == poisk);

                // выводим элемент на экран
                Console.WriteLine("Автор:{0}, Название:{1}", found.Pisatel, found.Name);

                Console.WriteLine("");
                Console.ReadKey();
            }
        }
    }
}
