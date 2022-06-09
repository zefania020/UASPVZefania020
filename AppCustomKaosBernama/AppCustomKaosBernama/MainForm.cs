// Nama: Zefania Agustina Lumbangaol, NIM: 201401020, KOM: A

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppCustomKaosBernama
{
	public partial class MainForm : Form
	{
        private SqlCommand cmd; 
        private DataSet ds; 
        private SqlDataAdapter da;
        
        Koneksi Konn = new Koneksi();
        
		public MainForm()
		{
			InitializeComponent();
		}
		
		void TampilkanTabel()
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select * from TabelPesanan ORDER BY id_pesanan", conn);
			
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "TabelPesanan");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "TabelPesanan";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			TampilkanTabel();
			IDOtomatis();
		}
		
		int hargakaos;
		void HitungHargaKaos(){
 			if(comboBoxUkuran.Text == "S"){
 				hargakaos = 35000;
 			}
 			else if(comboBoxUkuran.Text == "M"){
 				hargakaos = 40000;
 			}
 			else if(comboBoxUkuran.Text == "L"){
 				hargakaos = 45000;
 			}
 			else if(comboBoxUkuran.Text == "XL"){
 				hargakaos = 50000;
 			}
 			else if(comboBoxUkuran.Text == "XXL"){
 				hargakaos = 55000;
 			}
		}
		
		void ButtonTambahClick(object sender, EventArgs e)
		{
			if(textBoxID.Text.Trim() == "" || textBoxNama.Text.Trim() == "" ||  comboBoxWarna.Text.Trim() == "" || comboBoxUkuran.Text.Trim() == "" || textBoxNoTelp.Text.Trim() == "")
 			{
 				MessageBox.Show("Harap isi kolom yang masih kosong");
 			}
 			else
 			{
 				SqlConnection conn = Konn.GetConn();
 				try
 				{
 					conn.Open();
 					HitungHargaKaos();
 					cmd = new SqlCommand("INSERT INTO TabelPesanan VALUES('"+textBoxID.Text+"','"+textBoxNama.Text+"','"+comboBoxWarna.Text+"','"+comboBoxUkuran.Text+"','"+textBoxNoTelp.Text+"','"+hargakaos+"')", conn);
 					cmd.ExecuteNonQuery();
 					MessageBox.Show("Berhasil menambah data!");
 					TampilkanTabel();
 					Bersihkan();
 				}
 				catch(Exception ex)
 				{
 					MessageBox.Show("Gagal menambah data!");
 				}
 			}
		}
		
		void ButtonPerbaruiClick(object sender, EventArgs e)
		{
			if(textBoxID.Text.Trim() == "" || textBoxNama.Text.Trim() == "" ||  comboBoxWarna.Text.Trim() == "" || comboBoxUkuran.Text.Trim() == "" || textBoxNoTelp.Text.Trim() == "")
 			{
 				MessageBox.Show("Harap isi kolom yang masih kosong");
 			}
 			else
 			{
 				SqlConnection conn = Konn.GetConn();
 				try
 				{
 					conn.Open();
 					HitungHargaKaos();
 					cmd = new SqlCommand("UPDATE TabelPesanan SET id_pesanan='"+textBoxID.Text+"', nama='"+textBoxNama.Text+"', warna='"+comboBoxWarna.Text+"', ukuran='"+comboBoxUkuran.Text+"', no_telepon='"+textBoxNoTelp.Text+"', harga='"+hargakaos+"' WHERE id_pesanan='"+textBoxID.Text+"'", conn);
 					cmd.ExecuteNonQuery();
 					MessageBox.Show("Berhasil memperbarui data!");
 					TampilkanTabel();
 					Bersihkan();
 				}
 				catch(Exception ex)
 				{
 					MessageBox.Show("Gagal memperbarui data!");
 				}
 			}	
		}
		
		void ButtonBersihkanClick(object sender, EventArgs e)
		{
			Bersihkan();
		}
		
		void ButtonHapusClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Hapus "+textBoxNama.Text+"?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				SqlConnection conn = Konn.GetConn();
 				conn.Open();
 				cmd = new SqlCommand("DELETE TabelPesanan WHERE id_pesanan='"+textBoxID.Text+"'", conn);
 				cmd.ExecuteNonQuery();
 				MessageBox.Show("Berhasil menghapus data!");
 				TampilkanTabel();
 				Bersihkan();
			}			
		}
		
		void IDOtomatis(){
			long hitung;
			string urutan;
			SqlDataReader rd;
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select id_pesanan from TabelPesanan where id_pesanan in(select max(id_pesanan) from TabelPesanan) order by id_pesanan desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if(rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["id_pesanan"].ToString().Length - 3, 3))+1;
				string kodeurutan = "000" + hitung;
				urutan = "KAOS" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
			} else {
				urutan = "KAOS001";
			}
			rd.Close();
			textBoxID.Text = urutan;
			conn.Close();
		}
		
		void ButtonCariClick(object sender, EventArgs e)
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select * from TabelPesanan where id_pesanan like '%"+textBoxCari.Text+"%' or nama like '%"+textBoxCari.Text+"%'", conn);
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "TabelPesanan");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "TabelPesanan";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}					
		}
		
		void Bersihkan()
		{
			textBoxID.Text = "";
			textBoxNama.Text = "";
			comboBoxWarna.Text = "";
			comboBoxUkuran.Text = "";
			textBoxNoTelp.Text = "";
		    TampilkanTabel();
		    IDOtomatis();
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				textBoxID.Text = row.Cells["id_pesanan"].Value.ToString(); 
				textBoxNama.Text = row.Cells["nama"].Value.ToString();
				comboBoxWarna.Text = row.Cells["warna"].Value.ToString();
				comboBoxUkuran.Text = row.Cells["ukuran"].Value.ToString();
				textBoxNoTelp.Text = row.Cells["no_telepon"].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}				
		}
	}
}
