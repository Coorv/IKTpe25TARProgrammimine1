using System.Security.Cryptography.X509Certificates;
using System.Collections;

namespace SortedListAndTuple_t
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SortedList ja Tuple kasutus");
            int valik = int.Parse(Console.ReadLine());
            switch (valik)
            {
                case 1:
                    Nimekiri();
                    break;
                case 2:
                    Tuple();
                    break;
                default:
                    Console.WriteLine("bye");
                    break;
            }
            //SortedList on loendi tüüp mis salvestab andmeid võti-väärtus paarides tõusvas järjekorras
            //tuple on andmestruktuur kuhu saab lisada mitmeid andmetüüpe, sellesse saab lisada elemente 1-8.
            
            //Peamised erinevused nende vahel on, et SortedList automaatselt sorteerib
            //sees olevaid andmeid tõusvasse järjekorda ning selle kasutuseks peab
            //lisama igale väärtusele vastava võtme, näiteks: 1 andmele "esimene".
            //Tuple aga on lihtsam kasutada, ei sorteeri ise andmeid ja saab hoida mitmeid
            //erinevaid andmetüüpe, kuid sellesse ei saa lisada programmi käigul rohkem
            //andmeid.
        }
        public static void Nimekiri()
        {
            SortedList nimekiri = new SortedList()
            {
                {1, "esimene"},
                {3, "kolmas"},
                {8, "kaheksas"}
            };
            foreach (DictionaryEntry entry in nimekiri)
                Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
        public static void Tuple()
        {
            (int id, string sõnum, bool IsActive) tuple =
                (1, "Tere", true);
            
            Console.WriteLine(tuple.id + " " + tuple.sõnum + " " + tuple.IsActive);
        }

    }
}
