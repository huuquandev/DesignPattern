using System;
using DecoratorDesignPattern.Base;
using DecoratorDesignPattern.Decorators;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstMilkTea = new EggPudding(
                                new FruitPudding(
                                    new BlackSugar(
                                        new Bubble(
                                            new MilkTea()))));
            Console.WriteLine("EggPuddingFruitPuddingBlackSugarBubbleMilkTea:\t" + FirstMilkTea.Cost());

            var secondMilkTea = new BlackSugar(
                                    new MilkTea());

            Console.WriteLine("BlackSugarMilkTea:\t" + secondMilkTea.Cost());
        }
    }
}
