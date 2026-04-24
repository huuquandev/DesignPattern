using StrategyDesignPattern.Interface;
namespace StrategyDesignPattern.Dependencies
{
    public class QuarterDiscountStrategy : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price * 0.75;
        }
    }
}