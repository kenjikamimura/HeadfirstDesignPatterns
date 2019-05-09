using System;

namespace _1_intro.Quacking
{
    public class MuteQuack : IQuackBehavior {
        public void quack() => Console.WriteLine("<< Silence >>");
    }
}