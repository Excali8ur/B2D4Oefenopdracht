using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WishlistInterfaces;

namespace WishlistLib.User
{
    public class User : iLogin
    {
        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void ChangeUsername(string oldUsername, string newUsername)
        {
            throw new NotImplementedException();
        }
    }
}
