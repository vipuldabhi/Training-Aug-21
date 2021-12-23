using Microsoft.EntityFrameworkCore;
using StudentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repository
{
    public class EmergencyRepository : IEmergencyRepository
    {
        private readonly StudentDatabaseContext _studentDatabaseContext;

        public EmergencyRepository(StudentDatabaseContext studentDatabaseContext)
        {
            _studentDatabaseContext = studentDatabaseContext;
        }

        public async Task<IEnumerable<Emergency>> GetEmergencyContacts()
        {
            return await _studentDatabaseContext.Emergencies.ToListAsync();
        }

    }
}
