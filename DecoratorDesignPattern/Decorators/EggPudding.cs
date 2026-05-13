using DecoratorDesignPattern.Base;

namespace DecoratorDesignPattern.Decorators
{
    public class EggPudding : MilkTeaDecorator
    {
        public EggPudding(IMilkTea milkTea) : base(milkTea)
        {          
        }

        public override double Cost()
        {
            return 3d + base.Cost();
        }
    }
}