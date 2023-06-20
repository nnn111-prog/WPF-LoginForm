using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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
using WPF_LoginForm.ViewModels;

namespace WPF_LoginForm.Views
{
    /// <summary>
    /// Логика взаимодействия для AccountView.xaml
    /// </summary>
    public partial class AccountView : UserControl
    {
        //string connectionString = @"Server=localhost;Uid=root;Pwd=root;Database=equipment;";
        //int idUser = 0;
                
        public AccountView()
        {
            InitializeComponent();
        }

        private void Button_AddUser(object sender, RoutedEventArgs e)
        {
            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            //{
            //    connection.Open();
            //    MySqlCommand command = new MySqlCommand("UserAddOrEdit", connection);
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.Parameters.AddWithValue("_Id", idUser);
            //    command.Parameters.AddWithValue("_Username", UsernameUser.Text.Trim());
            //    command.Parameters.AddWithValue("_Password", PasswordUser.Text.Trim());
            //    command.ExecuteNonQuery();
            //    MessageBox.Show("Success");
            //}
        }

        private void Button_EditUser(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
