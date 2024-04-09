using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaisingApi.Models.ViewModel
{
    public class UserRegistrationViewModel
    {
        public long User_Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
