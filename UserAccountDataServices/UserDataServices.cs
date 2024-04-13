using System;
using System.Collections;
using System.Collections.Generic;
using UserDataModel;

namespace UserAccountDataServices
{
    public class UserDataServices
    {


        List<Users> users = new List<Users>();

        public UserDataServices()
        {
            CreateUserData();

        }
        private void CreateUserData()
        {


            Users user1 = new Users
            {
                email = "Ellis",
                password = "Arciaga"
            }; users.Add(user1);

            Users user2 = new Users()
            {

                email = "Kea",
                password = "Keaa123"
            }; users.Add(user2);

            Users user3 = new Users()
            {
                email = "lottaeh",
                password = "v123"
            }; users.Add(user3);

        }

        public Users GetUser(string email, string password)
        {
            Users found = new Users();
            foreach (var user in users)
            {
                if (email == user.email && password == user.password)
                {
                    found = user;
                }
            }
            return found;

        }

    }
}