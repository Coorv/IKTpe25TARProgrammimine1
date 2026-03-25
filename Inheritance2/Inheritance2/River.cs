namespace Inheritance2
{
    //River on antud juhul alamklass ja viitab Waterile e peamisele classile
    class River : Water
    {
        //kui kirjutan override, siis kirjutab Water meetodis oleva DoSomething meetodi üle
        //kui panen siia public virtual void, siis ei kirjuta Water meetodi DoSomething-i üle
        public override void DoSomething()
        {
            //Water classis on olemas muutujad Flow ja Length ja sellepärast ei pea neid siin uuesti defineerima
            Console.WriteLine("River method and it has" + Flow + " and " + Length + "is in meters");
        }
    }
}
