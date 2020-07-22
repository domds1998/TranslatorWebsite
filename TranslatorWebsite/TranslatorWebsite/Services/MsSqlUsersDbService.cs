using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TranslatorWebsite.DTOs.Requests;
using TranslatorWebsite.Models;

namespace TranslatorWebsite.Services
{
    public class MsSqlUsersDbService : IUsersDbService
    {
        public IEnumerable<User> GetUsers()
        {
            throw new System.NotImplementedException();
        }

        public User GetUser(int index)
        {
            throw new System.NotImplementedException();
        }

        public User GetUser(string login)
        {
            throw new System.NotImplementedException();
        }

        public void CreateUser(CreateUserRequest request)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUser(DeleteUserRequest request)
        {
            throw new System.NotImplementedException();
        }

        public void ModifyUser(ModifyUserRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}