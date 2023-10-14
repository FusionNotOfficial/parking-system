namespace ParkingMS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            var window = new Sections();
            window.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var window = new Sections();
            window.Show();
        }
    }
}