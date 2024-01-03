namespace SayiTaminOyunu.Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int point = 0;
            Console.WriteLine("Oyuna hoşgeldiniz. Oynamak istediğiniz seviyeyi seçiniz(kolay-orta-zor)");
            string answer = Console.ReadLine();
            if (answer == "kolay")
            {
                int number = rnd.Next(0, 21);
                Console.WriteLine("1 ve 20 arasında bir sayı tuttum. 10 tahmin hakkın var!");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i}. Tahmin hakkın : ");
                    int guess = int.Parse(Console.ReadLine());
                    if (guess < number)
                    {
                        Console.WriteLine("Daha büyük");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Daha küçük");
                    }
                    else if (guess == number)
                    {
                        point += (11 - i) * 10;
                        Console.WriteLine($"Aferin bildin. Puan : {point}");
                        break;
                    }
                    if (i == 10)
                    {
                        Console.WriteLine($"Tahmin hakkın doldu, bilemedin. Tuttğum sayı = {number}");
                        break;
                    }
                }
            }
            if (answer == "orta")
            {
                int number = rnd.Next(0, 51);
                Console.WriteLine("1 ve 50 arasında bir sayı tuttum. 7 tahmin hakkın var!");
                for (int i = 1; i <= 7; i++)
                {
                    Console.WriteLine($"{i}. Tahmin hakkın : ");
                    int guess = int.Parse(Console.ReadLine());
                    if (guess < number)
                    {
                        Console.WriteLine("Daha büyük");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Daha küçük");
                    }
                    else if (guess == number)
                    {
                        point += ((8 - i) * 10) - 8;
                        Console.WriteLine($"Aferin bildin. Puan : {point}");
                        break;
                    }
                    if (i == 7)
                    {
                        Console.WriteLine($"Tahmin hakkın doldu, bilemedin. Tuttğum sayı = {number}");
                        break;
                    }
                }
            }
            if (answer == "zor")
            {
                int number = rnd.Next(0, 101);
                Console.WriteLine("1 ve 100 arasında bir sayı tuttum. 5 tahmin hakkın var!");
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"{i}. Tahmin hakkın : ");
                    int guess = int.Parse(Console.ReadLine());
                    if (guess < number)
                    {
                        Console.WriteLine("Daha büyük");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Daha küçük");
                    }
                    else if (guess == number)
                    {
                        point += (6 - i) * 20;
                        Console.WriteLine($"Aferin bildin. Puan : {point}");
                        break;
                    }
                    if (i == 5)
                    {
                        Console.WriteLine($"Tahmin hakkın doldu, bilemedin. Tuttğum sayı = {number}");
                        break;
                    }
                }
            }

        }
    }
}
