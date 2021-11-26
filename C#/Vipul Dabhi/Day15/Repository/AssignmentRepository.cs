using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day15_Assignment.Models;

namespace Day15_Assignment.Repository
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly EmployeeApiDbContext _context;
        public AssignmentRepository(EmployeeApiDbContext context)
        {
            _context = context;
        }

        public Assignment GetAssignment(long assignmentId, long empid)
        {
            try
            {
                return _context.Assignments.Where(a => a.EmployeeRefId == empid && a.AssignmentId == assignmentId).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<Assignment> GetAssignments(long empId)
        {
            try
            {
                return _context.Assignments.Where(s => s.EmployeeRefId == empId).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool PutAssignment(Assignment assignment)
        {
            try
            {
                var oldAssignment = _context.Assignments.Find(assignment.AssignmentId);
                if (oldAssignment != null)
                {
                    oldAssignment.AssignmentName = assignment.AssignmentName;
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteAssignment(long assignmentId)
        {
            try
            {
                var assignment = _context.Assignments.Find(assignmentId);
                if (assignment != null)
                {
                    assignment.isActive = false;
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}