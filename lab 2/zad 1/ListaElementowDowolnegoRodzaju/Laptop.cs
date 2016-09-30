using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaElementowDowolnegoRodzaju
{
    class Laptop
    {
        String brand;
        String model;
        String processor;
        String graphics;
        String memoryRAM;
        String imageSource;

        [System.ComponentModel.DisplayName("Marka")]
        public String Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        [System.ComponentModel.DisplayName("Model")]
        public String Model
        {
            get { return model; }
            set { model = value; }
        }

        [System.ComponentModel.DisplayName("Procesor")]
        public String Processor
        {
            get { return processor; }
            set { processor = value; }
        }

        [System.ComponentModel.DisplayName("Grafika")]
        public String Graphics
        {
            get { return graphics; }
            set { graphics = value; }
        }

        [System.ComponentModel.DisplayName("RAM")]
        public String MemoryRAM
        {
            get { return memoryRAM; }
            set { memoryRAM = value; }
        }

        public String ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; }
        }
    }
}
