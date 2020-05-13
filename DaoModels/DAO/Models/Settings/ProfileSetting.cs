using System.Collections.Generic;

namespace DaoModels.DAO.Models.Settings
{
    public class ProfileSetting
    {
        public int Id { get; set; }
        public int IdCompany { get; set; }

        public string TypeTransportVehikle { get; set; }
        public string Name { get; set; }
        public List<TransportVehicle> TransportVehicles { get; set; }
    }
}