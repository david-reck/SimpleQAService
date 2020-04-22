using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QAService.Application.Models
{
    public class PatientDTO
    {

        public Int64 PatientId { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        
    }
}
