namespace papara_firstweek_hwApp.API.Models
{
    public class UserRepository
    {
        private static readonly List<User> _users = new List<User>();

        public UserRepository()
        {
            if (_users.Count == 0)
            {
                _users.Add(new User { Id=1, Name="Merve", Surname="Saruhan", Age=27 });
                _users.Add(new User { Id=2, Name="Sezen", Surname="Aksu", Age=55 });
                _users.Add(new User { Id=3, Name="Mabel", Surname="Matiz", Age=34 });
                _users.Add(new User { Id=4, Name="Neşe", Surname="Karaböcek", Age=66 });

            }
        }

        public List<User> GetAll()
        { return _users; }

        public  User Add(User user)
        { 
            _users.Add(user);
            return user;
        }

        public void Update(User user)
        {
            var UsertoUpdateIndex = _users.FindIndex(u => u.Id == user.Id);

            _users[UsertoUpdateIndex].Name = user.Name;
            _users[UsertoUpdateIndex].Surname = user.Surname;
            _users[UsertoUpdateIndex].Age = user.Age;

        }
        public void Delete(int id)
        {
            var UsertoDeleteIndex = _users.FindIndex(u => u.Id == id);
            _users.RemoveAt(UsertoDeleteIndex);
        }



    }
}
