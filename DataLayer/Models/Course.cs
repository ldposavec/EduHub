using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ects { get; set; }
        public List<Outcome> Outcomes { get; set; }
        public Teacher Teacher { get; set; }
        public Grade Grade { get; set; }
        public StudyProgram StudyProgram { get; set; }
    }
}
