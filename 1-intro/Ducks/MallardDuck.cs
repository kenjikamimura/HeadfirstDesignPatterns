using _1_intro.Flying;
using _1_intro.Quacking;
using System;

namespace _1_intro.Ducks
{
    public class MallardDuck : Duck {
        public MallardDuck(){
            this.quackBehavior = new Quack();
            this.flyBehavior = new FlyWithWings();
        }

        public override void display() => Console.WriteLine("I'm a real Mallard Duck");
    }
}