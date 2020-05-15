using DaoModels.DAO.Models.Settings;
using System.Collections.Generic;

namespace DaoModels.DAO.DTO
{
    public class ProfileSettings
    {
        public int Id { get; set; }
        public int IdCompany { get; set; }
        public string TypeTransportVehikle { get; set; }
        public string Name { get; set; }
        public bool IsChange { get; set; }
        public bool IsSelect { get; set; }
        public bool IsUsed { get; set; }
        public List<TransportVehicle> TransportVehicles { get; set; }

    }
}