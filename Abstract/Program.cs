namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Parrot parrot = new Parrot() {Name="qus" };

            Shark akula = new Shark() {Name = "kisi" };
            Eagle eagle = new Eagle() {Name = "qartal" };
            
            Animal[] animals = {parrot, akula , eagle};
            Bird[] birds = { parrot, eagle,new Penguen() };
            //foreach (Bird bird in birds)
            //{
            //    bird.Fly();
            //    bird.Eat();
            //}

           
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine(parrot);
            foreach (var animal in animals)
            {
               Console.WriteLine( animal.ToString());

            }

            //parrot.Eat();
            //akula.Eat();
            //eagle.Eat();
            //parrot.Fly();
            //eagle.Fly();


        }

    }
   
}
