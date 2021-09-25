using DesignPatterns.DesignPatterns.Adapter.Classes.Streams;

namespace DesignPatterns.DesignPatterns.Adapter.Classes.GraphicsCards
{
    public class DviGraphicsCard
    {
        public DviStream GetVgaStream()
        {
            var dviStream = new DviStream();
            dviStream.SetData(new byte[] { });

            return dviStream;
        }
    }
}
