using System;
using Xunit;
using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class Tests
    {
        [Fact]
        public void CheckTripListIsEmpty()
        {

            User user = new User();
            User user1 = new User();
            IUserDao userDao = new UserDao();

            IUserSession userSessionMock = new UserSessionMock(user);

            UserService userService = new UserService(userDao);

            List<Trip> trips = userService.GetTripsByUser(user, user1);
            Assert.Equal(0, (int)trips.Count);

        }
            
        [Fact]
        public void CheckTripListIsNotEmpty()
        {

            User user = new User();
            User user1 = new User();
            IUserDao userDao = new UserDaoMock();

            user.AddFriend(user1);

            IUserSession userSessionMock = new UserSessionMock(user);

            UserService userService = new UserService(userDao);

            List<Trip> trips = userService.GetTripsByUser(user, user1);
            
            Assert.Equal(5, (int)trips.Count);

        }


    }
}

