using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalHub.DAL
{
    public class DoctorVisitPrice
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorCategoryId { get; set; }
        public DoctorCategory DoctorCategory { get; set; }
    }
}
