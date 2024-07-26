using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Table1
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ICollection<Table2> Table2s { get; set; } = new List<Table2>();
}
