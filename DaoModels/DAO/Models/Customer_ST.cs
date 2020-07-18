using System;

namespace DaoModels.DAO.Models
{
    public class Customer_ST
    {
        public int Id { get; set; }
        public int IdCompany { get; set; }
        public string NameCompany { get; set; }
        public string NameCompanyST { get; set; }
        public string IdCustomerST { get; set; }
        public DateTime DateCreated { get; set; }
        
    }
}