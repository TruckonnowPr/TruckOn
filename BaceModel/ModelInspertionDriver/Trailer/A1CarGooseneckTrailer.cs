using System.Collections.Generic;

namespace BaceModel.ModelInspertionDriver.Trailer
{
    public class A1CarGooseneckTrailer : ITransportVehicle
    {
        public int CountPhoto { get; set; } = 15;
        public string Type { get; set; } = "a1CarGooseneckTrailer";
        public bool IsNextInspection { get; set; } = false;
        public List<string> NamePatern { get; set; }
        public string PlateTruck { get; set; }
        public string PlateTraler { get; set; }
        public string TypeTransportVehicle { get; set; } = "Trailer";
        public List<string> Layouts { get; set; }

        public A1CarGooseneckTrailer()
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
                "10",
                "11",
                "12",
                "13",
                "14",
                "15"
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
                "10",
                "11",
                "12",
                "13",
                "14",
                "15"
            };
        }
    }
}