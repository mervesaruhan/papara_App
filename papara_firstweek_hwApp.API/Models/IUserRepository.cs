namespace papara_firstweek_hwApp.API.Models
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User Add(User user);
        void Update(User user);
        void Delete(User user);

    }
}
