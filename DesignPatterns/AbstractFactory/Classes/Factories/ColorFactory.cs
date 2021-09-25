using DesignPatterns.DesignPatterns.AbstractFactory.Classes.Data;
using DesignPatterns.DesignPatterns.AbstractFactory.Classes.Data.Colors;
using DesignPatterns.DesignPatterns.AbstractFactory.Enums;

namespace DesignPatterns.DesignPatterns.AbstractFactory.Classes.Factories
{
    public class ColorFactory : AbstractFactory
    {
        public override FactoryDataItem GetData(int type)
        {
            FactoryDataItem factoryDataItem = null;

            switch((ColorType) type)
            {
                case ColorType.Red:
                    factoryDataItem = new FactoryDataItem(new Red());
                    break;
                case ColorType.Green:
                    factoryDataItem = new FactoryDataItem(new Green());
                    break;
                case ColorType.Blue:
                    factoryDataItem = new FactoryDataItem(new Blue());
                    break;
            }
            return factoryDataItem;
        }
    }
}
