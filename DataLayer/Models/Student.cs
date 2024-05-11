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
    }
}
