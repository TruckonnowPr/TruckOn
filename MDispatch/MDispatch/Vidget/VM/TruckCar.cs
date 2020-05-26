using System.Collections.Generic;

namespace MDispatch.Vidget.VM
{
    public class TruckCar
    {
        public int CountPhoto { get; set; }
        public string Type { get; set; }
        public bool IsNextInspection { get; set; }
        public List<string> NamePatern { get; set; }
        public List<string> Layouts { get; set; }
        public string PlateTruck { get; set; }
        public string PlateTraler { get; set; }
        public string TypeTransportVehicle { get; set; }
    }
}