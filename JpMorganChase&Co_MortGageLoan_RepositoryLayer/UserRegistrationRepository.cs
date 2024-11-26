﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JpMorganChase_Co_MortGageLoan_BusinessEntities.Interfaces;
using JpMorganChase_Co_MortGageLoan_DBContext.HotelmanagementContext;
using Microsoft.EntityFrameworkCore;
namespace JpMorganChase_Co_MortGageLoan_RepositoryLayer
{
    public class UserRegistrationRepository: IUserRegistrationRepository
    {
        public HotelmanagementContext _htmlmanagmtcon;
        public UserRegistrationRepository(HotelmanagementContext htmlmanagmtcon)
        {
            _htmlmanagmtcon = htmlmanagmtcon;
        }
        public async Task<bool> AddUserRegistration(UserRegistration userregdetail)
        {
            await _htmlmanagmtcon.UserRegistrations.AddAsync(userregdetail);
            _htmlmanagmtcon.SaveChanges();
            return true;
        }

        public async Task<bool> DelateUserRegistation(int Id)
        {
            UserRegistration ur = _htmlmanagmtcon.UserRegistrations.SingleOrDefault(e => e.Id == Id);
            if (ur != null)
            {
                _htmlmanagmtcon.UserRegistrations.Remove(ur);
                _htmlmanagmtcon.SaveChanges();
                return true;
            }
            else return false;
        }

        public async Task<UserRegistration> GetAllUserRegistrationById(int Id)
        {
            var rm = await _htmlmanagmtcon.UserRegistrations.Where(e => e.Id == Id).FirstOrDefaultAsync();

            if (rm == null)
                return null;
            else
                return rm;
        }

        public async Task<List<UserRegistration>> GetAllUserRegistrations()
        {
            var rm = _htmlmanagmtcon.UserRegistrations.ToList();
            if (rm.Count == 0)
                return null;
            else return rm;
        }

        public async Task<bool> UpdateUserRegistration(UserRegistration userregdetail)
        {
            _htmlmanagmtcon.Update(userregdetail);
            await _htmlmanagmtcon.SaveChangesAsync();
            return true;
        }
    }
}
