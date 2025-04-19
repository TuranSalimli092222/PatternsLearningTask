using PaterrnLearning2.AbstactFactory;
using PaterrnLearning2.Interfaces;
using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
namespace TransportFactoryExample;
class Program
{
    static void Main(string[] args)
    {
        bool flaq = false;
        while (!flaq)
        {
            try
            {
                Console.Write("Neqliyyat növünü daxil et \n 1.road \n 2. sea \n 3. air \n 4.son ");
                Console.WriteLine("");
                string? input = Console.ReadLine();
                if (input == "son")
                {
                    Console.WriteLine("Proqram dayandırılır...");
                    flaq = true; 
                    break;  
                }

                ILogisticsFactory factory = input.ToLower() switch
                {
                    "road" => new RoadLogisticsFactory(),
                    "sea" => new SeaLogisticsFactory(),
                    "air" => new AirLogisticsFactory(),
             
                    _ => throw new Exception("Neqliyyat növü tanınmadı!")
                };

                var transport = factory.CreateTransport();
                var package = factory.CreatePackage();

                transport.Deliver();
                package.Pack();
            }
            catch (Exception)
            {
                Console.WriteLine("seciminizi yazin,reqem daxil etmek olmaz!!");
            }

        }
    }
}
