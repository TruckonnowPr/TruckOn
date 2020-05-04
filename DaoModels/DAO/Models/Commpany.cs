using DaoModels.DAO.Enum;

namespace DaoModels.DAO.Models
{
    public class Commpany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TypeCompany Type { get; set; }
    }
}