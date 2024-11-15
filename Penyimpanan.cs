using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Resep
{
    public partial class Penyimpanan : Form
    {

        public Penyimpanan()
        {
            InitializeComponent();
        }

        public async Task<FoodKeeperData> GetFoodKeeperDataAsync(string foodItem)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "311147236b684840849f074ca4e294e2");
                var response = await client.GetAsync($"https://api.spoonacular.com/food/ingredients/search{foodItem}");
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<FoodKeeperData>(jsonResponse);
            }
        }

        private async void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                var foodData = await GetFoodKeeperDataAsync(txtSimpan.Text);
                txtStorageGuidelines.Text = foodData.StorageGuidelines;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        
    }
}
