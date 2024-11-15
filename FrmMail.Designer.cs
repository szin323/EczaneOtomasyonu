namespace WindowsFormsApp1
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.btngeri = new System.Windows.Forms.Button();
            this.btnkpa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.btnmail = new System.Windows.Forms.Button();
            this.txtkullnc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(12, 12);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(21, 21);
            this.btngeri.TabIndex = 0;
            this.btngeri.Text = "<";
            this.btngeri.UseVisualStyleBackColor = true;
            // 
            // btnkpa
            // 
            this.btnkpa.Location = new System.Drawing.Point(358, 12);
            this.btnkpa.Name = "btnkpa";
            this.btnkpa.Size = new System.Drawing.Size(21, 21);
            this.btnkpa.TabIndex = 1;
            this.btnkpa.Text = "X";
            this.btnkpa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email Adresi :";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(76, 207);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(236, 20);
            this.txtmail.TabIndex = 3;
            // 
            // btnmail
            // 
            this.btnmail.Location = new System.Drawing.Point(98, 245);
            this.btnmail.Name = "btnmail";
            this.btnmail.Size = new System.Drawing.Size(74, 22);
            this.btnmail.TabIndex = 4;
            this.btnmail.Text = "Gönder";
            this.btnmail.UseVisualStyleBackColor = true;
            this.btnmail.Click += new System.EventHandler(this.btnmail_Click);
            // 
            // txtkullnc
            // 
            this.txtkullnc.Location = new System.Drawing.Point(76, 136);
            this.txtkullnc.Name = "txtkullnc";
            this.txtkullnc.Size = new System.Drawing.Size(114, 20);
            this.txtkullnc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lütfen kullanıcı adı ve e-posta adresini doldurun.";
            this.label3.Visible = false;
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(391, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkullnc);
            this.Controls.Add(this.btnmail);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkpa);
            this.Controls.Add(this.btngeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnkpa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Button btnmail;
        private System.Windows.Forms.TextBox txtkullnc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}