using Day17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17.Repository
{
    public class PatientTakesMadicineRepository : GenericRepository<PatientTakesMadicine>,IPatientTakesMadicineRepository
    {
        public PatientTakesMadicineRepository(HospitalContext context) : base(context)
        {
        }
    }
}
