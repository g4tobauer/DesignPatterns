using DesignPatterns.DesignPatterns.Adapter.Classes.GraphicsCards;
using DesignPatterns.DesignPatterns.Adapter.Classes.Streams;
using System;

namespace DesignPatterns.DesignPatterns.Adapter.Classes.Adapters
{
    public class DviGraphicsCardAdapter
    {
        public DviGraphicsCard _dviGraphicsCard;

        public DviGraphicsCardAdapter(DviGraphicsCard dviGraphicsCard)
        {
            _dviGraphicsCard = dviGraphicsCard;
        }

        public VgaStream GetVgaStream()
        {
            byte[] data = _dviGraphicsCard.GetVgaStream().GetData();

            var vgaStream = new VgaStream();
            //Process and convert the dvi video into the vga video data
            vgaStream.SetData(ConvertFromDviToVga(data));
            return vgaStream;
        }

        private byte[] ConvertFromDviToVga(byte[] input)
        {
            Console.WriteLine("Converted DVI Video to VGA video");
            return new byte[] { };
        }
    }
}
