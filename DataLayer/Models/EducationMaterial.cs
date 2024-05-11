using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class EducationMaterial
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateUploaded { get; set; }
        public EducationMaterialType EducationMaterialType { get; set; }

        protected bool Equals(EducationMaterial other)
        {
            return Title == other.Title;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((EducationMaterial)obj);
        }

        public override int GetHashCode()
        {
            return Title.GetHashCode();
        }
    }
}
