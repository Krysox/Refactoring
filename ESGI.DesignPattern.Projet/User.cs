using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{

    public interface IUserSession {
        bool IsUserLoggedIn(User user1);
        User GetLoggedUser();
    }
    public class UserSession: IUserSession
    {
        public bool IsUserLoggedIn(User user)
        {
            throw new DependendClassCallDuringUnitTestException(
                "UserSession.IsUserLoggedIn() should not be called in an unit test");
        }

        public User GetLoggedUser()
        {
            throw new DependendClassCallDuringUnitTestException(
                "UserSession.GetLoggedUser() should not be called in an unit test");
        }
    }

     public class UserSessionMock: IUserSession
    {
        private User user;
        public UserSessionMock(User user){
            this.user = user;
        }

        public bool IsUserLoggedIn(User user){
            return true;
        }

        public User GetLoggedUser(){
            return this.user;
        }
    }

    public class User
    {
        private List<User> friends = new List<User>();

        public List<User> GetFriends()
        {
            return friends;
        }

        public void AddFriend(User user)
        {
            friends.Add(user);
        }

    }
}
