using PaterrnLearning2.Interfaces;
using PaterrnLearning2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaterrnLearning2.AbstactFactory;
public class RoadLogisticsFactory : ILogisticsFactory
{
    public ITransport CreateTransport() => new Truck();
    public IPackage CreatePackage() => new Box();
}

