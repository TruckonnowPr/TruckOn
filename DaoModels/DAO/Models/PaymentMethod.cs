namespace DaoModels.DAO.Models
{
    public class PaymentMethod_ST
    {
        public int Id { get; set; }
        public int IdCompany { get; set; }
        public string IdPaymentMethod_ST { get; set; }
        public string IdCustomerAttachPaymentMethod{ get; set; }
        public bool IsDefault { get; set; }
    }
}