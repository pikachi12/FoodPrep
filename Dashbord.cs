namespace Resep
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {

        }

        private void btnResep_Click(object sender, EventArgs e)
        {
            ResepCari pencarianForm = new ResepCari();
            pencarianForm.Show();
            this.Hide();
        }

        private void btnPenyimpanan_Click(object sender, EventArgs e)
        {
            Penyimpanan pencarianForm = new Penyimpanan();
            pencarianForm.Show();
            this.Hide();
        }
    }
}
