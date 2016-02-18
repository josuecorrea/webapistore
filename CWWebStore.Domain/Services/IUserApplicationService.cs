using CWWebStore.Domain.Commands.UserCommands;
using CWWebStore.Domain.Entities;
using System.Collections.Generic;

namespace CWWebStore.Domain.Services
{
    public interface IUserApplicationService
    {
        User Register(RegisterUserCommand command);

        User Authenticate(string email, string password);

        List<User> List();
    }
}