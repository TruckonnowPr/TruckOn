﻿using System.Collections.Generic;

namespace BaceModel.ModelInspertionDriver.Trailer
{
    public class Gooseneck24_34FtFlatbed : ITransportVehicle
    {
        public int CountPhoto { get; set; } = 9;
        public string Type { get; set; } = "Gooseneck24_34FtFlatbed";
        public bool IsNextInspection { get; set; } = false;
        public List<string> NamePatern { get; set; }
        public string PlateTruck { get; set; }
        public string PlateTraler { get; set; }
        public string TypeTransportVehicle { get; set; } = "Trailer";
        public List<string> Layouts { get; set; }

        public Gooseneck24_34FtFlatbed()
        {
            NamePatern = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9"
            };
            Layouts = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9"
            };
        }
    }
}