﻿using DAL.Models.SpecialistModel;
using SpeakEase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.IServices
{
    public interface IAdminSevices
    {
        Task<Response<AdminUserVM>> AddAdminUserAsync(AdminUserVM model);
    }
}
