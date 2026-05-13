package FacedeDesignPattern;

public class SecurityCodeChecker {

    private int _securityCode;

    public SecurityCodeChecker(int securityCode) {
        this._securityCode = securityCode;
    }

    public boolean isvalid(int _securityCode) {
        return _securityCode == this._securityCode;
    }

}
