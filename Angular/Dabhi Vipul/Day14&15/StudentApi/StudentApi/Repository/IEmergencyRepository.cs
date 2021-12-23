using StudentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repository
{
    public interface IEmergencyRepository
    {
        Task<IEnumerable<Emergency>> GetEmergencyContacts();
    }
}
