public class LazyProxyRemote implements Remote {
    private RemoteImpl _remote = null;

    @Override
    public void turnOn() {
        System.out.println("LazyProxyRemote " + this._remote);
        if(this._remote == null) this._remote = new RemoteImpl();
        this._remote.turnOn();
    }

    @Override
    public void turnOff() {
        System.out.println("LazyProxyRemote " + this._remote);
        if(this._remote == null) this._remote = new RemoteImpl();
        this._remote.turnOff();
    }

}
