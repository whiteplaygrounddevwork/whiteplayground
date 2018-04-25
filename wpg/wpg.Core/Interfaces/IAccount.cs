using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace wpg.Core.Interfaces
{
    public interface IAccount
    {
         Task<ResponseViewModal> Register(string email, string password, string returnUrl = null);
        Task<string> Login(string email, string password, bool remeberMe);
    }


    public class ResponseViewModal
    {
        public string Message { get; set; }
        public bool isPassed { get; set; }
    }
}
