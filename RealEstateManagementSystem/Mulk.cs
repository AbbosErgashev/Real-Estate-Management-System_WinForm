using FurnitureProductionManagementSystem;
using System.Data;
using System.Data.SqlClient;

namespace RealEstateManagementSystem
{
    public partial class Mulk : Form
    {
        Functions Con;
        int Key = 0;

        public Mulk()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCompany();
            GetMulk();
            Hudud();
            Tashkilot();
        }

        private void ShowCompany()
        {
            string Query = "select * from Mulk";
            tDGV.DataSource = Con.GetData(Query);
        }

        private void SaveCompany()
        {
            if (mcb.SelectedIndex == -1 || ntbl.Text == "" || ttbl.Text == "" || hcb.SelectedIndex == -1 || tcb.SelectedIndex == -1)
            {
                MessageBox.Show("Xato");
            }
            else
            {
                try
                {
                    int mulk = Convert.ToInt32(mcb.SelectedValue);
                    int hudud = Convert.ToInt32(hcb.SelectedValue);
                    int tash = Convert.ToInt32(tcb.SelectedValue);
                    string narx = ntbl.Text;
                    string tas = ttbl.Text;
                    string Query = "insert into Mulk (MulkTuriId, Tasnif, HududId, TashkilotID, Narxi) values('{0}', '{1}', '{2}', '{3}', '{4}')";
                    Query = string.Format(Query, mulk, tas, hudud, tash, narx);

                    Con.SetData(Query);

                    MessageBox.Show("Qo'shildi");
                    Reset();
                    ShowCompany();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateCompany()
        {
            if (mcb.SelectedIndex == -1 || ntbl.Text == "" || ttbl.Text == "" || hcb.SelectedIndex == -1 || tcb.SelectedIndex == -1)
            {
                MessageBox.Show("Xato");
            }
            else
            {
                try
                {
                    int mulk = Convert.ToInt32(mcb.SelectedValue);
                    int hudud = Convert.ToInt32(hcb.SelectedValue);
                    int tash = Convert.ToInt32(tcb.SelectedValue);
                    string narx = ntbl.Text;
                    string tas = ttbl.Text;
                    string Query = "update Mulk set MulkTuriId = '{0}', Tasnif='{1}', HududId='{2}', TashkilotId='{3}', Narxi='{4}' where MulkId={5}";
                    Query = string.Format(Query, mulk, tas, hudud, tash, narx, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Yangilandi");
                    Reset();
                    ShowCompany();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteCompany()
        {
            if (Key == 0)
            {
                MessageBox.Show("Xato");
            }
            else
            {
                try
                {
                    string Query = "delete from Mulk where MulkId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("O'chirildi");
                    Reset();
                    ShowCompany();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM MUlk ";
            query += "WHERE MUlkId LIKE '%' + @param + '%' ";
            query += "OR MulkTuriId LIKE '%' + @param + '%' ";
            query += "OR Tasnif LIKE '%' + @param + '%' ";
            query += "OR HUdudId LIKE '%' + @param + '%' ";
            query += "OR TashkilotId LIKE '%' + @param + '%' ";
            query += "OR Narxi LIKE '%' + @param + '%' ";
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
            mcb.Text = "";
            ttbl.Text = "";
            hcb.Text = "";
            tcb.Text = "";
            ntbl.Text = "";
        }

        private void RestoreFilter()
        {
            stbl.Text = "";
            ShowCompany();
        }

        private void GetMulk()
        {
            if (mcb.SelectedItem == "")
            {
                mcb.Text = "Bo'sh";
            }
            else
            {
                SqlConnection cn = new("Data Source=ACER;Initial Catalog=RealEstate_DB;Integrated Security=True;Encrypt=False");
                cn.Open();
                SqlCommand cmd = new("select * from MulkTuri", cn);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new();
                dt.Columns.Add("MulkTuriId", typeof(int));
                dt.Load(rdr);
                mcb.DisplayMember = "MulkTuriNomi";
                mcb.ValueMember = "MUlkTuriId";
                mcb.DataSource = dt;
                cn.Close();
            }
        }

        private void Hudud()
        {
            if (hcb.SelectedItem == "")
            {
                hcb.Text = "Bo'sh";
            }
            else
            {
                SqlConnection cn = new("Data Source=ACER;Initial Catalog=RealEstate_DB;Integrated Security=True;Encrypt=False");
                cn.Open();
                SqlCommand cmd = new("select * from HUdud", cn);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new();
                dt.Columns.Add("HUdudId", typeof(int));
                dt.Load(rdr);
                hcb.DisplayMember = "HUdudNOmi";
                hcb.ValueMember = "HUdudId";
                hcb.DataSource = dt;
                cn.Close();
            }
        }

        private void Tashkilot()
        {
            if (tcb.SelectedItem == "")
            {
                tcb.Text = "Bo'sh";
            }
            else
            {
                SqlConnection cn = new("Data Source=ACER;Initial Catalog=RealEstate_DB;Integrated Security=True;Encrypt=False");
                cn.Open();
                SqlCommand cmd = new("select * from TAshkilot", cn);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new();
                dt.Columns.Add("TashkilotID", typeof(int));
                dt.Load(rdr);
                tcb.DisplayMember = "TashkilotNomi";
                tcb.ValueMember = "TAshkilotId";
                tcb.DataSource = dt;
                cn.Close();
            }
        }

        private void tDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < tDGV.Rows.Count)
            {
                mcb.Text = tDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                ttbl.Text = tDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                hcb.Text = tDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                tcb.Text = tDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                ntbl.Text = tDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (mcb.SelectedIndex == -1 || ntbl.Text == "" || ttbl.Text == "" || hcb.SelectedIndex == -1 || tcb.SelectedIndex == -1)
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(tDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            SaveCompany();
        }

        private void ubtn_Click(object sender, EventArgs e)
        {
            UpdateCompany();
        }

        private void dbtn_Click(object sender, EventArgs e)
        {
            DeleteCompany();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void restorebtn_Click(object sender, EventArgs e)
        {
            RestoreFilter();
            ShowCompany();
        }

        private void stbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }
    }
}