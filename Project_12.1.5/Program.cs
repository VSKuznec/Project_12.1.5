namespace Project_12._1._5
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }

    class PremiumUser : User
    {
        public string PremiumName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void ShowAds(List<PremiumUser> users)
        {
            foreach (var user in users)
            {
                if (user.IsPremium)
                {
                    Console.WriteLine("Привет, {user.Name}!");
                }
                else
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

                    Console.WriteLine("Привет, {user.Name}!");
                }
            }
        }
    }
}