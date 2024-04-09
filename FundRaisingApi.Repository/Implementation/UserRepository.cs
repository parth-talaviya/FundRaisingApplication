using Dapper;
using FundRaisingApi.Models.DbModel;
using FundRaisingApi.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FundRaisingApi.Repository.Implementation
{
    public class UserRepository: IUserRepository
    {
        private readonly IConfiguration _configuration;
        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> Registration(UserRegistration userRegistration)
        {
            try
            {
                var parameter =new DynamicParameters();
                using (IDbConnection connection = new SqlConnection(_configuration.GetConnectionString("Default")))
                {
                    connection.Open();
                    parameter.Add("Email", userRegistration.Email);
                    parameter.Add("Password",userRegistration.Password);
                    return await connection.ExecuteAsync("RegisterNewUser", parameter, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
    }
}
