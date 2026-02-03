namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary ja foreach");

            //var on muutuja
            
            var domains = new Dictionary<string, string>()
            {
                { "fi", "Finland"},
                { "se", "Sweden"},
                { "de", "Germany"},
                { "fr", "France"},
                { "es", "Spain"},
            };
            //kasutate foreachi ja juurde tuleb lisada kolmas rida
            int counter = 1;
            foreach (var element in domains)
            {
                Console.WriteLine(element.Key + " - " + element.Value +  " - " + counter);
                counter++;
            }
        }
    }
}
