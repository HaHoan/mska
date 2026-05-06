using mska_data.Models;
using mska_service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mska_service.Interfaces
{
    public interface IAuthService
    {
        string Login(string username, string password);
        void Logout(string token);
        bool Register(User user);
    }
}
