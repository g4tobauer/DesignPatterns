using DesignPatterns.DesignPatterns.AbstractFactory.Classes.Data;
using DesignPatterns.DesignPatterns.AbstractFactory.Classes.Data.Shapes;
using DesignPatterns.DesignPatterns.AbstractFactory.Enums;

namespace DesignPatterns.DesignPatterns.AbstractFactory.Classes.Factories
{
    public class ShapeFactory : AbstractFactory
    {
        public override FactoryDataItem GetData(int type)
        {
            FactoryDataItem factoryDataItem = null;

            switch((ShapeType) type)
            {
                case ShapeType.Circle:
                    factoryDataItem = new FactoryDataItem(new Circle());
                    break;
                case ShapeType.Rectangle:
                    factoryDataItem = new FactoryDataItem(new Rectangle());
                    break;
                case ShapeType.Square:
                    factoryDataItem = new FactoryDataItem(new Square());
                    break;
            }
            return factoryDataItem;
        }
    }
}
