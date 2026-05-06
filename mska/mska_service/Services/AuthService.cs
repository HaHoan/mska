using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using mska_data.Models;
using mska_data.UnitOfWork;
using mska_service.DTOs;
using mska_service.Interfaces;
using mska_service.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


public class AuthService : IAuthService
{
    private readonly IUnitOfWork _uow;
    private readonly JwtService _jwtService;

    public AuthService(IUnitOfWork uow, JwtService jwtService)
    {
        _uow = uow;
        _jwtService = jwtService;
    }

    public string? Login(string username, string password)
    {
        var user = _uow.Users.GetByUsername(username);

        if (user == null || user.Password != password)
            return null;
        return user.UserRole;
        //return _jwtService.GenerateToken(user);
    }
    public void Logout(string token)
    {
       
    }
    public bool Register(User user)
    {
        try
        {
             _uow.BeginTransaction();

             _uow.Users.Add(user);

             _uow.SaveChanges();

             _uow.Commit();

            return true;
        }
        catch
        {
             _uow.Rollback();
            return false;
        }
    }

}