namespace Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomSzam = new Random().Next(0, 1000), tipp = 0, tippeltSzam;
            bool sikeresTalalat = false;
            while (!sikeresTalalat)
            {
                Console.WriteLine("Adj meg egy számot 000 és 999 között: ");
                if (int.TryParse(Console.ReadLine(), out tippeltSzam) && (tippeltSzam >= 0 || tippeltSzam <= 999))
                {
                    tipp++;
                    if(tippeltSzam == randomSzam)
                    {
                        Console.WriteLine($"Gratulálok nyertél! A tippjeid száma: {tipp}");
                        return;
                    }
                    int segedTippeltSzam = tippeltSzam, segedRandomSzam = randomSzam, hasonlitas, oszto = 100;
                    while(oszto != 0)
                    {
                        string szamjegyHelye;
                        if (oszto == 100) szamjegyHelye = "Az első szám";
                        else if (oszto == 10) szamjegyHelye = "A második szám";
                        else szamjegyHelye = "A harmadik szám";
                        hasonlitas = (segedTippeltSzam/oszto).CompareTo(segedRandomSzam/oszto);
                        if (hasonlitas == 0) Console.WriteLine($"{szamjegyHelye} talált: {segedTippeltSzam / oszto}!");
                        else if (hasonlitas < 0) Console.WriteLine($"{szamjegyHelye} nagyobb");
                        else Console.WriteLine($"{szamjegyHelye} kisebb");
                        segedTippeltSzam = segedTippeltSzam % oszto;
                        segedRandomSzam = segedRandomSzam % oszto;
                        oszto /= 10;
                    }                       
                }
            }
        }
    }
}