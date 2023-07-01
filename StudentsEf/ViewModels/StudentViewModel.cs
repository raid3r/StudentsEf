using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using StudentsEf.BaseModels;
using StudentsEf.Models;

namespace StudentsEf.ViewModels;

public class StudentViewModel : NotifyPropertyChangedBase
{
    public Student Model { get; set; }

    public StudentViewModel(Student model, GroupViewModel group)
    {
        Model = model;
        Group = group;
    }

    public int Id
    {
        get => Model.Id; set
        {
            Model.Id = value;
            OnPropertyChanged(nameof(Id));
        }
    }

    public string FirstName
    {
        get => Model.FirstName; set
        {
            Model.FirstName = value;
            OnPropertyChanged(nameof(FirstName));
        }
    }

    public string LastName
    {
        get => Model.LastName; set
        {
            Model.LastName = value;
            OnPropertyChanged(nameof(LastName));
        }
    }

    public DateTime? Birthday
    {
        get => Model.Birthday; set
        {
            Model.Birthday = value;
            OnPropertyChanged(nameof(Birthday));
        }
    }

    public int Course
    {
        get => Model.Course; set
        {
            Model.Course = value;
            OnPropertyChanged(nameof(Course));
        }
    }

    private GroupViewModel _group;

    public GroupViewModel Group
    {
        get => _group; set
        {
            _group = value;
            Model.Group = value.Model;
            OnPropertyChanged();
        }
    }
}
