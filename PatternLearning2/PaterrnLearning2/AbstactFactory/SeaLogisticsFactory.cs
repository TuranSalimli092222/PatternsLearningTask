using PaterrnLearning2.Interfaces;
using PaterrnLearning2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaterrnLearning2.AbstactFactory;
public class SeaLogisticsFactory : ILogisticsFactory
{
    public ITransport CreateTransport() => new Ship();
    public IPackage CreatePackage() => new Crate();
}