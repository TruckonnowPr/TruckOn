namespace DaoModels.DAO.DTO
{
    public class PaymentMethodDTO
    {
        public string Id { get; set; }
        public string Country { get; set; }
        public string Brand { get; set; }
        public string Last4 { get; set; }
        public string Name { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string CvcCheck { get; set; }
        public bool IsDefault { get; set; }
    }
}