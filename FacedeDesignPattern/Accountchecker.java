package FacedeDesignPattern;

public class Accountchecker {
    private String _accountName;
    public Accountchecker(String accountName) {
        this._accountName = accountName;
    }

    public boolean isvalid(String _accountName) {
        return _accountName.equals(this._accountName);
    }

}
