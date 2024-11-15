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
    public partial class FrmBasla : Form
    {
        private int _roleId;
        public FrmBasla()
        {
            InitializeComponent();
        }
        public FrmBasla(int roleId)
        {
            InitializeComponent();
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel4.BackColor = Color.Transparent;
            _roleId = roleId;
            if (roleId == 2)
            {
                btnhrkt.Enabled = false; 
                btnprsnl.Enabled = false;
            }
        }
           
    SqlConnection connection = new SqlConnection("Data Source=COM1300244\\SQLEXPRESS;Initial Catalog=Eczane; User ID=sa; Password = Demir123*;");

      
        private void btnst_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSatis frmSatis = new FrmSatis(_roleId);
            frmSatis.WindowState = this.WindowState;
            frmSatis.Show();
        }

        private void btnprsnl_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPersonel frmPersonel = new FrmPersonel(_roleId);
           frmPersonel.WindowState = this.WindowState;
            frmPersonel.Show();
        }

        private void btnstk_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStok frmStok = new FrmStok(_roleId);
            frmStok.WindowState = this.WindowState;
            frmStok.Show();
        }

        private void btnhrkt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHareket frmHareket = new FrmHareket(_roleId);
            frmHareket.WindowState = this.WindowState;
            frmHareket.Show();
        }

        private void FrmBasla_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void btncks_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.WindowState = this.WindowState;
            frmGiris.Show();

                
        }

        private void FrmBasla_Load(object sender, EventArgs e)
        {
        }
    }
}
