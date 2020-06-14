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
                "Front left corner of the trailer",     
                "The whole left side of the trailer",   
                "The first left wheel of the trailer",  
                "The second left wheel of the trailer",
                "Rear left corner of the trailer",     
                "Back of trailer",                      
                "Trailer interior",                    
                "Outdoor trailer with ramp",          
                "Rear right corner of the trailer",    
                "The whole right side of the trailer",  
                "The second right wheel of the trailer",
                "The first right wheel of the trailer", 
                "Front right corner of the trailer",    
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
            };
        }
    }
}