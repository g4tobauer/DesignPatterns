using DesignPatterns.DesignPatterns.Adapter.Classes.GraphicsCards;
using DesignPatterns.DesignPatterns.Adapter.Classes.Streams;
using System;

namespace DesignPatterns.DesignPatterns.Adapter.Classes.Adapters
{
    public class VgaGraphicsCardAdapter
    {
        public VgaGraphicsCard _vgaGraphicsCard;

        public VgaGraphicsCardAdapter(VgaGraphicsCard vgaGraphicsCard)
        {
            _vgaGraphicsCard = vgaGraphicsCard;
        }

        public DviStream GetDviStream()
        {
            byte[] data = _vgaGraphicsCard.GetVgaStream().GetData();

            var dviStream = new DviStream();
            //Process and convert the vga video into the dvi video data
            dviStream.SetData(ConvertFromVgaToDvi(data));
            return dviStream;
        }

        private byte[] ConvertFromVgaToDvi(byte[] input)
        {
            Console.WriteLine("Converted VGA Video to DVI video");
            return new byte[] { };
        }
    }
}
