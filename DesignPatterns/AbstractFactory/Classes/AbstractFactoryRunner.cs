using DesignPatterns.DesignPatterns.AbstractFactory.Classes.Data.Colors;
using DesignPatterns.DesignPatterns.AbstractFactory.Classes.Data.Shapes;
using DesignPatterns.DesignPatterns.AbstractFactory.Classes.Factories;
using DesignPatterns.DesignPatterns.AbstractFactory.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.AbstractFactory.Classes
{
    public class AbstractFactoryRunner : IRunner
    {
        private ShapeFactory _shapeFactory;
        private ColorFactory _colorFactory;
        public AbstractFactoryRunner()
        {
            _shapeFactory = new ShapeFactory();
            _colorFactory = new ColorFactory();
        }

        public void Run()
        {
            GetCircle().GetInfo();
            GetSquare().GetInfo();
            GetRetangle().GetInfo();

            GetRed().GetInfo();
            GetGreen().GetInfo();
            GetBlue().GetInfo();
        }

        private Circle GetCircle()
        {
            return _shapeFactory.GetData((int)ShapeType.Circle).DataItem as Circle;
        }
        private Square GetSquare()
        {
            return _shapeFactory.GetData((int)ShapeType.Square).DataItem as Square;
        }
        private Rectangle GetRetangle()
        {
            return _shapeFactory.GetData((int)ShapeType.Rectangle).DataItem as Rectangle;
        }
        private Red GetRed()
        {
            return _colorFactory.GetData((int)ColorType.Red).DataItem as Red;
        }
        private Green GetGreen()
        {
            return _colorFactory.GetData((int)ColorType.Green).DataItem as Green;
        }
        private Blue GetBlue()
        {
            return _colorFactory.GetData((int)ColorType.Blue).DataItem as Blue;
        }
    }
}
