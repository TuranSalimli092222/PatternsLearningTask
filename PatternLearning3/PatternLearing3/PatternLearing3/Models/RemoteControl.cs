using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearing3.Models;
public class RemoteControl
{
    protected IDevice device;

    public RemoteControl(IDevice device)
    {
        this.device = device;
    }

    public virtual void TurnOn() => device.TurnOn();
    public virtual void TurnOff() => device.TurnOff();
    public virtual void SetChannel(int channel) => device.SetChannel(channel);
}
