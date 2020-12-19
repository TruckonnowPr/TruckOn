
using System.Collections.Generic;

namespace BaceModel.ModelInspertionDriver.Trailer
{
    public class Bumperpool2CarEeclosedTraile : ITransportVehicle
    {
        public int CountPhoto { get; set; } = 18;
        public string Type { get; set; } = "Bumperpool2CarEeclosedTraile";
        public bool IsNextInspection { get; set; } = false;
        public List<string> NamePatern { get; set; }
        public string PlateTruck { get; set; }
        public string PlateTraler { get; set; }
        public string TypeTransportVehicle { get; set; } = "Trailer";
        public List<string> Layouts { get; set; }

        public Bumperpool2CarEeclosedTraile()
        {
            NamePatern = new List<string>()
            {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
            };
            Layouts = new List<string>()
            {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
            };
        }
    }
}
