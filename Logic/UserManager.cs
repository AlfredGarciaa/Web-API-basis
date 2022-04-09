using System;
using System.Collections.Generic;

namespace Logic
{
    public class UserManager : IUserManager
    {
        public List<User> Users { get; set; }
        //public UserManager(IDbLayer dbLayer)
        public UserManager()
        {
            Users = new List<User>()
            {
                new User() { Ci = 75461, Name = "Alvaro", LastName = "Urpita"},
                new User() { Ci =29101, Name = "Estefani", LastName = "Omonte"},
                new User() { Ci =17156, Name = "Ivan", LastName = "Iskay"},
                new User() { Ci =54297, Name = "Oscar", LastName = "Epifania"},
                new User() { Ci =01020, Name = "Ursoc", LastName = "Amparo"},
            };
        }
        public List<User> GetUsers()
        {
            // Sacamos de una CAPA PERSISTIDA, no me alcanzo el tiempo
            //List<User> users = _dbLayer.GetUser();
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
