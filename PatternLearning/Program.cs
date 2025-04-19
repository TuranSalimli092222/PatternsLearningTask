using System;

namespace TransportFactoryExample
{
    // 1. Interface
    public interface ITransport
    {
        void Deliver();
    }

    // 2. Implementasiyalar
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Yük yolla göndərildi.");
        }
    }

    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Yük dənizlə göndərildi.");
        }
    }

    public class Airplane : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Yük hava ilə göndərildi.");
        }
    }

    // 3. Factory sinfi
    public class TransportFactory
    {
        public ITransport CreateTransport(string deliveryType)
        {
            switch (deliveryType.ToLower())
            {
                case "road":
                    return new Truck();
                case "sea":
                    return new Ship();
                case "air":
                    return new Airplane();
                default:
                    throw new Exception("Nəqliyyat növü tanınmadı!");
            }
        }
    }

    // 4. Main
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nəqliyyat növünü daxil et (road / sea / air): ");
            string input = Console.ReadLine();

            TransportFactory factory = new TransportFactory();

            try
            {
                ITransport transport = factory.CreateTransport(input);
                transport.Deliver();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Xəta: {ex.Message}");
            }
        }
    }
}
