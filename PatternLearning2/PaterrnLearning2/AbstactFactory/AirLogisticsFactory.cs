using PaterrnLearning2.Interfaces;
using PaterrnLearning2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaterrnLearning2.AbstactFactory;
public class AirLogisticsFactory : ILogisticsFactory
{
    public ITransport CreateTransport() => new Airplane();
    public IPackage CreatePackage() => new Container();
}
