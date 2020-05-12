using System.Collections.Generic;

namespace BaceModel.ModelInspertionDriver.Trailer
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
        public List<string> Layouts { get; set; }

        public GooseneckTrailerTwoVehicles()
        {
            NamePatern = new List<string>()
            {
                "Front left corner of the trailer",     //1
                "The whole left side of the trailer",   //2
                "The first left wheel of the trailer",  //3
                "The second left wheel of the trailer", //4
                "Back of trailer",                      //5
                "The whole right side of the trailer",  //6
                "The second right wheel of the trailer",//7
                "The first right wheel of the trailer", //8
                "Front right corner of the trailer",    //9
            };
        }
    }
}