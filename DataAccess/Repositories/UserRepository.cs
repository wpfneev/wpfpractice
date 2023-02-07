using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.EntityFrameworkCore.Storage;

namespace DataAccess.Repositories
{
    public class UserRepository : IRepository<UserInformation>
    {
        VeritionDBContext dBContext;
        public UserRepository(VeritionDBContext context)
        {
            dBContext = context;
        }
        public void Add(UserInformation entity)
        {
            entity.UserId = Guid.NewGuid().ToString();
            dBContext.UserInformationDB?.Add(entity);
            dBContext.SaveChanges();
        }

        public UserInformation Get(string id)
        {
            UserInformation user = null;
            if(dBContext.UserInformationDB.Any(p=>p.UserId.Equals(id)))
            {
                user = dBContext.UserInformationDB.First(user => user.UserId == id);
            }

            return user;
        }

        public IEnumerable<UserInformation> GetAll()
        {
            return dBContext.UserInformationDB.ToList();
        }

        public void Update(UserInformation entity)
        {
            
            //dBContext.Entry<UserInformation>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            dBContext.UserInformationDB.Update(entity);
            dBContext.SaveChanges();
        }
        public void Delete(UserInformation entity)
        {
            dBContext.UserInformationDB.Remove(entity);
            dBContext.SaveChanges();
        }
    }
}
