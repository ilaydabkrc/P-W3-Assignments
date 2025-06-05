using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen yapmak istediğiniz programı seçin:");
        Console.WriteLine("1. Not Ortalaması Hesaplama");
        Console.WriteLine("2. Hesap Makinesi");
        Console.WriteLine("3. Rastgele Sayı Tahmin Oyunu");
        Console.Write("Seçiminiz (1/2/3): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                AverageCalculation();
                break;
            case "2":
                Calculator();
                break;
            case "3":
                RandomNumberGuess();
                break;
            default:
                Console.WriteLine("Geçersiz seçim.");
                break;
        }

        Console.WriteLine("\nProgram sona erdi. Çıkmak için bir tuşa basınız.");
        Console.ReadKey();
    }

    static void AverageCalculation()
    {
        Console.WriteLine("Birinci ders notunu giriniz: ");
        double grade1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("İkinci ders notunu giriniz: ");
        double grade2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Üçüncü ders notunu giriniz: ");
        double grade3 = Convert.ToDouble(Console.ReadLine());

        if (!IsValidGrade(grade1) || !IsValidGrade(grade2) || !IsValidGrade(grade3))
        {
            Console.WriteLine("Hata: Notlar 0-100 arasında değil.");
            return;
        }

        double average = (grade1 + grade2 + grade3) / 3;
        string letterGrade = GetLetterGrade(average);

        Console.WriteLine($"\nOrtalamanız : {average}");
        Console.WriteLine($"\nHarf notunuz : {letterGrade}");
    }

    static bool IsValidGrade(double grade)
    {
        return grade >= 0 && grade <= 100;
    }

    static string GetLetterGrade(double average)
    {
        if (average >= 90 && average <= 100) return "AA";
        else if (average >= 85) return "BA";
        else if (average >= 80) return "BB";
        else if (average >= 75) return "CB";
        else if (average >= 70) return "CC";
        else if (average >= 65) return "DC";
        else if (average >= 60) return "DD";
        else if (average >= 55) return "FD";
        else return "FF";
    }

    static void Calculator()
    {
        Console.WriteLine("Birinci sayıyı giriniz: ");
        string input1 = Console.ReadLine();
        int number1 = Convert.ToInt32(input1);

        Console.WriteLine("İkinci sayıyı giriniz: ");
        string input2 = Console.ReadLine();
        int number2 = Convert.ToInt32(input2);

        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: ");
        Console.WriteLine("Toplama : + ");
        Console.WriteLine("Çıkartma : - ");
        Console.WriteLine("Çarpma : * ");
        Console.WriteLine("Bölme : / ");

        Console.WriteLine("Seçiminiz : ");
        string operation = Console.ReadLine();

        int result = 0;
        bool isValidOperation = true;

        switch (operation)
        {
            case "+":
                result = number1 + number2;
                Console.WriteLine($"Sonuç : {result}");
                break;

            case "-":
                result = number1 - number2;
                Console.WriteLine($"Sonuç : {result}");
                break;

            case "*":
                result = number1 * number2;
                Console.WriteLine($"Sonuç : {result}");
                break;

            case "/":
                if (number2 == 0)
                {
                    Console.WriteLine("Bir sayı sıfıra bölünemez");
                }
                else
                {
                    double divisionResult = (double)number1 / number2;
                    Console.WriteLine($"Sonuç : {divisionResult} ");
                }
                break;

            default:
                isValidOperation = false;
                Console.WriteLine("Geçersiz bir işlem girdiniz.");
                break;
        }
    }

    static void RandomNumberGuess()
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
                isGuessedCorrectly = true;
                break;
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Daha büyük bir sayı giriniz.");
            }
            else
            {
                Console.WriteLine("Daha düşük bir sayı giriniz.");
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
