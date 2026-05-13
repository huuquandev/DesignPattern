using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Animal
{
    abstract class TwoLegsAnimal : IAnimal
    {
        public abstract string GetName();
    }
}