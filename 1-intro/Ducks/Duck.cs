using _1_intro.Flying;
using _1_intro.Quacking;
using System;

namespace _1_intro.Ducks
{
    public abstract class Duck
    {
       public IFlyBehavior flyBehavior;
       public IQuackBehavior quackBehavior;

       public abstract void display();

        public void performFly() => flyBehavior.fly();
        public void performQuack() => quackBehavior.quack();
        public void swim() => Console.WriteLine("All ducks float, even decoys!");
        public void setFlyBehavior(IFlyBehavior flyBehavior) => this.flyBehavior = flyBehavior;
        public void setQuackBehavior (IQuackBehavior quackBehavior) => this.quackBehavior = quackBehavior;
    }
}