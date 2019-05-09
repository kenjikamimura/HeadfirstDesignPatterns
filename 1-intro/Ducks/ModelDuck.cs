using System;
using _1_intro.Flying;
using _1_intro.Quacking;

namespace _1_intro.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void display() => Console.WriteLine("I'm a model duck");
    }
}