using System;
using System.Collections.Generic;

namespace Logic
{
    public class UserManager : IUserManager
    {
        public List<User> Users { get; set; }
        public UserManager()
        {
            Users = new List<User>()
            {
                new User() { Name = "Alvaro" },
                new User() { Name = "Estefani" },
                new User() { Name = "Ivan" },
                new User() { Name = "Oscar" },
                new User() { Name = "Ursoc" }
            };
        }
        public List<User> GetUsers()
        {
            return Users;
        }
        public User PostUser(User user)
        {
            Users.Add(user);
            return user;
        }
        public User PutUser(User user)
        {
            return null;
        }
        public User DeleteUser(User user)
        {
            return null;
        }
    }
}
