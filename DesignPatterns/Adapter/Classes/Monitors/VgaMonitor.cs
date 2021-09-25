using DesignPatterns.DesignPatterns.Adapter.Classes.Streams;

namespace DesignPatterns.DesignPatterns.Adapter.Classes.Monitors
{
    public class VgaMonitor
    {
        public byte[] _inputStream;
        public void SetInput(VgaStream inputStream)
        {
            _inputStream = inputStream.GetData();
        }
    }
}
