namespace papara_firstweek_hwApp.API.Models.Users
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> Users = new();

        public UserRepository()
        {
            if (Users.Count == 0)
            {
                Users.Add(new User { Id = 1, Name = "Merve", Surname = "Saruhan", Age = 27 });
                Users.Add(new User { Id = 2, Name = "Sezen", Surname = "Aksu", Age = 55 });
                Users.Add(new User { Id = 3, Name = "Mabel", Surname = "Matiz", Age = 34 });
                Users.Add(new User { Id = 4, Name = "Neşe", Surname = "Karaböcek", Age = 66 });

            }
        }

        public List<User> GetAll()
        { return Users; }

        public User Add(User user)
        {
            Users.Add(user);
            return user;
        }

        public void Update(User user)
        {
            var UsertoUpdateIndex = Users.FindIndex(u => u.Id == user.Id);

            Users[UsertoUpdateIndex].Name = user.Name;
            Users[UsertoUpdateIndex].Surname = user.Surname;
            Users[UsertoUpdateIndex].Age = user.Age;

        }
        public void Delete(int id)
        {
            var UsertoDeleteIndex = Users.FindIndex(u => u.Id == id);
            Users.RemoveAt(UsertoDeleteIndex);
        }

        public User? GetById(int id)
        {
            return Users.FirstOrDefault(u => u.Id == id);
        }



    }
}
