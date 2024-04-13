using System;
using UserAccountDataServices;

namespace UserAccountBusiness
{
    public class UserBusiness
    {
        public bool VerifyUser(string username, string password)
        {
            UserDataServices dataService = new UserDataServices();
            var result = dataService.GetUser(username, password);
            
            return result.email != null ? true: false && result.password != null ? true:false;

        }

    }
}
