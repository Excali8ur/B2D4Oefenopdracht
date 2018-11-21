using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WishlistInterfaces
{
    /// <summary>
    /// Interface to log in to the app
    /// </summary>
    public interface iLogin
    {
        /// <summary>
        /// Method to login into the app.
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>On succes: return True</returns>
        bool Login(string username, string password);

        /// <summary>
        /// Changes the name of the user
        /// </summary>
        /// <param name="oldUsername">Previous name</param>
        /// <param name="newUsername">New name</param>
        void ChangeUsername(string oldUsername, string newUsername);

    }
}
