using System;

namespace DaoModels.DAO.Models
{
    public class Subscribe_ST
    {
        public int Id { get; set; }
        public string IdCustomer { get; set; }
        public string IdSubscribe { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime CurrentPeriodEnd { get; set; }
        public DateTime CurrentPeriodStart { get; set; }
        public string Status { get; set; }
    }
}