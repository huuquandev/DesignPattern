package FacedeDesignPattern;

public class BankAccountFacade {

    private String _accountName;
    private int _securityCode;

    Accountchecker accountChecker;
    SecurityCodeChecker securityCodeChecker;
    CashManager cashManager;
    public BankAccountFacade(String accountName, int securityCode) {
        this._accountName = accountName;
        this._securityCode = securityCode;
        this.accountChecker = new Accountchecker(this._accountName);
        this.securityCodeChecker = new SecurityCodeChecker(this._securityCode);
        this.cashManager = new CashManager(0.0);
    }

    public void depositCash(double cashAmount) {
        if (accountChecker.isvalid(_accountName) && securityCodeChecker.isvalid(_securityCode)) {
            cashManager.deposit(cashAmount);
            System.err.println("Deposit " + cashAmount + " to account " + _accountName);
        }else{
            System.err.println("Error account name or security code");
        }
    }

    public void withdrawCash(double cashAmount) {
        if (accountChecker.isvalid(_accountName) && securityCodeChecker.isvalid(_securityCode) && cashManager.haveEnoughCash(cashAmount)) {
            cashManager.withdraw(cashAmount);
            System.err.println("Withdraw " + cashAmount + " from account " + _accountName);
        }else{
            System.err.println("Error account name or security code or not enough cash");
        }
    }

}
