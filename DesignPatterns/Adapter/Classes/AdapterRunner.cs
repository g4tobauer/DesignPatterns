using DesignPatterns.DesignPatterns.Adapter.Classes.Adapters;
using DesignPatterns.DesignPatterns.Adapter.Classes.GraphicsCards;
using DesignPatterns.DesignPatterns.Adapter.Classes.Monitors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.Adapter.Classes
{
    public class AdapterRunner : IRunner
    {
        public void Run()
        {
            VgaToDvi();
            DviToVga();
        }

        private void VgaToDvi()
        {
            var vgaGraphicsCard = new VgaGraphicsCard();
            var vgaGraphicsCardAdapter = new VgaGraphicsCardAdapter(vgaGraphicsCard);
            var dviMonitor = new DviMonitor();
            dviMonitor.SetInput(vgaGraphicsCardAdapter.GetDviStream());
        }
        private void DviToVga()
        {
            var dviGraphicsCard = new DviGraphicsCard();
            var dviGraphicsCardAdapter = new DviGraphicsCardAdapter(dviGraphicsCard);
            var vgaMonitor = new VgaMonitor();
            vgaMonitor.SetInput(dviGraphicsCardAdapter.GetVgaStream());
        }
    }
}
