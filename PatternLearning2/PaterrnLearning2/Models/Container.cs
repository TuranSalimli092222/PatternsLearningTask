using PaterrnLearning2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaterrnLearning2.Models;
public class Container : IPackage
{
    public void Pack()
    {
        Console.WriteLine("Yuk konteynere yıgıldı.");
    }
}
