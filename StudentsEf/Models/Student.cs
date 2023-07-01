using System;
using System.Collections.Generic;

namespace StudentsEf.Models;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime? Birthday { get; set; }

    public int Course { get; set; }

    public int GroupId { get; set; }

    public virtual Group Group { get; set; } = null!;
}
