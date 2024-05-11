using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Student : Person
    {
        public string Jmbag { get; set; } = "";
        public StudyProgram StudyProgram { get; set; }
        public List<Course> Courses { get; set; } 
        public List<EducationMaterial> Materials { get; set; }

        protected bool Equals(Student other)
        {
            return Jmbag == other.Jmbag;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Student)obj);
        }

        public override int GetHashCode()
        {
            return Jmbag.GetHashCode();
        }
    }
}
