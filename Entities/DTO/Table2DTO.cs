using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class Table2DTO
    {
        public int Id { get; set; }
        public bool? IsActive { get; set; }
        public int? IdTable1 { get; set; }
    }
}
