using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika7
{
    public class TabletForm
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string OS { get; set; }
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public bool HasCamera { get; set; }
        public bool HasSIMSlot { get; set; }

        public TabletForm()
        {

        }

        public TabletForm(string brand, string model, string os, string processor, string ram, string storage, bool hasCamera, bool hasSIMSlot)
        {
            Brand = brand;
            Model = model;
            OS = os;
            Processor = processor;
            RAM = ram;
            Storage = storage;
            HasCamera = hasCamera;
            HasSIMSlot = hasSIMSlot;
        }
    }
}