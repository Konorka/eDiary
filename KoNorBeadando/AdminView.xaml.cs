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
using System.Windows.Shapes;

namespace KoNorBeadando
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {
        eDiaryModelDB context = new eDiaryModelDB();
        
        public AdminView()
        {
            InitializeComponent();
            // adminStudentsDataGrid.ItemsSource = context.Student;
            
        }

        private void teachersOrStudentsButton(object sender, RoutedEventArgs e)
        {
            if (teacherDataGrid.IsVisible == false)
            {
                studentDataGrid.Visibility = Visibility.Hidden;
                teacherDataGrid.Visibility = Visibility.Visible;
                studentOrTeacers.Content = "Diákok";
            }
            else
            {
                teacherDataGrid.Visibility = Visibility.Hidden;
                studentDataGrid.Visibility = Visibility.Visible;
                studentOrTeacers.Content = "Tanárok";
            }
            
        }

        private void SaveBtnClick(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            eDiaryDataSet eDiaryDataSet = ((eDiaryDataSet)(FindResource("eDiaryDataSet")));
            // Entity Frame által generált kód

            
            eDiaryDataSetTableAdapters.StudentTableAdapter eDiaryDataSetStudentTableAdapter = new eDiaryDataSetTableAdapters.StudentTableAdapter();
            eDiaryDataSetStudentTableAdapter.Fill(eDiaryDataSet.Student);
            CollectionViewSource studentViewSource = ((CollectionViewSource)(FindResource("studentViewSource")));
            studentViewSource.View.MoveCurrentToFirst();

            // Load data into the table Teacher. You can modify this code as needed.
            eDiaryDataSetTableAdapters.TeacherTableAdapter eDiaryDataSetTeacherTableAdapter = new eDiaryDataSetTableAdapters.TeacherTableAdapter();
            eDiaryDataSetTeacherTableAdapter.Fill(eDiaryDataSet.Teacher);
            CollectionViewSource teacherViewSource = ((CollectionViewSource)(FindResource("teacherViewSource")));
            teacherViewSource.View.MoveCurrentToFirst();
            
        }
    }
}
