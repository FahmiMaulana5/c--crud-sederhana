namespace sppApp
{
    partial class Form1
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
            this.txtNisn = new System.Windows.Forms.TextBox();
            this.txtNis = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtIdKelas = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.txtIdSpp = new System.Windows.Forms.TextBox();
            this.txtTambah = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.Button();
            this.txtHapus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNisn
            // 
            this.txtNisn.Location = new System.Drawing.Point(101, 30);
            this.txtNisn.Name = "txtNisn";
            this.txtNisn.Size = new System.Drawing.Size(159, 20);
            this.txtNisn.TabIndex = 0;
            // 
            // txtNis
            // 
            this.txtNis.Location = new System.Drawing.Point(101, 73);
            this.txtNis.Name = "txtNis";
            this.txtNis.Size = new System.Drawing.Size(159, 20);
            this.txtNis.TabIndex = 1;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(101, 119);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(159, 20);
            this.txtNama.TabIndex = 2;
            // 
            // txtIdKelas
            // 
            this.txtIdKelas.Location = new System.Drawing.Point(101, 166);
            this.txtIdKelas.Name = "txtIdKelas";
            this.txtIdKelas.Size = new System.Drawing.Size(159, 20);
            this.txtIdKelas.TabIndex = 3;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(306, 30);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(159, 20);
            this.txtAlamat.TabIndex = 4;
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.Location = new System.Drawing.Point(306, 73);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(159, 20);
            this.txtNoTelp.TabIndex = 5;
            // 
            // txtIdSpp
            // 
            this.txtIdSpp.Location = new System.Drawing.Point(306, 119);
            this.txtIdSpp.Name = "txtIdSpp";
            this.txtIdSpp.Size = new System.Drawing.Size(159, 20);
            this.txtIdSpp.TabIndex = 6;
            // 
            // txtTambah
            // 
            this.txtTambah.Location = new System.Drawing.Point(306, 162);
            this.txtTambah.Name = "txtTambah";
            this.txtTambah.Size = new System.Drawing.Size(75, 23);
            this.txtTambah.TabIndex = 7;
            this.txtTambah.Text = "Tambah";
            this.txtTambah.UseVisualStyleBackColor = true;
            this.txtTambah.Click += new System.EventHandler(this.txtTambah_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(390, 162);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(75, 23);
            this.txtEdit.TabIndex = 8;
            this.txtEdit.Text = "Edit";
            this.txtEdit.UseVisualStyleBackColor = true;
            this.txtEdit.Click += new System.EventHandler(this.txtEdit_Click);
            // 
            // txtHapus
            // 
            this.txtHapus.Location = new System.Drawing.Point(475, 162);
            this.txtHapus.Name = "txtHapus";
            this.txtHapus.Size = new System.Drawing.Size(75, 23);
            this.txtHapus.TabIndex = 9;
            this.txtHapus.Text = "Hapus";
            this.txtHapus.UseVisualStyleBackColor = true;
            this.txtHapus.Click += new System.EventHandler(this.txtHapus_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 141);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 360);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHapus);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.txtTambah);
            this.Controls.Add(this.txtIdSpp);
            this.Controls.Add(this.txtNoTelp);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtIdKelas);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNis);
            this.Controls.Add(this.txtNisn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNisn;
        private System.Windows.Forms.TextBox txtNis;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtIdKelas;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.TextBox txtIdSpp;
        private System.Windows.Forms.Button txtTambah;
        private System.Windows.Forms.Button txtEdit;
        private System.Windows.Forms.Button txtHapus;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

