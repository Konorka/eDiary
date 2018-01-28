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

        private void teachersGridButton(object sender, RoutedEventArgs e)
        {
        //    if (adminTeachersDataGrid.IsVisible == false)
        //    {
        //        adminTeachersDataGrid.Visibility = Visibility.Visible;
        //    }
        //    adminTeachersDataGrid.DataContext = context.Teacher;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        //    if (adminStudentsDataGrid.IsVisible == false)
        //    {
        //        adminStudentsDataGrid.Visibility = Visibility.Visible;
        //    }
        }



        private void SaveBtnClick(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            KoNorBeadando.eDiaryDataSet eDiaryDataSet = ((KoNorBeadando.eDiaryDataSet)(this.FindResource("eDiaryDataSet")));
            // Load data into the table Student. You can modify this code as needed.
            KoNorBeadando.eDiaryDataSetTableAdapters.StudentTableAdapter eDiaryDataSetStudentTableAdapter = new KoNorBeadando.eDiaryDataSetTableAdapters.StudentTableAdapter();
            eDiaryDataSetStudentTableAdapter.Fill(eDiaryDataSet.Student);
            System.Windows.Data.CollectionViewSource studentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("studentViewSource")));
            studentViewSource.View.MoveCurrentToFirst();
        }
    }
}
