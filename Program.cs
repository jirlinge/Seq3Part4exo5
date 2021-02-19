using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> fujita =
            new Dictionary<string, string>();

            // Add some elements to the dictionary. There are no
            // duplicate keys, but some of the values are duplicates.
            fujita.Add("F0", "Dégats leger, pas de quoi en faire tout un plat");
            fujita.Add("F1", "lourd, bon, c'est pas sorcier.");
            fujita.Add("F2", "catastrophique, ca commence à piquer.");
            fujita.Add("F3", "mortel, je vous invite à contacter un médecin dans les plus bref délais.");
            fujita.Add("F4", "cataclysmique, appelez vos proche et dites leur que vous les aimez");
            fujita.Add("F5", "extinction, bonne journée au revoir.");
            Console.WriteLine("nous vous invitons a renseigner l'indice des degats que vous rencontrez : F0, F1, F2, F3, F4 ou F5.");
            string Type = Console.ReadLine();


            if (fujita.ContainsKey(Type))
            {
                Console.WriteLine(fujita[Type]);
            }
            else {
                Console.Write("ce type n'existe pas");
            }





        }
    }
}
