using papara_firstweek_hwApp.API.Models.Shared;

namespace papara_firstweek_hwApp.API.Models.Users
{
    public class UserRepositoryWithSqlServer(AppDbContext context) : IUserRepository
    {
        private readonly AppDbContext _context;
        public User Add(User user)
        {
            _context.Users.Add(user!);
            _context.SaveChanges();
            return user;
        }

        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            _context.Remove(user!);
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User? GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
