namespace WindowsFormsApp1
{
    partial class FrmPersonel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnekl = new System.Windows.Forms.Button();
            this.btnsl = new System.Windows.Forms.Button();
            this.btngncll = new System.Windows.Forms.Button();
            this.lblkllnc = new System.Windows.Forms.Label();
            this.lblsfr = new System.Windows.Forms.Label();
            this.txtkllnc = new System.Windows.Forms.TextBox();
            this.txtsfr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnkydt = new System.Windows.Forms.Button();
            this.btngri = new System.Windows.Forms.Button();
            this.btnvzg = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.txttlfn = new System.Windows.Forms.TextBox();
            this.lblphon = new System.Windows.Forms.Label();
            this.txtadrs = new System.Windows.Forms.TextBox();
            this.lbladrs = new System.Windows.Forms.Label();
            this.txtacil = new System.Windows.Forms.TextBox();
            this.lblacil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(692, 147);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnekl
            // 
            this.btnekl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnekl.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnekl.Location = new System.Drawing.Point(71, 3);
            this.btnekl.Name = "btnekl";
            this.btnekl.Size = new System.Drawing.Size(117, 37);
            this.btnekl.TabIndex = 1;
            this.btnekl.Text = "Yeni Kullanıcı Ekle";
            this.btnekl.UseVisualStyleBackColor = true;
            this.btnekl.Click += new System.EventHandler(this.btnekl_Click);
            // 
            // btnsl
            // 
            this.btnsl.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsl.ForeColor = System.Drawing.Color.Red;
            this.btnsl.Location = new System.Drawing.Point(3, 3);
            this.btnsl.Name = "btnsl";
            this.btnsl.Size = new System.Drawing.Size(119, 34);
            this.btnsl.TabIndex = 2;
            this.btnsl.Text = "Kullanıcı Sil";
            this.btnsl.UseVisualStyleBackColor = true;
            this.btnsl.Click += new System.EventHandler(this.btnsl_Click);
            // 
            // btngncll
            // 
            this.btngncll.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngncll.ForeColor = System.Drawing.Color.Blue;
            this.btngncll.Location = new System.Drawing.Point(3, 3);
            this.btngncll.Name = "btngncll";
            this.btngncll.Size = new System.Drawing.Size(120, 34);
            this.btngncll.TabIndex = 3;
            this.btngncll.Text = "Kullanıcı Güncelle";
            this.btngncll.UseVisualStyleBackColor = true;
            this.btngncll.Click += new System.EventHandler(this.btngncll_Click);
            // 
            // lblkllnc
            // 
            this.lblkllnc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblkllnc.AutoSize = true;
            this.lblkllnc.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblkllnc.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkllnc.Location = new System.Drawing.Point(3, 20);
            this.lblkllnc.Name = "lblkllnc";
            this.lblkllnc.Size = new System.Drawing.Size(75, 16);
            this.lblkllnc.TabIndex = 4;
            this.lblkllnc.Text = "Kullanıcı Adı :";
            this.lblkllnc.Visible = false;
            // 
            // lblsfr
            // 
            this.lblsfr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblsfr.AutoSize = true;
            this.lblsfr.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblsfr.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsfr.Location = new System.Drawing.Point(3, 78);
            this.lblsfr.Name = "lblsfr";
            this.lblsfr.Size = new System.Drawing.Size(37, 16);
            this.lblsfr.TabIndex = 5;
            this.lblsfr.Text = "Şifre :";
            this.lblsfr.Visible = false;
            // 
            // txtkllnc
            // 
            this.txtkllnc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtkllnc.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkllnc.Location = new System.Drawing.Point(94, 18);
            this.txtkllnc.Name = "txtkllnc";
            this.txtkllnc.Size = new System.Drawing.Size(78, 21);
            this.txtkllnc.TabIndex = 7;
            this.txtkllnc.Visible = false;
            // 
            // txtsfr
            // 
            this.txtsfr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtsfr.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsfr.Location = new System.Drawing.Point(94, 75);
            this.txtsfr.Name = "txtsfr";
            this.txtsfr.Size = new System.Drawing.Size(78, 21);
            this.txtsfr.TabIndex = 8;
            this.txtsfr.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "( Tablodan ID Seçiniz )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "( Tablodan ID Seçiniz )";
            // 
            // btnkydt
            // 
            this.btnkydt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnkydt.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkydt.Location = new System.Drawing.Point(36, 3);
            this.btnkydt.Name = "btnkydt";
            this.btnkydt.Size = new System.Drawing.Size(60, 23);
            this.btnkydt.TabIndex = 12;
            this.btnkydt.Text = "Kaydet";
            this.btnkydt.UseVisualStyleBackColor = true;
            this.btnkydt.Visible = false;
            this.btnkydt.Click += new System.EventHandler(this.btnkydt_Click);
            // 
            // btngri
            // 
            this.btngri.Location = new System.Drawing.Point(12, 12);
            this.btngri.Name = "btngri";
            this.btngri.Size = new System.Drawing.Size(22, 22);
            this.btngri.TabIndex = 15;
            this.btngri.Text = "<";
            this.btngri.UseVisualStyleBackColor = true;
            this.btngri.Click += new System.EventHandler(this.btngri_Click);
            // 
            // btnvzg
            // 
            this.btnvzg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnvzg.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvzg.Location = new System.Drawing.Point(36, 32);
            this.btnvzg.Name = "btnvzg";
            this.btnvzg.Size = new System.Drawing.Size(60, 24);
            this.btnvzg.TabIndex = 26;
            this.btnvzg.Text = "Vazgeç";
            this.btnvzg.UseVisualStyleBackColor = true;
            this.btnvzg.Visible = false;
            this.btnvzg.Click += new System.EventHandler(this.btnvzg_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.checkBox1.Location = new System.Drawing.Point(34, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 16);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Yönetici";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            // 
            // txtmail
            // 
            this.txtmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmail.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.Location = new System.Drawing.Point(87, 18);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(78, 21);
            this.txtmail.TabIndex = 29;
            this.txtmail.Visible = false;
            // 
            // lblmail
            // 
            this.lblmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblmail.AutoSize = true;
            this.lblmail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblmail.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmail.Location = new System.Drawing.Point(3, 20);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(40, 16);
            this.lblmail.TabIndex = 28;
            this.lblmail.Text = "Email :";
            this.lblmail.Visible = false;
            // 
            // txttlfn
            // 
            this.txttlfn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txttlfn.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttlfn.Location = new System.Drawing.Point(87, 75);
            this.txttlfn.Name = "txttlfn";
            this.txttlfn.Size = new System.Drawing.Size(78, 21);
            this.txttlfn.TabIndex = 31;
            this.txttlfn.Visible = false;
            // 
            // lblphon
            // 
            this.lblphon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblphon.AutoSize = true;
            this.lblphon.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblphon.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblphon.Location = new System.Drawing.Point(3, 78);
            this.lblphon.Name = "lblphon";
            this.lblphon.Size = new System.Drawing.Size(49, 16);
            this.lblphon.TabIndex = 30;
            this.lblphon.Text = "Telefon :";
            this.lblphon.Visible = false;
            // 
            // txtadrs
            // 
            this.txtadrs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtadrs.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadrs.Location = new System.Drawing.Point(92, 18);
            this.txtadrs.Name = "txtadrs";
            this.txtadrs.Size = new System.Drawing.Size(86, 21);
            this.txtadrs.TabIndex = 33;
            this.txtadrs.Visible = false;
            // 
            // lbladrs
            // 
            this.lbladrs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbladrs.AutoSize = true;
            this.lbladrs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbladrs.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladrs.Location = new System.Drawing.Point(3, 20);
            this.lbladrs.Name = "lbladrs";
            this.lbladrs.Size = new System.Drawing.Size(41, 16);
            this.lbladrs.TabIndex = 32;
            this.lbladrs.Text = "Adres :";
            this.lbladrs.Visible = false;
            // 
            // txtacil
            // 
            this.txtacil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtacil.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtacil.Location = new System.Drawing.Point(92, 75);
            this.txtacil.Name = "txtacil";
            this.txtacil.Size = new System.Drawing.Size(86, 21);
            this.txtacil.TabIndex = 35;
            this.txtacil.Visible = false;
            // 
            // lblacil
            // 
            this.lblacil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblacil.AutoSize = true;
            this.lblacil.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblacil.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblacil.Location = new System.Drawing.Point(3, 78);
            this.lblacil.Name = "lblacil";
            this.lblacil.Size = new System.Drawing.Size(71, 16);
            this.lblacil.TabIndex = 34;
            this.lblacil.Text = "Acil Telefon :";
            this.lblacil.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "(Personel ise boş bırak)";
            this.label1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnkydt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnvzg, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(132, 59);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(132, 44);
            this.tableLayoutPanel2.TabIndex = 38;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(190, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.03704F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.96296F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(138, 115);
            this.tableLayoutPanel3.TabIndex = 39;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnsl, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.57377F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.42623F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(193, 75);
            this.tableLayoutPanel6.TabIndex = 42;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.btngncll, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(202, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(215, 75);
            this.tableLayoutPanel7.TabIndex = 43;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.52252F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.47748F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(269, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(420, 81);
            this.tableLayoutPanel8.TabIndex = 44;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.43931F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.56069F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel14, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 156);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(692, 87);
            this.tableLayoutPanel9.TabIndex = 45;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.btnekl, 0, 0);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.1875F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.8125F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(260, 81);
            this.tableLayoutPanel14.TabIndex = 50;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.249F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.751F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(698, 246);
            this.tableLayoutPanel10.TabIndex = 46;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel15, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel16, 1, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(355, 121);
            this.tableLayoutPanel11.TabIndex = 47;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel12.BackColor = System.Drawing.Color.LightCyan;
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.7192F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.2808F));
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 255);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(698, 127);
            this.tableLayoutPanel12.TabIndex = 48;
            this.tableLayoutPanel12.Visible = false;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel12, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(68, 57);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.45454F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.54546F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(704, 385);
            this.tableLayoutPanel13.TabIndex = 49;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.47525F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.52475F));
            this.tableLayoutPanel15.Controls.Add(this.txtsfr, 1, 1);
            this.tableLayoutPanel15.Controls.Add(this.lblsfr, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.txtkllnc, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.lblkllnc, 0, 0);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(175, 115);
            this.tableLayoutPanel15.TabIndex = 50;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel16.ColumnCount = 2;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.26738F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.73262F));
            this.tableLayoutPanel16.Controls.Add(this.lblphon, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.txtmail, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.lblmail, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.txttlfn, 1, 1);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(184, 3);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(168, 115);
            this.tableLayoutPanel16.TabIndex = 51;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.46809F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.53191F));
            this.tableLayoutPanel17.Controls.Add(this.txtacil, 1, 1);
            this.tableLayoutPanel17.Controls.Add(this.txtadrs, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.lblacil, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.lbladrs, 0, 0);
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(181, 115);
            this.tableLayoutPanel17.TabIndex = 52;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.65722F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.34278F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel17, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(364, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(331, 121);
            this.tableLayoutPanel4.TabIndex = 48;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 466);
            this.Controls.Add(this.tableLayoutPanel13);
            this.Controls.Add(this.btngri);
            this.Name = "FrmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPersonel_FormClosed);
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekl;
        private System.Windows.Forms.Button btnsl;
        private System.Windows.Forms.Button btngncll;
        private System.Windows.Forms.Label lblkllnc;
        private System.Windows.Forms.Label lblsfr;
        private System.Windows.Forms.TextBox txtkllnc;
        private System.Windows.Forms.TextBox txtsfr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnkydt;
        private System.Windows.Forms.Button btngri;
        private System.Windows.Forms.Button btnvzg;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox txttlfn;
        private System.Windows.Forms.Label lblphon;
        private System.Windows.Forms.TextBox txtadrs;
        private System.Windows.Forms.Label lbladrs;
        private System.Windows.Forms.TextBox txtacil;
        private System.Windows.Forms.Label lblacil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}