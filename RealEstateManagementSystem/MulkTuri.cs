using FurnitureProductionManagementSystem;
using System.Data.SqlClient;
using System.Data;

namespace RealEstateManagementSystem
{
    public partial class MulkTuri : Form
    {
        Functions Con;
        int Key = 0;

        public MulkTuri()
        {
            InitializeComponent();
            Con = new Functions();
            ShowArea();
        }

        private void ShowArea()
        {
            string Query = "select * from MulkTuri";
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
                    string Query = "insert into MulkTuri (MulkTuriNomi) values('{0}')";
                    Query = string.Format(Query, regionName);
                    Con.SetData(Query);
                    MessageBox.Show("Qo'shildi");
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
                    string Query = "update MulkTuri set MulkTuriNOmi = '{0}' where MulkTuriId={1}";
                    Query = string.Format(Query, regionName, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Yangilandi");
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
                    string Query = "delete from MulkTuri where MulkTuriID = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("O'chirildi");
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
            string query = "SELECT * FROM MulkTuri ";
            query += "WHERE MulkTuriID LIKE '%' + @param + '%' ";
            query += "OR MulkTuriNOmi LIKE '%' + @param + '%' ";
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

        private void tDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void sbtn_Click(object sender, EventArgs e)
        {
            SaveArea();
        }

        private void ubtn_Click(object sender, EventArgs e)
        {
            UpdateArea();
        }

        private void dbtn_Click(object sender, EventArgs e)
        {
            DeleteArea();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void restorebtn_Click(object sender, EventArgs e)
        {
            stbl.Text = "";
            ShowArea();
        }

        private void stbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }
    }
}
