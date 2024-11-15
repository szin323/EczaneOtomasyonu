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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class FrmHesapOls : Form
    {
        public FrmHesapOls()
        {
            InitializeComponent();
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel6.BackColor = Color.Transparent;
            tableLayoutPanel8.BackColor = Color.Transparent;
            tableLayoutPanel9.BackColor = Color.Transparent;
        }
        SqlConnection connection = new SqlConnection("Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password = Demir123*;");

        

        private void btnkydt_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sql = "SELECT COUNT(*) FROM bilgi WHERE username=@name";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@name", txtkllnc.Text);

                int userCount = (int)command.ExecuteScalar();

                if (userCount > 0)
                {
                    MessageBox.Show("Kullanıcı zaten mevcut!");
                }
                else if (txtsfr.Text != txtsfrtkr.Text)
                {
                    lblynlsfr.Visible = true;
                    lbldoldur.Visible = false;
                    return;
                }
                else
                {
                    lblynlsfr.Visible = false;

                    int roleId;
                    if (checkBox1.Checked)
                    {
                        roleId = 1;
                    }
                    else
                    {
                        roleId = 2;
                    }
                    if (string.IsNullOrEmpty(txtacil.Text) ||
                        string.IsNullOrEmpty(txtadrs.Text) ||
                        string.IsNullOrEmpty(txtkllnc.Text) ||
                        string.IsNullOrEmpty(txtmail.Text) ||
                        string.IsNullOrEmpty(txtsfr.Text) ||
                        string.IsNullOrEmpty(txtsfrtkr.Text) ||
                        string.IsNullOrEmpty(txttlfn.Text))


                    {
                        lbldoldur.Visible = true;
                        return;
                    }

                    string insertSql = "INSERT INTO bilgi (username, password, roleID, Email, Phone, Adress, [Emergency Contact]) VALUES (@name, @password, @roleId, @mail, @tlfn, @adrs, @acil)";
                    SqlCommand insertCommand = new SqlCommand(insertSql, connection);
                    insertCommand.Parameters.AddWithValue("@name", txtkllnc.Text);
                    insertCommand.Parameters.AddWithValue("@password", txtsfr.Text);
                    insertCommand.Parameters.AddWithValue("@mail", txtmail.Text);
                    insertCommand.Parameters.AddWithValue("@tlfn", txttlfn.Text);
                    insertCommand.Parameters.AddWithValue("@adrs", txtadrs.Text);
                    insertCommand.Parameters.AddWithValue("@acil", txtacil.Text);
                    insertCommand.Parameters.AddWithValue("@roleId", roleId);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı.");

                    txtkllnc.Clear();
                    txtsfr.Clear();
                    txtsfrtkr.Clear();
                    txtacil.Clear();
                    txtadrs.Clear();
                    txtmail.Clear();
                    txttlfn.Clear();

                    lblynlsfr.Visible = false;
                    lbldoldur.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void btngrsek_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.WindowState = this.WindowState;
            frmGiris.Show();
        }

        private void FrmHesapOls_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
