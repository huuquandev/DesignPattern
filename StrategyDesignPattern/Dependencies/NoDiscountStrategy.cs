using StrategyDesignPattern.Interface;
namespace StrategyDesignPattern.Dependencies
{
    public class NoDiscountStrategy : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price;
        }
    }
}