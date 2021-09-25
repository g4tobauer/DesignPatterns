using DesignPatterns.DesignPatterns.AbstractFactory.Classes.Data;
using DesignPatterns.DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.DesignPatterns.AbstractFactory.Classes.Factories
{
    public abstract class AbstractFactory : IFactory
    {
        public abstract FactoryDataItem GetData(int type);
    }
}
