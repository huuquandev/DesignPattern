package FacedeDesignPattern;

public class main {
    public static void main(String[] args) {
        BankAccountFacade bankAccountFacade = new BankAccountFacade("Huuquan", 1234);
        bankAccountFacade.withdrawCash(900000.00);    
        bankAccountFacade.depositCash(1000000.00);

    }
}
