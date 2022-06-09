/*
 * Created by SharpDevelop.
 * User: lenovo
 * Date: 6/9/2022
 * Time: 6:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AppCustomKaosBernama
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxWarna = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxUkuran = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxNoTelp = new System.Windows.Forms.TextBox();
			this.buttonTambah = new System.Windows.Forms.Button();
			this.buttonPerbarui = new System.Windows.Forms.Button();
			this.buttonBersihkan = new System.Windows.Forms.Button();
			this.buttonHapus = new System.Windows.Forms.Button();
			this.textBoxCari = new System.Windows.Forms.TextBox();
			this.buttonCari = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Khaki;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, -1);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(45, 20, 0, 0);
			this.label1.Size = new System.Drawing.Size(1135, 69);
			this.label1.TabIndex = 0;
			this.label1.Text = "Custom Kaos Bernama";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(53, 401);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1022, 245);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(52, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "ID Pesanan";
			// 
			// textBoxID
			// 
			this.textBoxID.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
			this.textBoxID.Location = new System.Drawing.Point(200, 108);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(307, 29);
			this.textBoxID.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(52, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 26);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nama";
			// 
			// textBoxNama
			// 
			this.textBoxNama.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
			this.textBoxNama.Location = new System.Drawing.Point(200, 160);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(307, 29);
			this.textBoxNama.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(52, 214);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Warna";
			// 
			// comboBoxWarna
			// 
			this.comboBoxWarna.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxWarna.FormattingEnabled = true;
			this.comboBoxWarna.Items.AddRange(new object[] {
									"putih",
									"hitam",
									"merah",
									"kuning",
									"hijau",
									"biru",
									"cokelat",
									"oranye",
									"ungu"});
			this.comboBoxWarna.Location = new System.Drawing.Point(200, 213);
			this.comboBoxWarna.Name = "comboBoxWarna";
			this.comboBoxWarna.Size = new System.Drawing.Size(307, 29);
			this.comboBoxWarna.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
			this.label5.Location = new System.Drawing.Point(52, 265);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Ukuran";
			// 
			// comboBoxUkuran
			// 
			this.comboBoxUkuran.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
			this.comboBoxUkuran.FormattingEnabled = true;
			this.comboBoxUkuran.Items.AddRange(new object[] {
									"S",
									"M",
									"L",
									"XL",
									"XXL"});
			this.comboBoxUkuran.Location = new System.Drawing.Point(200, 266);
			this.comboBoxUkuran.Name = "comboBoxUkuran";
			this.comboBoxUkuran.Size = new System.Drawing.Size(307, 29);
			this.comboBoxUkuran.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
			this.label6.Location = new System.Drawing.Point(52, 318);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 31);
			this.label6.TabIndex = 10;
			this.label6.Text = "No. Telepon";
			// 
			// textBoxNoTelp
			// 
			this.textBoxNoTelp.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
			this.textBoxNoTelp.Location = new System.Drawing.Point(200, 318);
			this.textBoxNoTelp.Name = "textBoxNoTelp";
			this.textBoxNoTelp.Size = new System.Drawing.Size(307, 29);
			this.textBoxNoTelp.TabIndex = 11;
			// 
			// buttonTambah
			// 
			this.buttonTambah.BackColor = System.Drawing.Color.DarkKhaki;
			this.buttonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonTambah.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTambah.Location = new System.Drawing.Point(532, 177);
			this.buttonTambah.Name = "buttonTambah";
			this.buttonTambah.Size = new System.Drawing.Size(111, 35);
			this.buttonTambah.TabIndex = 12;
			this.buttonTambah.Text = "Tambah";
			this.buttonTambah.UseVisualStyleBackColor = false;
			this.buttonTambah.Click += new System.EventHandler(this.ButtonTambahClick);
			// 
			// buttonPerbarui
			// 
			this.buttonPerbarui.BackColor = System.Drawing.Color.DarkKhaki;
			this.buttonPerbarui.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonPerbarui.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
			this.buttonPerbarui.Location = new System.Drawing.Point(532, 223);
			this.buttonPerbarui.Name = "buttonPerbarui";
			this.buttonPerbarui.Size = new System.Drawing.Size(111, 35);
			this.buttonPerbarui.TabIndex = 13;
			this.buttonPerbarui.Text = "Perbarui";
			this.buttonPerbarui.UseVisualStyleBackColor = false;
			this.buttonPerbarui.Click += new System.EventHandler(this.ButtonPerbaruiClick);
			// 
			// buttonBersihkan
			// 
			this.buttonBersihkan.BackColor = System.Drawing.Color.DarkKhaki;
			this.buttonBersihkan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonBersihkan.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
			this.buttonBersihkan.Location = new System.Drawing.Point(534, 269);
			this.buttonBersihkan.Name = "buttonBersihkan";
			this.buttonBersihkan.Size = new System.Drawing.Size(109, 35);
			this.buttonBersihkan.TabIndex = 14;
			this.buttonBersihkan.Text = "Bersihkan";
			this.buttonBersihkan.UseVisualStyleBackColor = false;
			this.buttonBersihkan.Click += new System.EventHandler(this.ButtonBersihkanClick);
			// 
			// buttonHapus
			// 
			this.buttonHapus.BackColor = System.Drawing.Color.DarkKhaki;
			this.buttonHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonHapus.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
			this.buttonHapus.Location = new System.Drawing.Point(534, 314);
			this.buttonHapus.Name = "buttonHapus";
			this.buttonHapus.Size = new System.Drawing.Size(109, 35);
			this.buttonHapus.TabIndex = 15;
			this.buttonHapus.Text = "Hapus";
			this.buttonHapus.UseVisualStyleBackColor = false;
			this.buttonHapus.Click += new System.EventHandler(this.ButtonHapusClick);
			// 
			// textBoxCari
			// 
			this.textBoxCari.Font = new System.Drawing.Font("Yu Gothic UI", 8F);
			this.textBoxCari.Location = new System.Drawing.Point(750, 357);
			this.textBoxCari.Name = "textBoxCari";
			this.textBoxCari.Size = new System.Drawing.Size(242, 29);
			this.textBoxCari.TabIndex = 16;
			// 
			// buttonCari
			// 
			this.buttonCari.BackColor = System.Drawing.Color.DarkKhaki;
			this.buttonCari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCari.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
			this.buttonCari.Location = new System.Drawing.Point(1010, 353);
			this.buttonCari.Name = "buttonCari";
			this.buttonCari.Size = new System.Drawing.Size(65, 37);
			this.buttonCari.TabIndex = 17;
			this.buttonCari.Text = "Cari";
			this.buttonCari.UseVisualStyleBackColor = false;
			this.buttonCari.Click += new System.EventHandler(this.ButtonCariClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(793, 109);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(199, 216);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.ClientSize = new System.Drawing.Size(1133, 673);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonCari);
			this.Controls.Add(this.textBoxCari);
			this.Controls.Add(this.buttonHapus);
			this.Controls.Add(this.buttonBersihkan);
			this.Controls.Add(this.buttonPerbarui);
			this.Controls.Add(this.buttonTambah);
			this.Controls.Add(this.textBoxNoTelp);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBoxUkuran);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBoxWarna);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxNama);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Custom Kaos Berwarna";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonCari;
		private System.Windows.Forms.TextBox textBoxCari;
		private System.Windows.Forms.Button buttonHapus;
		private System.Windows.Forms.Button buttonBersihkan;
		private System.Windows.Forms.Button buttonPerbarui;
		private System.Windows.Forms.Button buttonTambah;
		private System.Windows.Forms.TextBox textBoxNoTelp;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxUkuran;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxWarna;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
	}
}
