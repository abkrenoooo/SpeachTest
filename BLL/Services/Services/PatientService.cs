﻿using Bll.ExtensionMethods;
using BLL.Services.IServices;
using DAL.Models.Patient;
using DAL.Repository.IRepository;
using SpeakEase.DAL.Entities;
using SpeakEase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Services
{
    public class PatientService : IPatientService
    {
        #region Depend Injection

        private readonly IPatientRepo _patientRepo;

        public PatientService(IPatientRepo patientRepo)
        {
            _patientRepo = patientRepo;
        }
        #endregion

        #region Create 

        public async Task<Response<Patient>> CreatePatientAsync(PatientVM patientVM, string id)
        {
            try
            {
                var result = await _patientRepo.Create_PatientAsync(patientVM.ToPatient().Result, id);
                return result;

            }
            catch (Exception e)
            {
                return new Response<Patient>
                {
                    Success = false,
                    error = e.Message
                };
            }
        }
        #endregion

        #region Delete
        public async Task<Response<Patient>> DeletePatientAsync(int Id)
        {
            try
            {
                var result = await _patientRepo.Delete_PatientAsync(Id);
                return result;
            }
            catch (Exception e)
            {
                return new Response<Patient>
                {
                    Success = false,
                    error = e.Message
                };
            }
        }
        #endregion

        #region Get All of Specialist
        public async Task<Response<PatientVM>> GetAllPatientOfSpetialistAsync(string userId, int paggingNumber)
        {
            try
            {
                var result = await _patientRepo.GetAll_PatientAsync(userId, paggingNumber);
                if (result.Success)
                {
                    double pagging = Convert.ToInt32(result.CountOfData) / 10;
                    if (pagging % 10 == 0)
                    {
                        result.paggingNumber = (int)pagging;
                    }
                    else
                    {
                        result.paggingNumber = (int)pagging + 1;
                    }
                }
                return result;

            }
            catch (Exception e)
            {
                return new Response<PatientVM>
                {
                    Success = false,
                    error = e.Message
                };
            }
        }
        #endregion

        #region Get of Specialist

        public async Task<Response<Patient>> GetPatientAsync(string userId, int patientId)
        {
            try
            {
                var result = await _patientRepo.Get_PatientAsync(userId, patientId);
                return result;
            }
            catch (Exception e)
            {
                return new Response<Patient>
                {
                    Success = false,
                    error = e.Message
                };
            }
        }
        #endregion

        #region Get All
        public async Task<Response<Patient>> GetAllPatientAsync( int paggingNumber)
        {
            try
            {
                var result = await _patientRepo.GetAll_PatientAsync(paggingNumber);
                if (result.Success)
                {
                    double pagging = Convert.ToInt32(result.CountOfData) / 10;
                    if (pagging % 10 == 0)
                    {
                        result.paggingNumber = (int)pagging;
                    }
                    else
                    {
                        result.paggingNumber = (int)pagging + 1;
                    }
                }
                return result;

            }
            catch (Exception e)
            {
                return new Response<Patient>
                {
                    Success = false,
                    error = e.Message
                };
            }
        }
        #endregion

        #region Get 

        public async Task<Response<Patient>> GetPatientAsync( int patientId)
        {
            try
            {
                var result = await _patientRepo.Get_PatientAsync( patientId);
                return result;
            }
            catch (Exception e)
            {
                return new Response<Patient>
                {
                    Success = false,
                    error = e.Message
                };
            }
        }
        #endregion

        #region Update 

        public async Task<Response<Patient>> EditPatientAsync(PatientVM patientVM)
        {
            try
            {
                var result = await _patientRepo.EditPatientAsync(patientVM.ToPatient().Result);
                return result;
            }
            catch (Exception e)
            {
                return new Response<Patient>
                {
                    Success = false,
                    error = e.Message
                };
            }
        }
        #endregion
    }
}
