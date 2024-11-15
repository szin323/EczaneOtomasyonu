using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHareket : Form
    {
        private int _roleid;
        public FrmHareket(int roleid)
        {
            InitializeComponent();
            tableLayoutPanel1.BackColor = Color.Transparent;
            _roleid = roleid;
        }
        SqlConnection connection = new SqlConnection("Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password = Demir123*;");

        private void btngri_Click(object sender, EventArgs e)
        { 

            this.Hide();
            FrmBasla frmBasla = new FrmBasla(_roleid);
            frmBasla.WindowState = this.WindowState;
            frmBasla.Show();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                if (dataGridView1.Rows[selectedRowIndex].Cells["id"].Value != null)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["id"].Value);
                    try
                    {
                        using (SqlConnection connection = new SqlConnection("Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password=Demir123*;"))
                        {
                            connection.Open();

                            string sql = "DELETE FROM ilacharekeleri WHERE id=@id";
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@id", id);
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Kayıt Başarıyla Silindi.");
                                    List();
                                }
                                else
                                {
                                    MessageBox.Show("Kayıt Bulunamadı.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("ID bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Kayıt Seçin.");
            }
        }

        private void FrmHareket_Load(object sender, EventArgs e)
        {
            List();
        }
        private void List()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ilaclar", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void FrmHareket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void LoadIlacHareketleri()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM ilacharekeleri ORDER BY Tarih DESC", connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
            }
        }
    }
}
