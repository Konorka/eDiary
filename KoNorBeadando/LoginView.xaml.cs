using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for LoginView.xaml
    /// </summary>
    
    public partial class LoginView : Window
    {
        public LoginViewModel ViewModel { get; }
        public int USER_ID;
        public string Username;
        public string Password;

        public LoginView()
        {
            InitializeComponent();
            ViewModel = new LoginViewModel();
            DataContext = ViewModel;
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {

            Username = usernameTextBox.Text;
            Password = passwordTextbox.Password;
            var context = new eDiaryModelDB();
            var viewModel = new LoginViewModel();

            ViewModel.Password = passwordTextbox.Password;
            viewModel.Login();
            if (ViewModel.Login())
            {
                var user = context.User.FirstOrDefault(x => x.username == Username);
                switch (user.user_access_rank)
                
                    {
                        case 1:
                    AdminView _av = new AdminView();
                    _av.Show();
                    this.Close(); break;

                        case 2:
                    MainWindow teacherView = new MainWindow();
                    teacherView.Show();
                    this.Close(); break;

                        case 3:
   
                    MainWindow studentView = new MainWindow();
                    studentView.Show();
                    this.Close(); break;

                    default: MessageBox.Show("ERROR 404"); break;
                }
            }
            else
                MessageBox.Show("Nem megfelelő adatok");
            //switch ()
            //{
            //    case 1:
            //        AdminView adminview = new AdminView();
            //        adminview.Show();
            //        this.Close(); break;

            //    case 2:
            //        Username = usernameTextBox.Text;
            //        Password = passwordTextbox.Password;
            //        MainWindow teacherView = new MainWindow();
            //        teacherView.Show();
            //        this.Close(); break;

            //    case 3:
            //        Username = usernameTextBox.Text;
            //        Password = passwordTextbox.Password;
            //        MainWindow studentView = new MainWindow();
            //        studentView.Show();
            //        this.Close(); break;

            //    default: MessageBox.Show("ERROR 404"); break;
            //} 


            //var user = context.User.FirstOrDefault(x => x.username == username);
            //if (user != null)
            //{
            //    if (user.password == password)
            //    {
            //        switch (user.user_access_rank)
            //        {
            //            case 1:
            //                AdminView adminview = new AdminView();
            //                adminview.Show();
            //                this.Close(); break;

            //            case 2:
            //                MainWindow teacherView = new MainWindow();
            //                teacherView.Show();
            //                this.Close(); break;

            //            case 3:
            //                MainWindow studentView = new MainWindow();
            //                studentView.Show();
            //                this.Close(); break;

            //            default: MessageBox.Show("ERROR 404"); break;
            //        }

            //    }
            //    else
            //        MessageBox.Show("Rossz felhasználónév vagy jelszó");

            //}
            //else
            //    MessageBox.Show("Rossz felhasználónév vagy jelszó");


        }
    }
}
