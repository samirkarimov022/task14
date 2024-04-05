using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public abstract void Eat();
        public override string ToString()
        {
            return Name;
        }

    }

    abstract class Bird : Animal
    {
        //public abstract void Fly();
        public virtual void Fly()
        {
            Console.WriteLine("Fly");
        }
        
    }
    class Parrot : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Parrot");
        }

        public override void Fly()
        {
            Console.WriteLine("papuqay kimi");
        }

        public void Talk()
        {
            Console.WriteLine("cik cik");

        }
    }

    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("yirtici Bird kimi");
        }

        //public override void Fly()
        //{
        //    Console.WriteLine("yuxarilarda suzulur");
        //}
    }
    class Penguen : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("bal;q yiyir");
        }
        public override void Fly()
        {
            Console.WriteLine("ucmur");
        }
    }

    abstract class Fish:Animal
    {
        public void Swim() 
        {
            Console.WriteLine("Swim");
        }
    }

    class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

    }

}
