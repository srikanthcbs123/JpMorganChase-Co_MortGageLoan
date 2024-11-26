using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JpMorganChase_Co_MortGageLoan_DBContext.HotelmanagementContext;
namespace JpMorganChase_Co_MortGageLoan_BusinessEntities.Interfaces
{
    public interface IUserRegistrationRepository
    {
        Task<List<UserRegistration>> GetAllUserRegistrations();
        Task<UserRegistration> GetAllUserRegistrationById(int Id);
        Task<bool> AddUserRegistration(UserRegistration userregdetail);
        Task<bool> UpdateUserRegistration(UserRegistration userregdetail);
        Task<bool> DelateUserRegistation(int Id);
    }
}
