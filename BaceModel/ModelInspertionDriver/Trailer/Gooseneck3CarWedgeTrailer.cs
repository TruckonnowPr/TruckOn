using System.Collections.Generic;

namespace BaceModel.ModelInspertionDriver.Trailer
{
    public class Gooseneck3CarWedgeTrailer : ITransportVehicle
    {
        public int CountPhoto { get; set; } = 10;
        public string Type { get; set; } = "Gooseneck3CarWedgeTrailer";
        public bool IsNextInspection { get; set; } = false;
        public List<string> NamePatern { get; set; }
        public string PlateTruck { get; set; }
        public string PlateTraler { get; set; }
        public string TypeTransportVehicle { get; set; } = "Trailer";
        public List<string> Layouts { get; set; }

        public Gooseneck3CarWedgeTrailer()
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