using Day17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17.Repository
{
    public class PatientWithTreatmentDetailsRepository : GenericRepository<PatientWithTreatementDetail>, IPatientWithTreatmentDetailsRepository
    {
        public PatientWithTreatmentDetailsRepository(HospitalContext context) : base(context)
        {
        }
    }
}
