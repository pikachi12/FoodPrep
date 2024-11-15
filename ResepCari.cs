using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Resep
{
    public partial class ResepCari : Form
    {
        public ResepCari()
        {
            InitializeComponent();
        }

        private async void btnCari_Click(object sender, EventArgs e)
        {
            string ingredients = txtBahan.Text; // Ambil bahan dari TextBox
            var recipes = await GetRecipesByIngredients(ingredients); // Panggil metode untuk mengambil resep
            DisplayRecipes(recipes); // Tampilkan resep yang diambil
        }

        public async Task<List<Recipe>> GetRecipesByIngredients(string ingredients)
        {
            string apiKey = "311147236b684840849f074ca4e294e2"; // Ganti dengan kunci API Anda
            string url = $"https://api.spoonacular.com/recipes/findByIngredients?ingredients={ingredients}&apiKey={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(url); // Ambil data dari API
                return JsonConvert.DeserializeObject<List<Recipe>>(response); // Deserialisasi JSON menjadi objek Recipe
            }
        }

        private void DisplayRecipes(List<Recipe> recipes)
        {
            listBoxResep.Items.Clear(); // Kosongkan ListBox sebelum menampilkan hasil baru
            foreach (var recipe in recipes)
            {
                listBoxResep.Items.Add(recipe.Title); // Tambahkan judul resep ke ListBox
            }
        }
    }
}
