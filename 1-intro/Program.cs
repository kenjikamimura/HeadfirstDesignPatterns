using _1_intro.Ducks;
using _1_intro.Flying;
using System;

namespace _1_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Duck mallard = new MallardDuck();
            // mallard.performFly();
            // mallard.performQuack();

            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
        }
    }
}
