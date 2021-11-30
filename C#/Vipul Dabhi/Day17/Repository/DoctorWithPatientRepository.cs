using Day17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17.Repository
{
    public class DoctorWithPatientRepository : GenericRepository<DoctorWithPatient>,IDoctorWithPatientRepository
    {
        public DoctorWithPatientRepository(HospitalContext context) : base(context)
        {
        }

    }
}
