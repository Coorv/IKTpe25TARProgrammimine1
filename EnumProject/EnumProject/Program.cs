using System.ComponentModel;

namespace EnumProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum");

            //kasutate emumit Weekdays ja tahaks näha Friday.
            Console.WriteLine(Weekdays.Friday);

            //tahame näha Friday numbrilist väärtust
            Console.WriteLine((int)Weekdays.Friday);
            //(int) - Castimine, ehk teisendab andmetüüpi
            //juhul kui info võib kaduma minna ja ei näita soovitud tulemust
            Console.WriteLine("---------------------");
            //tehke uus enum Colors
            //väärtused on 
            //Red = 3,
            //Green = 10,
            //blue = 13,
            //Yellow = 5,
            //Black = 1,
            //White = 8
            //ühe värvi nimetuse peab konsoolis ära näitama.
            string valik = "";
            Console.WriteLine("What color do you chose?");
            valik = Console.ReadLine();
            switch (valik)
            {
                case "Red":
                    Console.WriteLine((int)Colors.Red);
                    Console.WriteLine(Colors.Red);
                    break;
                case "Green":
                    Console.WriteLine((int)Colors.Green);
                    Console.WriteLine(Colors.Green);
                    break;
                case "blue":
                    Console.WriteLine((int)Colors.blue);
                    Console.WriteLine(Colors.blue);
                    break;
                case "Yellow":
                    Console.WriteLine((int)Colors.Yellow);
                    Console.WriteLine(Colors.Yellow);
                    break;
                case "Black":
                    Console.WriteLine((int)Colors.Black);
                    Console.WriteLine(Colors.Black);
                    break;
                case "White":
                    Console.WriteLine((int)Colors.White);
                    Console.WriteLine(Colors.White);
                    break;
            }
        }

        enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Colors
        {
            Red = 3,
            Green = 10,
            blue = 13,
            Yellow = 5,
            Black = 1,
            White = 8
        }
    }
}
