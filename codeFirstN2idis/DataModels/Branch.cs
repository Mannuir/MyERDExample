using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstN2idis.DataModels
{
   public class Branch
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Props { get; set; }
        public Company Company { get; set; }}

   

    }

