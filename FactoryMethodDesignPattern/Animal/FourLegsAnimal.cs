using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Animal
{
    abstract class FourLegsAnimal : IAnimal
    {
        public abstract string GetName();
    }
}