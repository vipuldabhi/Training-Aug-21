using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day15_Assignment.Models;

namespace Day15_Assignment.Repository
{
    public interface IAssignmentRepository
    {
        IEnumerable<Assignment> GetAssignments(long empId);
        Assignment GetAssignment(long assignmentId, long empid);
        bool PutAssignment(Assignment assignment);
        bool DeleteAssignment(long assignmentId);

    }
}