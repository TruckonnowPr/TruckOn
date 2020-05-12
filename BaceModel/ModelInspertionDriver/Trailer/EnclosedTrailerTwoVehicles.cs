using System.Collections.Generic;

namespace BaceModel.ModelInspertionDriver.Trailer
{
    public class EnclosedTrailerTwoVehicles : ITransportVehicle
    {
        public int CountPhoto { get; set; } = 13;
        public string Type { get; set; } = "EnclosedTrailerTwoVehicles";
        public bool IsNextInspection { get; set; } = false;
        public List<string> NamePatern { get; set; }
        public string PlateTruck { get; set; }
        public string PlateTraler { get; set; }
        public string TypeTransportVehicle { get; set; } = "Trailer";
        public List<string> Layouts { get; set; }

        public EnclosedTrailerTwoVehicles()
        {
            NamePatern = new List<string>()
            {
                "Front left corner of the trailer",     //1
                "The whole left side of the trailer",   //2
                "The first left wheel of the trailer",  //3
                "The second left wheel of the trailer", //4
                "Rear left corner of the trailer",      //5
                "Back of trailer",                      //6
                "Trailer interior",                     //7
                "Outdoor trailer with ramp",            //8
                "Rear right corner of the trailer",     //9
                "The whole right side of the trailer",  //10
                "The second right wheel of the trailer",//11
                "The first right wheel of the trailer", //12
                "Front right corner of the trailer",    //13
            };
            Layouts = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
            };
        }
    }
}