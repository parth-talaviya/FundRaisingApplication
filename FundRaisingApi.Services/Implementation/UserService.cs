using FundRaisingApi.Models.ViewModel;
using FundRaisingApi.Models.DbModel;
using FundRaisingApi.Services.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundRaisingApi.Repository.Interfaces;

namespace FundRaisingApi.Services.Implementation
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<int> Registration(UserRegistrationViewModel userRegistration)
        {
            try
            {
                var userReg = new UserRegistration()
                {
                    Email = userRegistration.Email,
                    Password = BCrypt.Net.BCrypt.HashPassword(userRegistration.Password),
                };
                var result = await _userRepository.Registration(userReg);
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
           
        }
    }
}
