namespace Inheritance2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Inheritance 2");

            //kui siin on Water class, siis kuvatakse seal olevat DoSomething meetodi sisu
            Water water = new Water();

            //kui panna Water water = new River();, siis kuvatakse River classis olevat DoSomething
            //meetodi sisu
            Water water2 = new River();
            Water water3 = new Lake();
            
            water.Flow = true;
            water.Length = "123";
            water2.Flow = true;
            water2.Length = "123";
            water3.Flow = false;
            water3.Length = "987";
            //kutsume soovitud meetodi esile
            water.DoSomething();
            water2.DoSomething();
            water3.DoSomething();
        }
    }
}
