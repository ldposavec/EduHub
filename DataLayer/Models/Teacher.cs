using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Teacher : Person
    {
        public Course? Course { get; set; }
        public List<Notification> Notifications { get; set; }
        public List<EducationMaterial> Materials { get; set; }
    }
}
