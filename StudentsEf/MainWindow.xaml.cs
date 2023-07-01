using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using StudentsEf.ViewModels;

namespace StudentsEf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}

/*
 
dotnet ef dbcontext scaffold "Data Source=SILVERSTONE\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False" Microsoft.EntityFrameworkCore.SqlServer --project StudentsEf -OutputDir Models


Scaffold-DbContext "Data Source=SILVERSTONE\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir "Models"


  
 */
