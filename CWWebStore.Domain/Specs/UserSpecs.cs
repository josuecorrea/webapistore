using CWWebStore.Domain.Entities;
using CWWebStoreSharedKernel.Helpers;
using System;
using System.Linq.Expressions;

namespace CWWebStore.Domain.Specs
{
    public class UserSpecs
    {
        public static Expression<Func<User, bool>> AuthenticateUser(string email, string password)
        {
            string encriptedPassword = StringHelper.Encrypt(password);
            return x => x.Email == email && x.Password == encriptedPassword;
        }

        public static Expression<Func<User, bool>> GetByEmail(string email)
        {
            return x => x.Email == email;
        }
    }
}