using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EnterpriseAPI.Models
{
    [Table("users")]
    public class Users
    {
        [Key]
        public int user_Id { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string email { get; set; }  

    }
}