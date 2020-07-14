using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public interface IUserDao {
        List<Trip> FindTripsByUser(User user1);
    }
    public class UserDao: IUserDao
    {
        
        public List<Trip> FindTripsByUser(User user)
        {
            throw new DependendClassCallDuringUnitTestException(
                        "TripDAO should not be invoked on an unit test.");
        }
    }
    public class UserDaoMock: IUserDao
    {
        public List<Trip> FindTripsByUser(User user){
            return new List<Trip>(){
                new Trip("Barcelona"),
                new Trip("Nice"),
                new Trip("Las Vegas"),
                new Trip("Los Angeles"),
                new Trip("Marrakech")
            };
        }

    }
}
