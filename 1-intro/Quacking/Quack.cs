using System;

namespace _1_intro.Quacking
{
    public class Quack : IQuackBehavior {
        public void quack() => Console.WriteLine("Quack");
    }
}