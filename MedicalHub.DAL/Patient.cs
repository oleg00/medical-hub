﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalHub.DAL
{
    class Patient
    {
        public Guid Id { get; set; }
        public Contact ContactId { get; set; }
    }
}
