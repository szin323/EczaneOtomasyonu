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
    public partial class FrmStok : Form
    {
        private int _roleid;
        public FrmStok(int roleid)
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            _roleid = roleid;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel6.BackColor = Color.Transparent;
            tableLayoutPanel10.BackColor = Color.Transparent;
            tableLayoutPanel11.BackColor = Color.Transparent;
            tableLayoutPanel12.BackColor = Color.Transparent;
            tableLayoutPanel13.BackColor = Color.Transparent;
            tableLayoutPanel14.BackColor = Color.Transparent;
            tableLayoutPanel15.BackColor = Color.Transparent;
            tableLayoutPanel16.BackColor = Color.Transparent;
            tableLayoutPanel17.BackColor = Color.Transparent;

        }
        SqlConnection connection = new SqlConnection("Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password = Demir123*;");

        private void FrmStok_Load(object sender, EventArgs e)
        {
            List();
        }
        private void List()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Ilaclar", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void btnekl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
        string.IsNullOrWhiteSpace(textBox2.Text) ||
        string.IsNullOrWhiteSpace(textBox3.Text) ||
        string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
        string.IsNullOrWhiteSpace(maskedTextBox2.Text))
            {
                MessageBox.Show("Boş alan bırakmayınız.");
                return;
            }

            if (!float.TryParse(textBox2.Text, out float fiyat))
            {
                MessageBox.Show("Geçerli bir fiyat giriniz.");
                return;
            }
            string query = "INSERT INTO Ilaclar (Adı, Barkod, Stok, Fiyat, Raf) VALUES (@Adı, @Brkd, @Stk, @Fyt, @Rf)";

            using (SqlConnection connection = new SqlConnection("Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password=Demir123*;"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Adı", textBox1.Text);
                    command.Parameters.AddWithValue("@Brkd", maskedTextBox1.Text);
                    command.Parameters.AddWithValue("@Stk", maskedTextBox2.Text);
                    command.Parameters.AddWithValue("@Fyt", textBox2.Text);
                    command.Parameters.AddWithValue("@Rf", textBox3.Text);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Kayıt eklendi");
                        List();

                        textBox1.Clear();
                        maskedTextBox1.Clear();
                        maskedTextBox2.Clear();
                        textBox3.Clear();
                        textBox2.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells.Count >= 5)
                {
                    textBox1.Text = selectedRow.Cells[1].Value?.ToString();
                    maskedTextBox1.Text = selectedRow.Cells[2].Value?.ToString();
                    maskedTextBox2.Text = selectedRow.Cells[3].Value?.ToString();
                    textBox2.Text = selectedRow.Cells[4].Value?.ToString();
                    textBox3.Text = selectedRow.Cells[5].Value?.ToString();

                }
            }
        }
        private void btngncll_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
        string.IsNullOrWhiteSpace(textBox2.Text) ||
        string.IsNullOrWhiteSpace(textBox3.Text) ||
        string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
        string.IsNullOrWhiteSpace(maskedTextBox2.Text))
            {
                MessageBox.Show("Güncelleme yapmak için Tablodan güncellenecek ürünün ID'sini seçiniz.");
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                object cellValue = dataGridView1.Rows[selectedRowIndex].Cells["id"].Value;

                if (cellValue != null)
                {
                    int id = Convert.ToInt32(cellValue);

                    string query = "UPDATE Ilaclar SET Adı = @Adı, Barkod = @Brkd, Stok = @Stk, Fiyat = @Fyt, Raf = @Rf WHERE id = @id";

                    using (SqlConnection connection = new SqlConnection("Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password=Demir123*;"))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Adı", textBox1.Text);
                            command.Parameters.AddWithValue("@Brkd", maskedTextBox1.Text);
                            command.Parameters.AddWithValue("@Stk", maskedTextBox2.Text);
                            command.Parameters.AddWithValue("@Fyt", textBox2.Text);
                            command.Parameters.AddWithValue("@Rf", textBox3.Text);
                            command.Parameters.AddWithValue("@id", id);

                            try
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                MessageBox.Show("Kayıt güncellendi");
                                List();
                                textBox1.Clear();
                                maskedTextBox1.Clear();
                                maskedTextBox2.Clear();
                                textBox3.Clear();
                                textBox2.Clear();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Bir hata oluştu: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ID bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Kayıt seçin.");
            }
        }

        private void btngri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBasla frmBasla = new FrmBasla(_roleid);
            frmBasla.WindowState = this.WindowState;
            frmBasla.Show();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Arama yapmak için ilaç adı giriniz ya da Tablodan ID seçiniz.");
                return;
            }

            string connectionString = "Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password = Demir123*;";
            string adı = textBox1.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Barkod, Stok, Fiyat, Raf FROM Ilaclar WHERE Adı =@Adı";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Adı", adı);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        maskedTextBox1.Text = reader["Barkod"].ToString();
                        maskedTextBox2.Text = reader["Stok"].ToString();
                        textBox2.Text = reader["Fiyat"].ToString();
                        textBox3.Text = reader["Raf"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Barkoda dair veri bulunamadi");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

     
        private void FrmStok_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void btnsil_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox2.Text))

            {
                MessageBox.Show("Silmek için Tablodan silinecek ürünün ID'sini seçiniz.");
                return;
            }
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

                            string sql = "DELETE FROM Ilaclar WHERE id=@id";
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@id", id);
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Kayıt Başarıyla Silindi.");
                                    List();
                                    textBox1.Clear();
                                    textBox2.Clear();
                                    textBox3.Clear();
                                    maskedTextBox1.Clear();
                                    maskedTextBox2.Clear();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = selectedRow.Cells["Adı"].Value?.ToString();
                maskedTextBox1.Text = selectedRow.Cells["Barkod"].Value?.ToString();
                maskedTextBox2.Text = selectedRow.Cells["Stok"].Value?.ToString();
                textBox2.Text = selectedRow.Cells["Fiyat"].Value?.ToString();
                textBox3.Text = selectedRow.Cells["Raf"].Value?.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
        }

        
    }
}
