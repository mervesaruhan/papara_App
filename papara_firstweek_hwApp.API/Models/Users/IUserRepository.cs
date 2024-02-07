namespace papara_firstweek_hwApp.API.Models.Users
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User Add(User user);
        void Update(User user);
        void Delete(int id);
        User? GetById(int id);
    }
}
