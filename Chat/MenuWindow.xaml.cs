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
using System.Windows.Shapes;

namespace Chat
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        HttpClient httpClient = new HttpClient();
        public MenuWindow()
        {
            InitializeComponent();
        }

        private async void SendMessageBtn_Click(object sender, RoutedEventArgs e)
        {
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(httpClient), Encoding.UTF8, ("applcation/json"));
            //var sendMes = await httpClient.PostAsync(("https://localhost:44355/api/login", httpContent));
        }
    }
}
