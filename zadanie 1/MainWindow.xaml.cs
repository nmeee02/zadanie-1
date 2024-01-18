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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zadanie_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                connection = new SqlConnection(@"Data Source= 3205EC02\SQLEXPRESS; Initial Catalog = zadanie; Integrated Security=SSPI;");
                connection.Open();
                Connect.Text = "";
                Connect.Text = "Сервер подключен";
                backcon.Background = new SolidColorBrush(Colors.ForestGreen);
                

            }
            catch 
            {
                Connect.Text = "";
                Connect.Text = "Не удалось подключиться к серверу";
                backcon.Background = new SolidColorBrush(Colors.Red);
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Close();
                backcon.Background = new SolidColorBrush(Colors.LightGray);
            }
            catch
            {
                Connect.Text = "Cервер не подключен";
                backcon.Background = new SolidColorBrush(Colors.LightGray);
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
