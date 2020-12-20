using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.Models.StudentModel
{
    public interface IStudentDB
    {
        Student GetStudent(int id);
        List<Student> GetStudents();

        void AddStudent(Student student);
        void RemoveStudent(int id);
        void UpdateStudent(Student student, int id);
    }
}
