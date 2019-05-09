using System;

namespace _1_intro.Flying
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void fly() => Console.WriteLine("I'm flying with a rocket!");
    }
}