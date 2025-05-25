using System;
class Program
{
    static void Main()
    {
        //Get first number
        Console.WriteLine("Birinci sayıyı giriniz: ");
        string input1 = Console.ReadLine();
        int number1 = Convert.ToInt32(input1);

        //Get second number
        Console.WriteLine("İkinci sayıyı giriniz: ");
        string input2 = Console.ReadLine();
        int number2 = Convert.ToInt32(input2);

        //Ask for the operation
        Console.WriteLine("Yapmak istediğiiniz işlemi seçiniz: ");
        Console.WriteLine("Toplama : + ");
        Console.WriteLine("Çıkartma : - ");
        Console.WriteLine("Çarpma : * ");
        Console.WriteLine("Bölme : / ");

        Console.WriteLine("Seçiminiz : ");
        string operation = Console.ReadLine();

        //Perform the operation
        int result = 0;
        bool isValidOperation = true;


        switch (operation) {
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
                //Division by zero check
                if (number2 == 0)
                {
                    Console.WriteLine("Bir sayı sıfıra bölünemez");

                }
                else
                {
                    double divisionResult = (double)number1 / number2;
                    Console.WriteLine($"Sonuç : { divisionResult} ");
                }
                break;
                default:
                isValidOperation = false;
                Console.WriteLine("Geçersiz bir işlem girdiniz.");
                break;
        }
        Console.WriteLine("\nProgram sona erdi çıkmak için herhangi bir tuşa basınız.");
        Console.ReadKey();
    }
}
