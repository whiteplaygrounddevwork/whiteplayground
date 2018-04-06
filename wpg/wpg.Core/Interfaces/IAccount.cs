using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace wpg.Core.Interfaces
{
    public interface IAccount
    {
         Task<string> Register(string email, string password, string returnUrl = null);
        Task<string> Login(string email, string password, bool remeberMe);
    }
}
