// See https://aka.ms/new-console-template for more information
using System;

namespace StudentApp
{
    // Definicja typu wyliczeniowego dla płci
    enum Gender
    {
        Male,
        Female
    }

    // Definicja struktury Student
    struct Student
    {
        public string Nazwisko;
        public int NrAlbumu;
        public double Ocena;
        public Gender Plec;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie grupy 5 studentów
            Student[] grupa = new Student[5];

            // Wypełnianie instancji grupy danymi
            for (int i = 0; i < grupa.Length; i++)
            {
                WypelnijStudenta(ref grupa[i]);
            }

            // Wyświetlanie informacji o studentach
            Console.WriteLine("Grupa studentów:");
            foreach (var student in grupa)
            {
                WyswietlStudenta(student);
            }

            // Wyliczanie średniej ocen grupy studentów
            double srednia = ObliczSrednia(grupa);
            Console.WriteLine($"Średnia ocen: {srednia:F2}");

            Console.ReadLine();
        }

        static void WypelnijStudenta(ref Student student)
        {
            Console.WriteLine("Podaj nazwisko:");
            student.Nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj numer albumu:");
            student.NrAlbumu = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj ocenę (od 2.0 do 5.0):");
            student.Ocena = OgraniczOcene(double.Parse(Console.ReadLine()));

            Console.WriteLine("Podaj płeć (0 - Mężczyzna, 1 - Kobieta):");
            int plecValue = int.Parse(Console.ReadLine());
            student.Plec = (Gender)plecValue;
        }

        static void WyswietlStudenta(Student student)
        {
            Console.WriteLine($"Nazwisko: {student.Nazwisko}, Numer albumu: {student.NrAlbumu}, Ocena: {student.Ocena:F1}, Płeć: {student.Plec}");
            Console.WriteLine();
        }

        static double ObliczSrednia(Student[] grupa)
        {
            double sumaOcen = 0;

            foreach (var student in grupa)
            {
                sumaOcen += student.Ocena;
            }

            return sumaOcen / grupa.Length;
        }

        static double OgraniczOcene(double ocena)
        {
            if (ocena < 2.0)
            {
                return 2.0;
            }
            else if (ocena > 5.0)
            {
                return 5.0;
            }
            else
            {
                return ocena;
            }
        }
    }
}
