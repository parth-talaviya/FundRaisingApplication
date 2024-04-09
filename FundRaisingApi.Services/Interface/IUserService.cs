using FundRaisingApi.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaisingApi.Services.Interface
{
    public interface IUserService
    {
        public Task<int> Registration(UserRegistrationViewModel userRegistration);
    }
}
