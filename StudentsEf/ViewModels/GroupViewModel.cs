using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsEf.BaseModels;
using StudentsEf.Models;

namespace StudentsEf.ViewModels;

public class GroupViewModel : NotifyPropertyChangedBase
{
    public Group Model { get; set; }

    public GroupViewModel(Group model)
    {
        Model = model;
    }

    public int Id
    {
        get => Model.Id; set
        {
            Model.Id = value;
            OnPropertyChanged(nameof(Id));
        }
    }

    public string Title
    {
        get => Model.Title; set
        {
            Model.Title = value;
            OnPropertyChanged(nameof(Title));
        }
    }
}
