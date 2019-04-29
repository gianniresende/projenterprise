using System.Data.Entity;
namespace EnterpriseAPI.Models
{
    public class EnterpriseDBContext : DbContext
    {
        public EnterpriseDBContext() : base("name=EnterpriseDBContext")
        { }
        public virtual DbSet<Enterprise> Enterprise { get; set; }
        public virtual DbSet<Users> Usuarios { get; set; }
    }
}