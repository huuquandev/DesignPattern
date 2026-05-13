using FactoryMethodDesignPattern.AbstractFactory;
using FactoryMethodDesignPattern.Animal;
using FactoryMethodDesignPattern.Factory;
using System;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            IAnimalFactory factory;

            Random random = new Random();
            int type = random.Next(0, 2);

            if(type == 0)
            {
                factory = new FourLegsAnimalFactory();
            }
            else
            {
                factory = new TwoLegsAnimalFactory();
            }

            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
        }
    }
}