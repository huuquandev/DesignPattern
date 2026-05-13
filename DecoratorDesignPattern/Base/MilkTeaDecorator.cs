namespace DecoratorDesignPattern.Base
{
    public abstract class MilkTeaDecorator : IMilkTea
    {
        private IMilkTea _milkTea;

        protected MilkTeaDecorator(IMilkTea milkTea)
        {
            this._milkTea = milkTea;
        }

        public virtual double Cost()
        {
            return _milkTea.Cost();
        }
    }
}