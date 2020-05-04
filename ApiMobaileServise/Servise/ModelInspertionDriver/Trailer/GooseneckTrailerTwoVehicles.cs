using System.Collections.Generic;

namespace ApiMobaileServise.Servise.ModelInspertionDriver.Trailer
{
    public class GooseneckTrailerTwoVehicles : ITransportVehicle
    {
        public int CountPhoto { get; set; } = 9;
        public string Type { get; set; } = "GooseneckTrailerTwoVehicles";
        public bool IsNextInspection { get; set; } = false;
        public List<string> NamePatern { get; set; }
        public string PlateTruck { get; set; }
        public string PlateTraler { get; set; }
        public string TypeTransportVehicle { get; set; } = "Trailer";
        public List<string> Layouts { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public GooseneckTrailerTwoVehicles()
        {
            NamePatern = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "7",
                "8",
                "9",
                "10",
            };
        }
    }
}