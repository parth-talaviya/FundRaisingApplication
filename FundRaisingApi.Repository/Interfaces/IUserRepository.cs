using FundRaisingApi.Models.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaisingApi.Repository.Interfaces
{
    public interface IUserRepository
    {
        public Task<int> Registration(UserRegistration userRegistration);
    }
}
