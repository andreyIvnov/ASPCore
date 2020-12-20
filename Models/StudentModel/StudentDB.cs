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
            _students.Add(new Student() 
            { 
                ID = 007,
                Name ="Andrey Ivanov",
                City = "Ramat Gan",
                Age = 27,
                Phone = "05458946",
                Profile = "https://thumbs.dreamstime.com/b/default-avatar-profile-image-vector-social-media-user-icon-potrait-182347582.jpg"
            });
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
            try
            {
                Student item = _students.FirstOrDefault(s => s.ID == id);
                //item.ID = student.ID;
                item.Name = student.Name;
                item.Age = student.Age;
                item.City = student.City;
                item.Phone = student.Phone;
                item.Profile = student.Profile;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
