using System.Collections.Generic;

namespace BaceModel.ModelInspertionDriver.Trailer
{
    public class Gooseneck6CarOpenTrailer : ITransportVehicle
    {
        public int CountPhoto { get; set; } = 8;
        public string Type { get; set; } = "Gooseneck6CarOpenTrailer";
        public bool IsNextInspection { get; set; } = false;
        public List<string> NamePatern { get; set; }
        public string PlateTruck { get; set; }
        public string PlateTraler { get; set; }
        public string TypeTransportVehicle { get; set; } = "Trailer";
        public List<string> Layouts { get; set; }

        public Gooseneck6CarOpenTrailer()
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
                "9",
                "10"
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
                "9",
                "10"
            };
        }
    }
}