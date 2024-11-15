using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{

    public partial class FrmSatis : Form
    {
        private int _roleid;
        private string connectionString = "Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password = Demir123*;";
        private SqlConnection connection;
        private PrintDocument printDocument2;
        private List<Urun> SepetListesi = new List<Urun>();
        public object newQuantity { get; private set; }

        public object tempPrQtity { get; private set; }
        public object totalPrice { get; private set; }
        public object barkod { get; private set; }

        public FrmSatis(int roleid)
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            printDocument2 = new PrintDocument();
            printDocument2.PrintPage += printDocument1_PrintPage;
            tableLayoutPanel10.BackColor = Color.Transparent;
            tableLayoutPanel11.BackColor = Color.Transparent;
            tableLayoutPanel12.BackColor = Color.Transparent;
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel6.BackColor = Color.Transparent;
            tableLayoutPanel7.BackColor = Color.Transparent;
            tableLayoutPanel8.BackColor = Color.Transparent;
            tableLayoutPanel9.BackColor = Color.Transparent;
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            _roleid = roleid;
        }

        private void btngri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBasla frmBasla = new FrmBasla(_roleid);
            frmBasla.WindowState = this.WindowState;
            frmBasla.Show();
            DeleteInserted();
            ClearPrintPage();
            dataGridView2.DataSource = null;
        }
        private void ClearPrintPage()
        {
            pos = 30;
            totalPrice = 0f;
            PrId = 0;
        }
        private void DeleteInserted()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password=Demir123*;"))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM ilachareketifis";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            List();
            printDocument1.PrintPage += printDocument1_PrintPage;
            DeleteInserted();
            ClearPrintPage();
            using (SqlConnection connection = new SqlConnection("Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password=Demir123*;"))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM ilachareketifis";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
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

        private void btnsat_Click(object sender, EventArgs e)
        {
            
            if (dataGridView2.Rows.Count == 0 || dataGridView2.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                MessageBox.Show("Satış için sepete ürün ekleyin.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string adı = row.Cells["Adı"].Value?.ToString();
                        int adet = Convert.ToInt32(row.Cells["Adet"].Value);
                        decimal fiyat = Convert.ToDecimal(row.Cells["Fiyat"].Value);

                        SqlCommand insertCmd = new SqlCommand(
                            "INSERT INTO ilacharekeleri (Adı, Adet, Tarih, Fiyat) VALUES (@Adı, @Adet, @Tarih, @Fiyat)",
                            connection);
                        insertCmd.Parameters.AddWithValue("@Adı", adı);
                        insertCmd.Parameters.AddWithValue("@Adet", adet);
                        insertCmd.Parameters.AddWithValue("@Tarih", DateTime.Now);
                        insertCmd.Parameters.AddWithValue("@Fiyat", fiyat);
                        insertCmd.ExecuteNonQuery();

                        SqlCommand updateCmd = new SqlCommand(
                            "UPDATE Ilaclar SET Stok = Stok - @Adet WHERE Adı = @Adı", connection);
                        updateCmd.Parameters.AddWithValue("@Adı", adı);
                        updateCmd.Parameters.AddWithValue("@Adet", adet);
                        updateCmd.ExecuteNonQuery();
                        List();

                        MessageBox.Show("Satış işlemi başarılı!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        public class Urun
        {
            public string Barkod { get; set; }
            public object Adı { get; internal set; }
        }
       

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells.Count >= 5)
                {
                    txtadi.Text = selectedRow.Cells[1].Value?.ToString();
                    maskedTextBox1.Text = selectedRow.Cells[2].Value?.ToString();
                    txtstok.Text = selectedRow.Cells[3].Value?.ToString();
                    richTextBox1.Text = selectedRow.Cells[4].Value?.ToString();
                    textBox1.Text = selectedRow.Cells[4].Value?.ToString();

                }
            }
        }

        private void txtadet_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtadet.Text, out int adet) && adet > 0)
            {
                float fiyat = (float)Convert.ToDecimal(textBox1.Text);
                float toplamfiyat = fiyat * adet;
                richTextBox1.Text = toplamfiyat.ToString("");
            }
            else { richTextBox1.Text = ""; }
               
        }

        private void btnsptckr_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView2.SelectedRows[0].Index;

                if (dataGridView2.Rows[selectedRowIndex].Cells["id"].Value != null)
                {
                    int id = Convert.ToInt32(dataGridView2.Rows[selectedRowIndex].Cells["id"].Value);

                    try
                    {
                        using (SqlConnection connection = new SqlConnection("Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password=Demir123*;"))
                        {
                            connection.Open();

                            string sql = "DELETE FROM ilachareketifis WHERE id=@id";
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@id", id);
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Kayıt Başarıyla Silindi.");

                                    SqlDataAdapter adt = new SqlDataAdapter("SELECT * FROM ilachareketifis", connection);
                                    DataTable dt = new DataTable();
                                    adt.Fill(dt);
                                    dataGridView2.DataSource = dt;
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

        private void btnfis_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 350, 500);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into fis (Tarih, Adet, Fiyat ) values(@SellDate, @Qtity, @Price )", connection);
                cmd.Parameters.AddWithValue("@SellDate", DateTime.Today);
                cmd.Parameters.AddWithValue("@Qtity", Convert.ToInt32(tempPrQtity));
                cmd.Parameters.AddWithValue("@Price", (float)(Convert.ToDecimal(totalPrice)));

                cmd.ExecuteNonQuery();

                connection.Close();
                dataGridView2.Refresh();
                DeleteInserted();
                dataGridView2.DataSource = null;


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            connection.Close();
        }
        private void btnspt_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrWhiteSpace(txtadi.Text) ||
                string.IsNullOrWhiteSpace(txtadet.Text) ||
                string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Tüm alanları doldurun.");
                return;
            }
            if (!float.TryParse(richTextBox1.Text, out float fiyat))
            {
                MessageBox.Show("Geçersiz fiyat.");
                return;
            }

            string checkStockQuery = "SELECT Stok FROM Ilaclar WHERE Adı = @ad";

            string connectionString = "Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane;User ID=sa;Password=Demir123*;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand checkStockCmd = new SqlCommand(checkStockQuery, connection);
                checkStockCmd.Parameters.AddWithValue("@ad", txtadi.Text);

                try
                {
                    connection.Open();

                    object stockResult = checkStockCmd.ExecuteScalar();

                    if (stockResult == DBNull.Value)
                    {
                        MessageBox.Show("Bu ürün veritabanında bulunamadı.");
                        return;
                    }

                    int mevcutStok = Convert.ToInt32(stockResult);
                    int girilenAdet = Convert.ToInt32(txtadet.Text);

                    if (girilenAdet > mevcutStok)
                    {
                        MessageBox.Show($"Yetersiz stok! Mevcut stok: {mevcutStok}");
                        return;
                    }

                    string query = "INSERT INTO ilachareketifis (Adı, Adet, Fiyat, Tarih) VALUES (@ad, @adt, @fyt, @trh)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ad", txtadi.Text);
                        command.Parameters.AddWithValue("@adt", girilenAdet);
                        command.Parameters.AddWithValue("@trh", DateTime.Now);
                        command.Parameters.AddWithValue("@fyt", fiyat);

                        command.ExecuteNonQuery();


                        SqlDataAdapter adt = new SqlDataAdapter("SELECT * FROM ilachareketifis", connection);
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        dataGridView2.DataSource = dt;

                        txtadi.Clear();
                        txtadet.Clear();
                        txtstok.Clear();
                        richTextBox1.Clear();
                        textBox1.Clear();
                        maskedTextBox1.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        int PrId = 0;
        int pos = 30;
        int lineOffset = 10;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int lineHeight = 20;
            int pos = 40;
            float totalPrice = GettotalPrice();
            int PrId = 0;


            e.Graphics.DrawString("ECZANE", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Blue, new Point(140));
            pos += lineHeight + 10;
            e.Graphics.DrawString("Id         Adı        Adet        Fiyat          Tarih     ", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(30, 40));
            pos += lineHeight;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.IsNewRow) continue;

                PrId++;
                string PrName = row.Cells["Adı"].Value?.ToString() ?? "";
                float PrPrice = Convert.ToSingle(row.Cells["Fiyat"].Value);
                int PrQty = Convert.ToInt32(row.Cells["Adet"].Value);
                DateTime Prdate = Convert.ToDateTime(row.Cells["Tarih"].Value);



                e.Graphics.DrawString("" + PrId, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(35, pos));
                e.Graphics.DrawString("" + PrName, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(70, pos));
                e.Graphics.DrawString("" + PrQty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(135, pos));
                e.Graphics.DrawString("" + PrPrice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(190, pos));
                e.Graphics.DrawString(Prdate.ToString("dd.MM.yyyy"), new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(250, pos));

                pos += lineHeight;
            }


            e.Graphics.DrawString("                 Toplam:      " + totalPrice + "₺", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(20, pos + 50));

            e.Graphics.DrawString("************************* ECZANE *************************", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 80));
            pos += lineHeight;
            dataGridView2.Refresh();
        }
        private float GettotalPrice()
        {
            float totalPrice = 0f;
            string connectionString = "Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane;User ID=sa;Password=Demir123*;";

            string query = "SELECT SUM(Fiyat) AS TotalPrice FROM ilachareketifis";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message);
                    }
                }
            }

            return totalPrice;
        }

        private void FrmSatis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            string barkod = maskedTextBox1.Text;

            if (string.IsNullOrWhiteSpace(barkod))
            {
                MessageBox.Show("Lütfen bir barkod girin.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Ilaclar WHERE Barkod = @Barkod";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Barkod", barkod);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtadi.Text = reader["Adı"].ToString();
                        txtstok.Text = reader["Stok"].ToString();
                        maskedTextBox1.Text = reader["Barkod"].ToString();
                        richTextBox1.Text = reader["Fiyat"].ToString();
                        textBox1.Text = reader["Fiyat"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ürün bulunamadı.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void spttmzl_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
        }

        private void txtadet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
