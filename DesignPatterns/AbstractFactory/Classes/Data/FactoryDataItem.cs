namespace DesignPatterns.DesignPatterns.AbstractFactory.Classes.Data
{
    public class FactoryDataItem
    {
        private object _dataItem;
        public FactoryDataItem(object dataItem)
        {
            _dataItem = dataItem;
        }
        public object DataItem { get { return _dataItem; } }
    }
}
