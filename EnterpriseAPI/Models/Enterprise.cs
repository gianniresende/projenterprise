using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EnterpriseAPI.Models
{
    [Table("enterprise")]
    public class Enterprise
    {
        [Key]
        public int id { get; set; }
        public string enterprise_name { get; set; }
        public string description { get; set; }
        public string email_enterprise { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string linkedin { get; set; }
        public string phone { get; set; }
        public string own_enterprise { get; set; }
        public string photo { get; set; }
        public int value { get; set; }
        public int shares { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public int id_enterprise_type { get; set; }


    }
}