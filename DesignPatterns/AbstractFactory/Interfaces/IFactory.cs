using DesignPatterns.DesignPatterns.AbstractFactory.Classes.Data;

namespace DesignPatterns.DesignPatterns.AbstractFactory.Interfaces
{
    public interface IFactory
    {
        FactoryDataItem GetData(int type);
    }
}
