﻿namespace Info.Classes
{
    internal class FirebaseInformation
    {
        public string OperationSystem { get; set; }
        public string Motherboard { get; set; }
        public string CPU { get; set; }
        public string Monitor { get; set; }
        public string RAM { get; set; }
        public string Drives { get; set; }
        public string GPU { get; set; }

        public FirebaseInformation()
        {
            OperationSystem = Hardware.OperationSystem;
            Motherboard = Hardware.Motherboard;
            CPU = Hardware.CPU;
            Monitor = Hardware.Monitor;
            RAM = Hardware.RAM;
            Drives = Hardware.Drives;
            GPU = Hardware.GPU;
        }
    }
}
