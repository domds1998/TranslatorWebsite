using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TranslatorWebsite.DTOs.Requests;
using TranslatorWebsite.Models;

namespace TranslatorWebsite.Services
{
    public interface IUsersDbService
    {
        public IEnumerable<User> GetUsers();
        
        public User GetUser(int index);
        
        public User GetUser(string login);

        public void CreateUser(CreateUserRequest request);

        public void DeleteUser(DeleteUserRequest request);

        public void ModifyUser(ModifyUserRequest request);

    }
}