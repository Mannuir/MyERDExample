using System.ComponentModel.DataAnnotations;
using System;

namespace codeFirstN2idis.DataModels
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PIC { get; set; }
        public string Address { get; set; }

        public Branch Branch { get; set; }
        public Department Department { get; set; }
        public Position Position { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }



        public Enums.Access Class { get; set; }
        
    }
}
