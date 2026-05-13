using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FactoryMethodDesignPattern.Animal;
using FactoryMethodDesignPattern.Factory;

namespace FactoryMethodDesignPattern.AbstractFactory
{
    abstract class AbstractAnimalFactory : IAnimalFactory
    {
        public abstract IAnimal createAnimal();
    }
}