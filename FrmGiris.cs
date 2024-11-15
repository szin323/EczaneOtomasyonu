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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel4.BackColor = Color.Transparent;

        }
        SqlConnection connection = new SqlConnection("Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password = Demir123*;");

           
        private void btngr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtkllnci.Text) || string.IsNullOrEmpty(txtsfr.Text))
            {
                label3.Visible = true;
                lblynlis.Visible = false;
                return;
            }

            try
            {
                connection.Open();

                string sql = "SELECT RoleID FROM bilgi WHERE username=@Kullncı AND password=@pwd";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Kullncı", txtkllnci.Text);
                command.Parameters.AddWithValue("@pwd", txtsfr.Text);

                object role = command.ExecuteScalar();

                if (role != null) 
                {
                    int roleId = Convert.ToInt32(role); 

                    this.Hide();
                    FrmBasla frmBasla = new FrmBasla (roleId);
                    frmBasla.WindowState = this.WindowState;
                    frmBasla.Show();
                }
                else 
                {
                    lblynlis.Visible = true;
                    label3.Visible = false;
                    txtkllnci.Clear();
                    txtsfr.Clear();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void FrmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
        }

      
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
           this.Hide(); 
            FrmHesapOls frmHesapOls = new FrmHesapOls();
            frmHesapOls.Show();
        }
    }
}
