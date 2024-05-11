using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        public int TotalPoints { get; set; }
    }
}
