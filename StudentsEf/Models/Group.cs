using System;
using System.Collections.Generic;

namespace StudentsEf.Models;

public partial class Group
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
