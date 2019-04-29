using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EnterpriseAPI.Models
{
    [Table("enterprise_type")]
    public class Enterprise_type
    {
        [Key]
        public int id { get; set; }
        public string enterprise_type_name { get; set; }       

    }
}