using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp2.Data
{
    public class dbrecord
    {

        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        public dbrecord()
        {

        }
        public List<Student> getData()
        {
            List<Student> students = new List<Student>();

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from student", sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Student student = new Student() { ID = Convert.ToInt32(dataReader[0].ToString()), Name = dataReader[1].ToString() };
                students.Add(student);

            }
            dataReader.Close();
            sqlConnection.Close();


            return students;
        }

        public int executequery(Student student)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into student values(@name)", sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@name", student.Name));
            int norows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
                   
            return norows;
        }
    }
}
    