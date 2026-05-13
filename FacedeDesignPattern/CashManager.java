package FacedeDesignPattern;

public class CashManager {

    private double _cashInAmount;
    public CashManager(double cashAmount) {
        this._cashInAmount = cashAmount;
    }
    public void deposit(double cashAmount) {
        System.err.println("Current cash in account: " + this._cashInAmount);
        this._cashInAmount += cashAmount;
    }

    public void withdraw(double cashAmount) {
        System.err.println("Current cash in account: " + this._cashInAmount);
        this._cashInAmount -= cashAmount;
    }

    public boolean haveEnoughCash(double cashAmount) {
        return this._cashInAmount >= cashAmount;
    }

}
