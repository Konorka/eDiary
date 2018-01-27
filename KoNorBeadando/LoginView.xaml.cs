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
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            var username = usernameTextBox.Text;
            var password = passwordTextbox.Password;
            eDiaryModelDB context = new eDiaryModelDB();
            //using (eDiaryModelDB context = new eDiaryModelDB())
            {
                var user = context.User.FirstOrDefault(x => x.username == username);
                if (user !=null)
                {
                    if (user.password == password)
                    {
                        switch (user.user_access_id)
                        {
                            case 1:
                                AdminView adminview = new AdminView();
                                adminview.Show();
                                this.Close();break;

                            case 2:
                                MainWindow teacherView = new MainWindow();
                                teacherView.Show();
                                this.Close(); break;

                            case 3:
                                MainWindow studentView = new MainWindow();
                                studentView.Show();
                                this.Close(); break;

                            default: MessageBox.Show("ERROR 404");break;
                        }
                        
                    }
                    else
                        MessageBox.Show("Rossz felhasználónév vagy jelszó");

                }else
                    MessageBox.Show("shit");
            }

        }
    }
}
