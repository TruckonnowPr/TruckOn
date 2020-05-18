namespace DaoModels.DAO.Models.Settings
{
    public class ProfileSetting
    {
        public int Id { get; set; }
        public int IdCompany { get; set; }
        public int IdTr { get; set; }
        public string TypeTransportVehikle { get; set; }
        public string Name { get; set; }
        public bool IsUsed { get; set; }
        public TransportVehicle TransportVehicle { get; set; }
    }
}