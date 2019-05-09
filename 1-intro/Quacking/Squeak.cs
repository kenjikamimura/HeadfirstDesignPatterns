using System;

namespace _1_intro.Quacking 
{
    public class Squeak : IQuackBehavior {
        public void quack() => Console.WriteLine("Squeak");
    }
}