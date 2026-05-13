using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Animal
{
    class Duck : TwoLegsAnimal
    {
        public override string GetName()
        {
            return "I am Duck";
        }
    }
}