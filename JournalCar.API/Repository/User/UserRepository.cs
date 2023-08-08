using JournalCar.API.Data;
using JournalCar.API.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace JournalCar.API.Repository.User
{
    public class UserRepository : IUserRepository
    {
        private readonly JournalCarDbContext dbContext;

        public UserRepository(JournalCarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Users>> GetAll()
        {
            return await dbContext.User.Include("TypeDoc").ToListAsync();
        }

        public async Task<Users?> Get(Guid id)
        {
           return await dbContext.User.Include("TypeDoc").FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Users> Register(Users user)
        {
            await dbContext.User.AddAsync(user);
            await dbContext.SaveChangesAsync();

            return await dbContext.User.Include("TypeDoc").FirstAsync(x => x.Id == user.Id);
        }

        public async Task Update()
        {
            await dbContext.SaveChangesAsync();
        }

    }
}
