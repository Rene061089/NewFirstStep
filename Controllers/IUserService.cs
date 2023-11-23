// IUserService.cs
using StepOne.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IUserService
{
    Task<List<User>> GetUsersAsync();
}