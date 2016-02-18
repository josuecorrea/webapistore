using CWWebStore.Domain.Commands.UserCommands;
using CWWebStore.Domain.Entities;
using CWWebStore.Domain.Repositories;
using CWWebStore.Domain.Services;
using CWWebStore.Infra.Persistence;
using System.Collections.Generic;

namespace CWWebStore.ApplicationService
{
    public class UserApplicationService : ApplicationService, IUserApplicationService
    {
        private IUserRepository _repository;

        public UserApplicationService(IUserRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public User Register(RegisterUserCommand command)
        {
            var user = new User(command.Email, command.Password, command.IsAdmin);
            user.Register();
            _repository.Register(user);

            if (Commit())
                return user;

            return null;
        }

        public User Authenticate(string username, string password)
        {
            return _repository.Authenticate(username, password);
        }

        public List<User> List()
        {
            return _repository.List();
        }
    }
}