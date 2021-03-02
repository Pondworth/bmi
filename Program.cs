using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gebe deinen Namen ein: ");
            string name = Console.ReadLine();

            Console.Write("Gebe dein Alter ein: ");
            int alter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hallo " + name + ", schön das du mitmachst, Du bist also " + alter + " Jahre alt!");

            double weight; //Körpergewicht in Kilogramm
            double height;  //Körpergröße in m
            double bmi;

            Console.WriteLine("Damit dein BMI errechnet werden kann, benötigt das Programm ein paar Daten:");
            Console.Write("Gebe nun bitte dein Gewicht in Kilogramm (KG) ein: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nun gebe deine Größe an (in m): ");
            height = Convert.ToDouble(Console.ReadLine());

            //BMI = Gewicht : (Größe * Größe)
            bmi = weight / (height * height);

            Console.WriteLine("Dein BMI beträgt: " + bmi);
            Console.WriteLine("Laut der Website bmi-rechner.net sind folgende Werte kategorisiert (m/w):");
            Console.WriteLine("Untergewicht: >20 m, >19 w");
            Console.WriteLine("Normalgewicht: 20-25 m, 19-24 w");
            Console.WriteLine("Übergewicht: 26-30 m, 25-30 w");
            Console.WriteLine("Adipositas: 31-40");
            Console.WriteLine("starke Adipositas: <40");
            
            Console.WriteLine("Der optimale BMI nach Alter:");
            Console.WriteLine("19-24 Jahre = 19-24");
            Console.WriteLine("25-34 Jahre = 20-25");
            Console.WriteLine("35-44 Jahre = 21-26");
            Console.WriteLine("45-54 Jahre = 22-27");
            Console.WriteLine("55-64 Jahre = 23-28");
            Console.WriteLine("alter als 65 Jahre = 24-29");
            Console.ReadKey();
        }
    }
}
