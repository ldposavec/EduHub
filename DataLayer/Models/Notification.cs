using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int MyProperty { get; set; }
        public DateTime TimePosted { get; set; }
    }
}
