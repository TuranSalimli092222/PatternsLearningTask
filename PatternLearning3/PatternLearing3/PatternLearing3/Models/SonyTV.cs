using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearing3.Models;
public class SonyTV : IDevice
{
    public void TurnOn() => Console.WriteLine("Sony TV is ON");
    public void TurnOff() => Console.WriteLine("Sony TV is OFF");
    public void SetChannel(int channel) => Console.WriteLine($"Sony TV: Channel set to {channel}");
}
