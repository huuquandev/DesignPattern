using DecoratorDesignPattern.Base;

namespace DecoratorDesignPattern.Decorators
{
    public class Bubble : MilkTeaDecorator
    {
        public Bubble(IMilkTea milkTea) : base(milkTea)
        {          
        }

        public override double Cost()
        {
            return 1d + base.Cost();
        }
    }
}