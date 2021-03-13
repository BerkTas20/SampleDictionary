using System;
using System.Collections.Generic;

namespace SampleDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> professions = new MyList<string>();
            professions.Add("Programmer");
            Console.WriteLine(professions.Length);

            professions.Add("Academician");
            Console.WriteLine(professions.Length);


            professions.Add("Translator");
            Console.WriteLine(professions.Length);


            professions.Add("Administrative assistant");
            Console.WriteLine(professions.Length);


            professions.Add("Doctor");
            Console.WriteLine(professions.Length);

            foreach (var x in professions.Items)
            {
                Console.WriteLine(x);
            }
            
        }


        
    }
}
