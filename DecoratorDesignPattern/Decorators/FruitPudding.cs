using DecoratorDesignPattern.Base;

namespace DecoratorDesignPattern.Decorators
{
    public class FruitPudding : MilkTeaDecorator
    {
        public FruitPudding(IMilkTea milkTea) : base(milkTea)
        {          
        }

        public override double Cost()
        {
            return 3d + base.Cost();
        }
    }
}