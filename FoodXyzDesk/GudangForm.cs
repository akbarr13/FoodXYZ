using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXyzDesk
{
    public partial class GudangForm : Form
    {
        tbl_barang barang = new tbl_barang();

        public GudangForm()
        {
            InitializeComponent();
        }
        public void clearText()
        {
            var textboxes = panel1.Controls.OfType<TextBox>().ToList();
            foreach (var textbox in textboxes)
            {
                textbox.Text = string.Empty;
            }
        }
        public bool Validate(Control control)
        {
            bool isValid = true;

            isValid = (
                control.Controls.OfType<TextBox>().Where(x => string.IsNullOrEmpty(x.Text)).Count() == 0);

            return isValid;
        }

        public void showAllBarang()
        {
            foodXyzEntities entities = new foodXyzEntities();
            var barangs = entities.tbl_barang.ToList();
            barangList.DataSource = barangs;

        }

        private void GudangForm_Load(object sender, EventArgs e)
        {
            showBarang("");
            barang.id_barang = 0;
        }

        private void barangList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                DataGridViewRow row = barangList.Rows[e.RowIndex];
                barang.id_barang = (int)row.Cells[0].Value;
                kodeForm.Text = row.Cells[1].Value.ToString();
                namaForm.Text = row.Cells[2].Value.ToString();
                expiredDate.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                jumlahForm.Text = row.Cells[4].Value.ToString();
                satuanForm.Text = row.Cells[5].Value.ToString();
                hargaForm.Text = row.Cells[6].Value.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Validate(panel1))
            {
                foodXyzEntities entities = new foodXyzEntities();
                tbl_barang barangs = new tbl_barang();
                barangs.kode_barang = kodeForm.Text;
                barangs.nama_barang = namaForm.Text;
                barangs.expired_date = expiredDate.Value.Date;
                barangs.jumlah_barang = int.Parse(jumlahForm.Text.ToString());
                barangs.satuan = satuanForm.Text;
                barangs.harga_satuan = int.Parse(hargaForm.Text);
                entities.tbl_barang.Add(barangs);
                entities.SaveChanges();
                showAllBarang();
               
            }
            else
            {
                MessageBox.Show("Semua form harus terisi!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Validate(panel1) || barang.id_barang == 0)
            {
                foodXyzEntities entities = new foodXyzEntities();
                var barangs = entities.tbl_barang.First(x => x.id_barang == barang.id_barang);
                barangs.kode_barang = kodeForm.Text;
                barangs.nama_barang = namaForm.Text;
                barangs.expired_date = expiredDate.Value.Date;
                barangs.jumlah_barang = int.Parse(jumlahForm.Text.ToString());
                barangs.satuan = satuanForm.Text;
                barangs.harga_satuan = int.Parse(hargaForm.Text);

                entities.SaveChanges();
                showAllBarang();
                clearText();
            }
            else
            {
                MessageBox.Show("Barang tidak valid!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Validate(panel1) || barang.id_barang == 0)
            {
                foodXyzEntities entities = new foodXyzEntities();
                var barangs = entities.tbl_barang.First(x => x.id_barang == barang.id_barang);

                entities.tbl_barang.Remove(barangs);
                entities.SaveChanges();
                showAllBarang();
                clearText();
            }
            else
            {
                MessageBox.Show("Barang tidak valid!");
            }
        }

            private void showBarang(string nama)
            {
                foodXyzEntities entities = new foodXyzEntities();
                var barangs = entities.tbl_barang.Where(x => x.nama_barang.Contains(nama)).ToList();
                barangList.DataSource = barangs;
            }

            private void searchForm_TextChanged(object sender, EventArgs e)
            {
                showBarang(searchForm.Text);

            }

        private void jumlahForm_TextChanged(object sender, EventArgs e)
        {

        }

        private void jumlahForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    } 

