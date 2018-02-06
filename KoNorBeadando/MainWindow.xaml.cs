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

namespace KoNorBeadando
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly MainViewModel _vm;
        LoginView _lv = new LoginView();
        AdminView _av = new AdminView();
        Student student = new Student();
        LoginView viewModel = new LoginView();
        public eDiaryModelDB context = new eDiaryModelDB();
        public MainWindow()
        {

            InitializeComponent();
            var loginView = new LoginView();
            _vm = new MainViewModel
            {
                user = loginView.ViewModel.AuthenticatedUser
            };
            DataContext = _vm;
            nameLabel.Content = _vm.user.user_id;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            nameLabel.Content = viewModel.Username;
            KoNorBeadando.eDiaryDataSet eDiaryDataSet = ((KoNorBeadando.eDiaryDataSet)(this.FindResource("eDiaryDataSet")));
            // Load data into the table Lesson. You can modify this code as needed.
            KoNorBeadando.eDiaryDataSetTableAdapters.LessonTableAdapter eDiaryDataSetLessonTableAdapter = new KoNorBeadando.eDiaryDataSetTableAdapters.LessonTableAdapter();
            eDiaryDataSetLessonTableAdapter.Fill(eDiaryDataSet.Lesson);
            System.Windows.Data.CollectionViewSource lessonViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("lessonViewSource")));
            lessonViewSource.View.MoveCurrentToFirst();
        }

        private void LogoutClick(object sender, RoutedEventArgs e)
        {

            LoginView loginView = new LoginView();
            Hide();
            loginView.ShowDialog();        
            Close();
        }
    }
}
