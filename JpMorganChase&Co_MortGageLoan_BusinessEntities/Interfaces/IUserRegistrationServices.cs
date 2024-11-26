using JpMorganChase_Co_MortGageLoan_BusinessEntities.ModelDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpMorganChase_Co_MortGageLoan_BusinessEntities.Interfaces
{
    public interface IUserRegistrationServices
    {
        Task<List<UserRegistrationDtos>> GetAllUserRegistrations();
        Task<UserRegistrationDtos> GetAllUserRegistrationById(int Id);
        Task<bool> AddUserRegistration(UserRegistrationDtos userregdetail);
        Task<bool> UpdateUserRegistration(UserRegistrationDtos userregdetail);
        Task<bool> DelateUserRegistation(int Id);
    }
}
