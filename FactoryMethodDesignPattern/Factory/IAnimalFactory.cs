using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMethodDesignPattern.Animal;

namespace FactoryMethodDesignPattern.Factory
{
    interface IAnimalFactory
    {
        IAnimal createAnimal();
    }
}