using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstN2idis.DataModels
{
    public class Vacation
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public Department Department { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DaysLeftCount { get; set; }

    }
}
