using System.ComponentModel.DataAnnotations.Schema;

namespace DaoModels.DAO.Models.Settings
{
    public class Layouts
    {
        public int Id { get; set; }
        public string Index { get; set; }
        public string Name { get; set; }
        public bool IsUsed { get; set; }
        [NotMapped]
        public string TypeName { get; set; }
    }
}