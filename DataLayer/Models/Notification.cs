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
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime TimePosted { get; set; }

        protected bool Equals(Notification other)
        {
            return Title == other.Title;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Notification)obj);
        }

        public override int GetHashCode()
        {
            return Title.GetHashCode();
        }
    }
}
