using System;
using System.Collections.Generic;

namespace AuthLayer
{
    public class SessionManager : ISessionManager
    {
        private List<Session> _sessions { get; set; }
        //public SessionManager(IFBServices fbService)
        public SessionManager()
        {
            _sessions = new List<Session>()
            {
                new Session() { UserName = "alfredgarcia", Password = "2525", Role = "Admin" }
            };
        }
        public Session ValidateCredentials(string userName, string password)
        {
            //return _fbServices.validateUser(userName, password);
            return _sessions.Find(session => session.UserName == userName && session.Password == password);
        }
        /*public string GetRole()
        {

        }*/
    }
}
