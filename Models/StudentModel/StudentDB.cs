using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.Models.StudentModel
{
    public class StudentDB : IStudentDB
    {
        private List<Student> _students;
        public StudentDB()
        {
            _students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            try
            {
                _students.Add(student);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public Student GetStudent(int id)
        {
            try
            {
                return _students.FirstOrDefault(s => s.ID == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Student> GetStudents()
        {
            try
            {
                return _students.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoveStudent(int id)
        {
            try
            {
                var item = _students.Where(s => s.ID == id).FirstOrDefault();
                _students.Remove(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStudent(Student student, int id)
        {
            throw new NotImplementedException();
        }
    }
}
