namespace Házi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Feldat_7
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("Páros");
            }
            else
            {
                Console.WriteLine("Páratlan");
            }


            // 8.feladat
            int jegy = Convert.ToInt32(Console.ReadLine());
            if (jegy == 1)
            {
                Console.WriteLine("Elégtelen");
            }
            else if (jegy == 2) 
            { 
                Console.WriteLine("Elégséges");
            }
            else if (jegy == 3)
            {
                Console.WriteLine("Közepes");
            }
            else if (jegy == 4)
            {
                Console.WriteLine("Jó");
            }
            else
            {
                Console.WriteLine("Jeles");
            }

            //9.feladat

            int hofok = Convert.ToInt32(Console.ReadLine());
            if (hofok <= 0)
            {
                Console.WriteLine("Szilárd");
            }
            else if (hofok < 100)
            {
                Console.WriteLine("Folyékony");
            }
            else
            {
                Console.WriteLine("Gáz");
            }

            //10.feladat

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if ((a+b>c) && (a+c>b) && (c + b > a))
            {
                Console.WriteLine("Szerkeszthető");
            }
            else
            {
                Console.WriteLine("Nem szerkeszthető");
            }

            // 11.feladat

            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(f - 273);

            // 12.feladat

            double ce = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ce + 273);

            //13.feladat

            int s = Convert.ToInt32(Console.ReadLine());
            int h = s / (60*60);
            s %= (60*60);
            int m = s / 60;
            s %= 60;
            Console.WriteLine($"{h} óra, {m} perc, {s}, másodperc");

            // 14.feladat

            string szo1=Console.ReadLine();
            Console.WriteLine(szo1[szo1.Length-1]);

            // 15 .feladat

            string szo2 =Console.ReadLine();
            if (szo2[0] == szo2[szo2.Length - 1])
            {
                Console.WriteLine("egyezik");
            }
            else 
            {
                Console.WriteLine("Nem egyezik");
            }
        }
    }
}
