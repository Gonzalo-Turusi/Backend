using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Table2
{
    public int Id { get; set; }

    public bool? IsActive { get; set; }

    public int? IdTable1 { get; set; }

    public virtual Table1? IdTable1Navigation { get; set; }
}
