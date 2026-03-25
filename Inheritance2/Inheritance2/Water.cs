namespace Inheritance2
{
    class Water
    {
        public bool Flow;
        public string Length;
        
        //siin on DoSomething meetod, mida siis viidetatakse River classi all.
        //see võib olla virtual ja ei pea panema override kuna teda krirjutatakse üle
        public virtual void DoSomething()
        {
            
            Console.WriteLine("Do Something method water");
        }
    }
}
