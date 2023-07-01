using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;
using StudentsEf.BaseModels;
using StudentsEf.Models;

namespace StudentsEf.ViewModels;

public class MainWindowViewModel : NotifyPropertyChangedBase
{
    private MyDatabaseContext _db;

    public MainWindowViewModel()
    {
        _db = new MyDatabaseContext();
        _students = new List<Student>();
        AllGroups = new ObservableCollection<GroupViewModel>(
               _db.Groups
               .OrderBy(g => g.Title)
               .Select(g => new GroupViewModel(g))
               );
        Load();
        OnPropertyChanged(nameof(AllGroups));
    }

    private void Load()
    {
        _students.Clear();
        _students = _db.Students
            .Include(s => s.Group)
            .Where(s => s.FirstName.Contains(Search) || s.LastName.Contains(Search))
            .ToList();
        OnPropertyChanged(nameof(Students));
    }

    private List<Student> _students;

    public ObservableCollection<StudentViewModel> Students
    {
        get
        {
            return new ObservableCollection<StudentViewModel>(
                _students.Select(s => new StudentViewModel(s, AllGroups.First(g => g.Id == s.GroupId))));
        }
    }

    public ObservableCollection<GroupViewModel> AllGroups { get; set; }


    private StudentViewModel _selectedStudent;
    public StudentViewModel SelectedStudent
    {
        get { return _selectedStudent; }
        set { _selectedStudent = value; OnPropertyChanged(nameof(SelectedStudent)); }
    }

    public ICommand Save => new RelayCommand(x =>
    {
        _db.SaveChanges();
        MessageBox.Show("Saved");
    }, x =>
    {
        return true;
    });

    public ICommand AddStudent => new RelayCommand(x =>
    {

        var student = new Student
        {
            FirstName = "",
            LastName = "",
            Birthday = DateTime.Now,
            Course = 1,
            Group = _db.Groups.First(),
        };
        _db.Students.Add(student);
        _students.Add(student);
        OnPropertyChanged(nameof(Students));

    }, x =>
    {
        return true;
    });

    private string? _search = "";
    public string? Search
    {
        get { return _search; }
        set
        {
            _search = value;
            OnPropertyChanged(nameof(Search));
            Load();
        }
    }
}
