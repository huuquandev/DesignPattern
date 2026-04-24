using System;
namespace StrategyDesignPattern.Interface
{
    public interface IPromoteStrategy
    {
        double DoDiscount(double price);
    }
}