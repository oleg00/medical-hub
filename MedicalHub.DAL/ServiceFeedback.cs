using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalHub.DAL
{
    class ServiceFeedback
    {
        public Guid Id { get; set; }
        public Contact ContactId { get; set; }
        public int Rate { get; set; }
        public string FeedbackMessage { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
