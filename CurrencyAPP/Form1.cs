using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurrencyAPP
{
    public partial class Form1 : Form
    {
        static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void convertcurrency_Click(object sender, EventArgs e)
        {
            string access_key = "APIFLAYER_KEY";
            string from = guna2ComboBox1.Text;
            string to = guna2ComboBox2.Text;
            string amount = guna2TextBox1.Text;
            client.DefaultRequestHeaders.Add("apikey", access_key);
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://api.apilayer.com/fixer/convert?to=" + to + "&from=" + from + "&amount=" + amount);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(jsonResponse);
                    label1.Text = data.result;
                    Console.WriteLine(jsonResponse);
                }
                else
                {
                    Console.WriteLine("GET isteği başarısız oldu. Hata kodu: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }

        }
    }
}
