using Day11.Models;
using System;
using System.Linq;

namespace Day11
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new HospitalContext())
            //{
            //    var doctors = context.Doctors.Where(s => s.DoctorId == 1).ToList();

            //    foreach (var i in doctors) 
            //    {
            //        Console.WriteLine(i.DoctorId);

            //    }
            //}


            //Insert Doctor


            //using (var context = new HospitalContext())
            //{
            //    var doctor = new Doctors()
            //    {
            //        DoctorId = 4,
            //        FirstName = "Nayan",
            //        LastName = "Shah",
            //        Designation = "MBBS",
            //        YearOfExperience = 11,
            //        Department = 101,
            //        IsActive = true
            //    };

            //    context.Doctors.Add(doctor);
            //    context.SaveChanges();
            //    Console.WriteLine("Doctor Insert SuccessFully");
            //}


            //Update Doctor


            //using (var context = new HospitalContext())
            //{
            //    var doctor = context.Doctors.First<Doctors>();
            //    doctor.FirstName = "Mehul";
            //    doctor.LastName = "Jha";
            //    doctor.Designation = "BHMS";
            //    doctor.YearOfExperience = 6;
            //    doctor.Department = 102;
            //    doctor.IsActive = true;

            //    context.SaveChanges();
            //    Console.WriteLine("Doctor Updated SuccessFully");
            //}


            //Delete Doctor


            //using (var context = new HospitalContext())
            //{
            //    var doctor = context.Doctors.Where(s => s.DoctorId == 4);
            //    context.Doctors.Remove(doctor);

            //    context.SaveChanges();
            //    Console.WriteLine("Doctor Deleted SuccessFully");
            //}

            //Find a report of patient assigned to a particular doctor

            using (var context = new HospitalContext())
            {
                Console.WriteLine("Enter Doctor ID For Which You Want Report");
                int doctorid =Convert.ToInt32(Console.ReadLine());

                var patient = context.PatientWithTreatementDetails.Where(s => s.Doctor == doctorid).ToList();

                foreach (var i in patient)
                {
                    Console.WriteLine("PatientID is :{0}, PatientName is :{1},TreatementId is {2},DoctorID is :{3} ,Assistence is :{4},TreatementDate is :{5}", i.PatientId,i.FirstName,i.TreatementId,i.Doctor,i.Assistance,i.TreatementDate);
                }
            }

            //Find a report of medicine list for a particular patient


            //using (var context = new HospitalContext())
            //{
            //    Console.WriteLine("Enter Patient Id For Which You Want Medicine Report");
            //    int patientid =Convert.ToInt32(Console.ReadLine());

            //    var medicinereport = context.PatientTakesMadicine.Where(s => s.Patient == patientid).ToList();

            //    foreach (var i in medicinereport)
            //    {
            //        Console.WriteLine("id is :{0}, PatientID is :{1}, Drug is :{2}, StartDate is :{3} ,EndDate is :{4}",i.Id.ToString(),i.Patient,i.Drug,i.StartDate,i.EndDate);

            //    }
            //}


            //Display summary report of Doctor and patient


            //using (var context = new HospitalContext())
            //{
            //    Console.WriteLine("Enter Doctor Name For Which You Want Report");
            //    string doctorname = Console.ReadLine();

            //    var patientreport = context.DoctorWithPatient.Where(s => s.DoctorName == doctorname).ToList();

            //    foreach (var i in patientreport)
            //    {
            //        Console.WriteLine("DoctorName is :{0}, PatientName is :{1}, AssistanceID is :{2}, TreatementDate is :{3}", i.DoctorName, i.PatientName, i.AssistantId, i.TreatementDate);

            //    }
            //}

            Console.WriteLine();
        }
    }
}
