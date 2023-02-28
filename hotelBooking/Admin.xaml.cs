using Newtonsoft.Json;
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
using System.Net.Http;
using Newtonsoft.Json;
using hotelBooking.Models;

namespace hotelBooking
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        HttpClient client = new HttpClient();
        public Admin()
        {
            client.BaseAddress = new Uri("https://localhost:44308/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
            InitializeComponent();
        }
        private void Show_Hotels_Button_Click(object sender, RoutedEventArgs e)
        {
            this.GetAllHotelsInformation();
        }

        private async void GetAllHotelsInformation()
        {
            var hotelCityUri = "Hotel/city?cityName=" + this.txtHotelCitySelector.Text.ToLower();
            var response = await client.GetStringAsync(hotelCityUri);
            var hotels = JsonConvert.DeserializeObject<List<Hotels>>(response);
            this.hotelDataGrid.DataContext = hotels;
        }
    }
}
