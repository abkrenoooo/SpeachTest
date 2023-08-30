﻿using DAL.Models.TestModel;
using SpeakEase.DAL.Entities;
using SpeakEase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.IServices
{
    public interface IChearService
    {
        Task<Response<Chear>> CreateChearAsync(ChearVM chear);
        Task<Response<Chear>> DeleteChearAsync(int ChearId);
        Task<Response<Chear>> GetAllChearAsync(int Pagging);
        Task<Response<object>> GetChearAsync(int ChearId);
        Task<Response<Chear>> UpdateChearAsync(int Id, ChearVM chear);
    }
}