using System;

namespace _1_intro.Flying
{
    public class FlyNoWay : IFlyBehavior {
        public void fly() => Console.WriteLine("I can't fly");
    }
}