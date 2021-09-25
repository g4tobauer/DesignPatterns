using DesignPatterns.DesignPatterns.Adapter.Classes.Streams;

namespace DesignPatterns.DesignPatterns.Adapter.Classes.GraphicsCards
{
    public class VgaGraphicsCard
    {
        public VgaStream GetVgaStream()
        {
            var vgaStream = new VgaStream();
            vgaStream.SetData(new byte[] { });

            return vgaStream;
        }
    }
}
