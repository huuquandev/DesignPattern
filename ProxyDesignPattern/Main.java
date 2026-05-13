public class Main {
    public static void main(String[] args) {
        Remote remoteProxy = new LazyProxyRemote();
        remoteProxy.turnOn();
        remoteProxy.turnOff();
    }
}
