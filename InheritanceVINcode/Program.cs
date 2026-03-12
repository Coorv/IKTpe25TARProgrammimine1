namespace InheritanceVINcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teha pärilus
            //On olemas class nimega Machine
            //See pärib Cars classi
            //saab sisestada masina numbri
            //konsool annab vastuse: Edukalt sisestatud
            // VIN kood: VIN koodi nr
            Console.WriteLine("sisesta VIN kood: ");
            int vinCode = Convert.ToInt32(Console.ReadLine());

            Machine machine = new Machine();
            machine.SetVinCode(vinCode);

            Console.WriteLine("Vin Code is: " + machine.GetVinCode());
        }
    }
    class Machine : Car
    {
        public int GetVinCode()
        {
            return vin;
        }
    }
    class Car
    {
        public void SetVinCode(int vinCode)
        {
            vin = vinCode;
        }
        protected int vin;
    }
}
