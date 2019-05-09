

using System;

namespace _1_intro
{
    public abstract class Duck
    {
       IFlyBehavior flyBehavior;
       IQuackBehavior quackBehavior;

       public abstract void display();

        public void performFly() => flyBehavior.fly();
        public void performQuack() => quackBehavior.quack();
        public void swim() => Console.WriteLine("All ducks float, even decoys!");
    }
}