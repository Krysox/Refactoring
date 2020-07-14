using System;
using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public class UserService
    {
        public IUserDao userDao;

        public UserService(IUserDao userDao){
            this.userDao = userDao;
        }

        private Boolean IsFriend(User user1, User user2){
            foreach (User friend in user1.GetFriends()) 
            {           
                if(friend.Equals(user2))
                    return true;
            }
             return false;

        }
        public List<Trip> GetTripsByUser(User user, User loggedUser)
        {
                if (this.IsFriend(user, loggedUser))
                {
                    return userDao.FindTripsByUser(user);
                }
                return new List<Trip>();
            }
        }
    }
