﻿
using DAL.Models.Patient;
using DAL.Models.SpecialistModel;
using SpeakEase.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ExtensionMethods
{
    public static class PatientMapping
    {
        public static async Task<Patient> ToPatient(this PatientVM patientVM)
        {
            return new()
            {
                Note = patientVM.Note,
                HearingTest = patientVM.HearingTest,
                Gender = patientVM.Gender,
                FirstName = patientVM.FirstName,
                LastName = patientVM.LastName,
                BirithDate = patientVM.BirithDate,
                EducationState = patientVM.EducationState,
                OME = patientVM.OME,
                SecondName = patientVM.SecondName,
                SpecialistId = patientVM.SpecialistId,
                PatientId = patientVM.PatientId,
                StartDate = patientVM.StartDate,

            };
        }

        public static async Task<PatientVM> FromPatient(this Patient patient)
        {
            return new()
            {
                Note = patient.Note,
                HearingTest = patient.HearingTest,
                Gender = patient.Gender,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                BirithDate = patient.BirithDate,
                EducationState = patient.EducationState,
                OME = patient.OME,
                SecondName = patient.SecondName,
                StartDate = patient.StartDate,
                SpecialistId = patient.SpecialistId,
                PatientId = patient.PatientId,
                
            };
        }


    }
}
