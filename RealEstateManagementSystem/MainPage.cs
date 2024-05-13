using RealEstateManagementSystem;

namespace FurnitureProductionManagementSystem
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }

        private void llbl_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void hlbl_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.TopLevel = false;
            mainpanel.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void tlbl_Click(object sender, EventArgs e)
        {
            Tashkilot p = new Tashkilot();
            p.TopLevel = false;
            mainpanel.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void mtlbl_Click(object sender, EventArgs e)
        {
            MulkTuri p = new()
            {
                TopLevel = false
            };
            mainpanel.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void mlbl_Click(object sender, EventArgs e)
        {
            Mulk p = new()
            {
                TopLevel = false
            };
            mainpanel.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }
    }
}