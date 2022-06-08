using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstN2idis.DataModels
{
    public class Position
    {
        [Key]
        public Guid Id { get; set; }
        public string JobTitle { get; set; }

        public string Comment { get; set; }
    }
}
