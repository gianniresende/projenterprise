using EnterpriseAPI.Models;
using System;
using System.Linq;
namespace EnterpriseAPI.Services
{
    public class EnterpriseSeguranca
    {
        public static bool Login(string login, string senha)
        {
            using (EnterpriseDBContext entities = new EnterpriseDBContext())
            {
                return entities.Usuarios.Any(user =>
               user.login.Equals(login, StringComparison.OrdinalIgnoreCase)
               && user.senha == senha);
            }
        }
    }
}