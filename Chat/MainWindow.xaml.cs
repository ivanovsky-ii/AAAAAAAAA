using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace Chat
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HttpClient httpCLient = new HttpClient();
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            httpCLient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(httpCLient), Encoding.UTF8, "applcation/json");
            var mes = await httpCLient.PostAsync("https://localhost:44355/api/login", httpContent);

            MessageBox.Show(mes.StatusCode.ToString());
            if (mes.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MenuWindow menw = new MenuWindow();
                menw.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильно (^._.^)");
            }
        }
    }
}
