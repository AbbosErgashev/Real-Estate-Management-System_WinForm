using FurnitureProductionManagementSystem;
using System.Data;
using System.Data.SqlClient;

namespace RealEstateManagementSystem
{
    public partial class Tashkilot : Form
    {
        Functions Con;
        int Key = 0;

        public Tashkilot()
        {
            InitializeComponent();
            Con = new Functions();
            ShowArea();
        }

        private void ShowArea()
        {
            string Query = "select * from Tashkilot";
            tDGV.DataSource = Con.GetData(Query);
        }

        private void SaveArea()
        {
            if (tntbl.Text == "")
            {
                MessageBox.Show("Xato!");
            }
            else
            {
                try
                {
                    string regionName = tntbl.Text;
                    string Query = "insert into Tashkilot (TashkilotNomi) values('{0}')";
                    Query = string.Format(Query, regionName);
                    Con.SetData(Query);
                    MessageBox.Show("Tashkilot Qo'shildi");
                    Reset();
                    ShowArea();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateArea()
        {
            if (tntbl.Text == "")
            {
                MessageBox.Show("Xato!");
            }
            else
            {
                try
                {
                    string regionName = tntbl.Text;
                    string Query = "update Tashkilot set TashkilotNomi = '{0}' where TashkilotId={1}";
                    Query = string.Format(Query, regionName, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Tashkilot yangilandi");
                    Reset();
                    ShowArea();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteArea
            ()
        {
            if (Key == 0)
            {
                MessageBox.Show("Xato!");
            }
            else
            {
                try
                {
                    string Query = "delete from Tashkilot where TashkilotId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Tashkilot O'chirildi");
                    Reset();
                    ShowArea();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM Tashkilot ";
            query += "WHERE TashkilotID LIKE '%' + @param + '%' ";
            query += "OR TashkilotNomi LIKE '%' + @param + '%' ";
            string con = "Data Source=ACER;Initial Catalog=RealEstate_DB;Integrated Security=True;Encrypt=False";

            using SqlConnection conn = new(con);
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@param", stbl.Text);
            using SqlDataAdapter da = new(cmd);
            DataTable dt = new();
            da.Fill(dt);
            tDGV.DataSource = dt;
            return dt;
        }

        private void Reset()
        {
            tntbl.Text = "";
        }

        private void sbtn_Click_1(object sender, EventArgs e)
        {
            SaveArea();
        }

        private void ubtn_Click_1(object sender, EventArgs e)
        {
            UpdateArea();
        }

        private void dbtn_Click_1(object sender, EventArgs e)
        {
            DeleteArea();
        }

        private void resetbtn_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void restorebtn_Click_1(object sender, EventArgs e)
        {
            stbl.Text = "";
            ShowArea();
        }

        private void stbl_TextChanged_1(object sender, EventArgs e)
        {
            AllSearch();
        }

        private void tDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tntbl.Text = tDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (tntbl.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(tDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}