using System;
using System.Collections.Generic;

namespace SampleDictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList2<string> fighters = new MyList2<string>();

            fighters.Add("'1' George 'Rush' Saint Pierre >> Middleweight >> 26-2-0");
            Console.WriteLine(fighters.Length);


            fighters.Add("'2'Jon 'Bones' Jones  >> Light Heavyweight >> 26-1-0");
            Console.WriteLine(fighters.Length);

            fighters.Add("'3' Khabib 'The Eagle' Nurmagomedov  >> Lightweight >> 29-0-0");
            Console.WriteLine(fighters.Length);

            fighters.Add("'4' Anderson 'The Spider' Silva >> Middleweight >> 34-11-0");
            Console.WriteLine(fighters.Length);

            fighters.Add("'5' Demetrious 'Might Mouse' Johson >> Bantamweight >> 30-3-1");
            Console.WriteLine(fighters.Length);

            fighters.Add("'6' Fedor Emelianenko >> Heavyweight >> 39-6-0");
            Console.WriteLine(fighters.Length);

            fighters.Add("'7' Stipe Miocic >> Heavyweight >> 20-3-0");
            Console.WriteLine(fighters.Length);

            fighters.Add("'8' Daniel Cormier >> Heavyweight >> 22-3-0");
            Console.WriteLine(fighters.Length);

            fighters.Add("'9' Dustin Poirier >> Lightweight >> 27-6-0");
            Console.WriteLine(fighters.Length);

            fighters.Add("'10' Conor McGregor >> Lightweight >> 22-5-0");
            Console.WriteLine(fighters.Length);

            Console.WriteLine("<<<<<<<<<<BEST UFC FİGHTERS OF ALL TİME>>>>>>>>> ");


            foreach (var x in fighters.Items)
            {
                Console.WriteLine(x);
            }

        }
    }
}
