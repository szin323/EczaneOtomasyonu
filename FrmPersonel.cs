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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FrmPersonel : Form
    {
        private int _roleid;
        public FrmPersonel(int roleId)
        {
            InitializeComponent();
            checkBox1.BackColor = Color.Transparent;
            tableLayoutPanel11.BackColor = Color.Transparent;
            tableLayoutPanel10.BackColor = Color.Transparent;
            tableLayoutPanel11.BackColor = Color.Transparent;
            tableLayoutPanel13.BackColor = Color.Transparent;
            tableLayoutPanel6.BackColor = Color.Transparent;
            tableLayoutPanel7.BackColor = Color.Transparent;
            tableLayoutPanel8.BackColor = Color.Transparent;
            tableLayoutPanel9.BackColor = Color.Transparent;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel14.BackColor = Color.Transparent;
            _roleid = roleId;
        }
        public FrmPersonel()
        {
            InitializeComponent ();
            dataGridView1.ReadOnly = true;

        }
        SqlConnection connection = new SqlConnection("Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password = Demir123*;");

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            List();
        }

        private void List()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from bilgi", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            connection.Close();

        }

        private void btnekl_Click(object sender, EventArgs e)
        { 
            this.Hide();
          FrmKayit frmKayit = new FrmKayit(_roleid);
            frmKayit.WindowState = this.WindowState;
            frmKayit.Show();
        }

        private void btngncll_Click(object sender, EventArgs e)
        {

            if (_roleid == 1) 
            {
                checkBox1.Visible = true; 
            }
            lblkllnc.Visible = true;
            lblsfr.Visible = true;
            txtkllnc.Visible = true;
            txtsfr.Visible = true;
            btnkydt.Visible = true;
            btnvzg.Visible = true;
            lblacil.Visible = true;
            lbladrs.Visible = true;
            txtadrs.Visible = true;
            lblmail.Visible = true;
            lblphon.Visible = true;
            txtmail.Visible = true;
            txttlfn.Visible = true;
            txtacil.Visible = true;
            label1.Visible = true;
            tableLayoutPanel12.Visible = true;
        
        }
    

        private void btnsl_Click(object sender, EventArgs e)
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

                            string sql = "DELETE FROM bilgi WHERE id=@id";
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

        private void btnkydt_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                object cellValue = dataGridView1.Rows[selectedRowIndex].Cells["id"].Value;

                if (cellValue != null)
                {
                    int id = Convert.ToInt32(cellValue);
                    string username = "UPDATE bilgi SET RoleId= @roleid, Email=@mail, Phone=@phone, Adress=@adrs, [Emergency Contact]=@acil, Username=@usr, Password=@psw  WHERE id=@id";

                    using (SqlConnection connection = new SqlConnection("Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password=Demir123*;"))
                    {
                        using (SqlCommand command = new SqlCommand(username, connection))
                        {
                            int roleid;
                            if (checkBox1.Checked)
                            {
                                roleid = 1;
                            }
                            else
                            {
                                roleid = 2;
                            }
                            command.Parameters.AddWithValue("@roleid", roleid);
                            command.Parameters.AddWithValue("@id", id);
                            command.Parameters.AddWithValue("@usr", txtkllnc.Text);
                            command.Parameters.AddWithValue("@psw", txtsfr.Text);
                            command.Parameters.AddWithValue("@mail", txtmail.Text);
                            command.Parameters.AddWithValue("@phone", txttlfn.Text);
                            command.Parameters.AddWithValue("@adrs", txtadrs.Text);
                            command.Parameters.AddWithValue("@acil", txtacil.Text);
                            try
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                MessageBox.Show("Kayıt güncellendi");
                                List();
                                txtkllnc.Visible = false;
                                txtsfr.Visible = false;
                                lblsfr.Visible = false;
                                lblkllnc.Visible = false;
                                btnkydt.Visible = false;
                                checkBox1 .Visible = false;
                                txtacil.Visible = false;
                                txtadrs.Visible = false;
                                txtmail.Visible = false;
                                txttlfn.Visible = false;
                                lblacil.Visible = false;
                                lbladrs.Visible = false;
                                lblmail.Visible = false;
                                lblphon.Visible = false;
                                btnvzg.Visible = false;
                                tableLayoutPanel12.Visible = false;
                                connection.Close();
                                

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells.Count >= 8)
                {
                    txtkllnc.Text = selectedRow.Cells[1].Value?.ToString();
                    txtsfr.Text = selectedRow.Cells[2].Value?.ToString();
                    txtmail.Text = selectedRow.Cells[4].Value?.ToString();
                    txttlfn.Text = selectedRow?.Cells[5].Value?.ToString();
                    txtadrs.Text = selectedRow.Cells[6].Value?.ToString();
                    txtacil.Text = selectedRow.Cells[7].Value?.ToString();
                }
            }
        }

        private void btngri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBasla frmBasla = new FrmBasla(_roleid);
            frmBasla.WindowState = this.WindowState;
            frmBasla.Show();

        }

        private void btnvzg_Click(object sender, EventArgs e)
        {
            checkBox1.Visible = false;
            lblkllnc.Visible = false;
            lblsfr.Visible = false;
            txtkllnc.Visible = false ;
            txtsfr.Visible = false ;
            btnkydt.Visible = false ;
            btnvzg.Visible = false ;
            txtacil.Visible = false;
            txtadrs.Visible = false;
            txtmail.Visible = false;
            txttlfn.Visible = false;
            lblacil.Visible = false;
            lbladrs.Visible = false;
            lblmail.Visible = false;
            lblphon.Visible = false;
            label1.Visible = false;
            tableLayoutPanel12.Visible = false;
        }

        private void FrmPersonel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
    
}
