using System;
class Program
{
    static void Main()
    {
        //Get the Grade
        Console.WriteLine("Birinci ders notunu giriniz: ");
        double grade1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("İkinci ders notunu giriniz: ");
        double grade2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Üçüncü ders notunu giriniz: ");
        double grade3 = Convert.ToDouble(Console.ReadLine());

        //Valida grades
        if (!IsValidGrade(grade1) || !IsValidGrade(grade2) || !IsValidGrade(grade3))
        {
            Console.WriteLine("Hata: Notlar 0-100 arasında değil.");
            return;
        }
        //Calculate average
        double average = (grade1 + grade2 + grade3) / 3;
        //Determine letter grade
        string letterGrade = GetLetterGrade(average);

        //Show result
        Console.WriteLine($"\nOrtalamanız : {average}");
        Console.WriteLine($"\nHarf notunuz : {letterGrade}");
    }

    // Grade validity check
    static bool IsValidGrade(double grade)
    {
        return grade >= 0 && grade <= 100;
    }
    //Determine letter grade based an average
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



}