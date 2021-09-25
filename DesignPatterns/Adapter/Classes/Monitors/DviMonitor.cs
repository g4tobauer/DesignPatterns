using DesignPatterns.DesignPatterns.Adapter.Classes.Streams;

namespace DesignPatterns.DesignPatterns.Adapter.Classes.Monitors
{
    public class DviMonitor
    {
        public byte[] _inputStream;
        public void SetInput(DviStream inputStream)
        {
            _inputStream = inputStream.GetData();
        }
    }
}
