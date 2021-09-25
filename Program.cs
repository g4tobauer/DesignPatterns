using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.AbstractFactory.Classes;
using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            GetRunner().Run();
        }

        private static IRunner GetRunner()
        {
            return new AbstractFactoryRunner();
            return new ChainOfResponsabilityRunner();
        }
    }
}
