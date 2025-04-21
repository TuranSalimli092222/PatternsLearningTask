using PatternLearing3.Models;

class Program
{
    static void Main(string[] args)
    {
        IDevice sonyTV = new SonyTV();
        RemoteControl remote = new AdvancedRemote(sonyTV);

        remote.TurnOn();
        remote.SetChannel(5);
        remote.TurnOff();
    }
}
