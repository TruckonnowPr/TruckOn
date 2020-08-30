using System.Collections.Generic;

namespace DaoModels.DAO.Models
{
    public class Dispatcher
    {
        public int Id { get; set; }
        public int IdCompany { get; set; }
        public string Type { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Users> Users { get; set; }
    }
}