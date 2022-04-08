﻿using System;
using System.Collections.Generic;

namespace Logic
{
    public class UserManager
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
        public User PostUsers(User user)
        {
            Users.Add(user);
            return user;
        }
        public User PutUsers(User user)
        {
            return null;
        }
        public User DeleteUsers(User user)
        {
            return null;
        }
    }
}
