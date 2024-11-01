using System;
using System.Threading;

namespace HW_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите свой логин");
            string login = Console.ReadLine();

            Console.WriteLine("Введите своё имя");
            string name = Console.ReadLine();

            string greetings = "Добрый день, " + name;
            Console.WriteLine(greetings);

            Console.WriteLine("Есть ли премиум-подписка (true / false)?");
            bool isPremium = bool.Parse(Console.ReadLine());

            User user = new User() { IsPremium = isPremium, Login = login, Name = name };

            if (user.IsPremium == false)
            {
                ShowAds();
            }
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}