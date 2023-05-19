using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sppApp
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=db-spp");
        public Form1()
        {
            InitializeComponent();
        }

        void command (String query)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            { 
                conn.Close();
            }
        }

        void showData()
        {
            try
            {
                conn.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from siswa", conn);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        void clear()
        {
            txtNisn.Text = string.Empty;
            txtNis.Text = string.Empty;
            txtNama.Text = string.Empty;
            txtIdKelas.Text = string.Empty;
            txtAlamat.Text = string.Empty;
            txtNoTelp.Text = string.Empty;
            txtIdSpp.Text = string.Empty;
            showData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void txtTambah_Click(object sender, EventArgs e)
        {
            if (txtNisn.Text == string.Empty || txtNis.Text == string.Empty || txtNama.Text == string.Empty || txtIdKelas.Text == string.Empty || txtAlamat.Text == string.Empty || txtNoTelp.Text == string.Empty || txtIdSpp.Text == string.Empty)
            {
                MessageBox.Show("semua kolom harus di isi!");
            }
            else
            {
                command("insert into siswa(nisn, nis, nama, id_kelas, alamat, no_telp, id_spp) values ('" + txtNisn.Text + "', '" + txtNis.Text + "', '" + txtNama.Text + "', '" + txtIdKelas.Text + "', '" + txtAlamat.Text + "', '" + txtNoTelp.Text + "', '" + txtIdSpp.Text + "')");
                clear();
            }
        }

        private void txtEdit_Click(object sender, EventArgs e)
        {
            if (txtNisn.Text == string.Empty || txtNis.Text == string.Empty || txtNama.Text == string.Empty || txtIdKelas.Text == string.Empty || txtAlamat.Text == string.Empty || txtNoTelp.Text == string.Empty || txtIdSpp.Text == string.Empty)
            {
                MessageBox.Show("semua kolom harus di isi!");
            }
            else
            {
                command("update siswa set nis = '" + txtNis.Text + "', nama = '" + txtNama.Text + "', id_kelas = '" + txtIdKelas.Text + "', alamat = '" + txtAlamat.Text + "', no_telp = '" + txtNoTelp.Text + "', id_spp = '" + txtIdSpp.Text + "' where nisn = '" + txtNisn.Text + "'");
                clear();
            }
        }

        private void txtHapus_Click(object sender, EventArgs e)
        {
            if (txtNisn.Text == string.Empty || txtNis.Text == string.Empty || txtNama.Text == string.Empty || txtIdKelas.Text == string.Empty || txtAlamat.Text == string.Empty || txtNoTelp.Text == string.Empty || txtIdSpp.Text == string.Empty)
            {
                MessageBox.Show("semua kolom harus di isi!");
            }
            else
            {
                command("delete from siswa where nisn = '" + txtNisn.Text + "'");
                clear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.dataGridView1.Rows[e.RowIndex];

            txtNisn.Text = dr.Cells[0].Value.ToString();
            txtNis.Text = dr.Cells[1].Value.ToString();
            txtNama.Text = dr.Cells[2].Value.ToString();
            txtIdKelas.Text = dr.Cells[3].Value.ToString();
            txtAlamat.Text = dr.Cells[4].Value.ToString();
            txtNoTelp.Text = dr.Cells[5].Value.ToString();
            txtIdSpp.Text = dr.Cells[6].Value.ToString();
        }
    }
}
