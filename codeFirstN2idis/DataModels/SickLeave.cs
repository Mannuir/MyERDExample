using codeFirstN2idis.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstN2idis.DataModelsõ
{
    public class SickLeave
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime SickLeaveBegin { get; set; }
        public DateTime SickLeaveEnd { get; set; }
        public Employee Employee { get; set; }
    }
}
