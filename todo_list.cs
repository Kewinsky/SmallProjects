using System;
using System.Collections.Generic;

namespace todo_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todoList = new List<string>();
            todoList.Add("zjesc sniadanie");
            todoList.Add("zjesc obiad");
            todoList.Add("zjesc kolacje");

            string opcja, zadanie;
            int miejsce, dlugosc = 0;

            Console.WriteLine("1 - Co chcesz dziś zrobić ?");
            Console.WriteLine("0 - Odznacz wykonane :)");
            Console.WriteLine("---------------------------");
            dlugosc = todoList.Count;

            do
            {
                Console.WriteLine("Ilość elementów: " + dlugosc);
                // podaj cyfre 1 albo 0
                Console.Write("> ");
                opcja = Console.ReadLine();
                // jak 1 - spytaj o zadanie i miejsce gdzie je dodac (zadbaj o sprawdzenie dlugosci listy!)
                if (opcja == "1")
                {
                    Console.Write("Wpisz zadanie: ");
                    zadanie = Console.ReadLine();
                    dlugosc++;
                    do
                    {
                        Console.Write("Jak ważne jes to dla Ciebie zadanie w skali  1 - {0}? ", dlugosc);
                        miejsce = int.Parse(Console.ReadLine());
                    } while ((miejsce < 1) || (miejsce > dlugosc));

                    todoList.Insert(miejsce - 1, zadanie);
                }
                // jak 0 - spytaj o zadanie - usun to zadanie (nie pytaj jesli nie ma co usuwac!)
                else if (opcja == "0")
                {
                    if (dlugosc == 0)
                    {
                        Console.WriteLine("Aktualnie nie ma żadnych zadań na Twojej liście.");
                    }
                    else
                    {
                        do
                        {
                            Console.Write("Podaj numer zadania do usunięcia: ");
                            miejsce = int.Parse(Console.ReadLine());
                        } while ((miejsce < 1) || (miejsce > dlugosc));
                        todoList.Remove(todoList[miejsce - 1]);
                        dlugosc--;
                    }
                }

                // inne
                else
                    Console.WriteLine("Nie rozumiem :(");
                // wyświetl zadania
                int licznik = 0;
                Console.WriteLine("------------------------------------------------------");
                foreach (string zad in todoList)
                {
                    licznik++;
                    Console.WriteLine(licznik + "." + zad);
                }
                Console.WriteLine("------------------------------------------------------");
            } while (true);
        }
    }
}
