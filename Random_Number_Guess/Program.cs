using System;
class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 100);
        int lives = 5;
        bool isGuessedCorrectly = false;

        Console.WriteLine("RASTGELE SAYI BULMA OYUNU");
        Console.WriteLine("Rastgele 1-100 arası bir sayı giriniz");
        Console.WriteLine("Toplam 5 adet tahmin hakkınız var.");

        while (lives > 0)
        {
            Console.WriteLine("Tahmininiz: ");
            string input = Console.ReadLine();
            int guess;

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                continue;
            }

            if (guess < 1)
            {
                Console.WriteLine("Lütfen 1 ile 100 arasında bir sayı giriniz.");
                continue;
            }

            if (guess == secretNumber)
            {
                Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                isGuessedCorrectly=true;
                break;
            }
            else if(guess < secretNumber)
            {
                Console.WriteLine("Daha büyük bir sayı giriniz.");

            }
            else
            {
                Console.WriteLine("Daha düşük bir sayı giriniz. ");
            }
            lives--;
            Console.WriteLine("Kalan hakkınız: " + lives + "\n");
         }
        if (!isGuessedCorrectly)
        {
            Console.WriteLine($"Tahmin hakkınız bitti. Doğru sayı: {secretNumber}");
        }
        Console.WriteLine("\nOyun bitti çıkmak için bir tuşa basınız.");
        Console.ReadKey();

    }









}