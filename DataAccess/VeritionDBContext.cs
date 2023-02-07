using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Configuration;

namespace DataAccess
{
    public class VeritionDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string conStr = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            optionsBuilder.UseSqlite(conStr);
        }
        private DbSet<UserInformation>? _userInformation;
        internal DbSet<UserInformation>? UserInformationDB
        {
            get
            {
                return _userInformation;
            }
            set
            {
                _userInformation = value;
            }
        }
    }
}