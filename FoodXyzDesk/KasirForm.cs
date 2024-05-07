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
    public partial class KasirForm : Form
    {
        tbl_barang barang = new tbl_barang();
        public KasirForm()
        {
            InitializeComponent();
        }

        public void showAllMenu()
        {
            foodXyzEntities entities = new foodXyzEntities();
            var barangs = entities.tbl_barang.ToList();
            foreach(var barang in barangs)
            {
                if(barang.kode_barang != null)
                {
                    menuPick.Items.Add(barang.kode_barang);
                }
                else
                {
                    continue;
                }
               
            }
        }

        public void getmenu(string kode_barang)
        {
            foodXyzEntities entities = new foodXyzEntities();
             barang = entities.tbl_barang.First(x=> x.kode_barang == kode_barang);

            
        }

        private void KasirForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = LoginSession.user.nama;

            showAllMenu();
            hargaLabel.Text = "0";
        }

        public int num = 1;

        private void menuPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            getmenu(menuPick.Text);
          
            hargaForm.Text = barang.harga_satuan.ToString();
            qtyForm.Text = "1";
            totalForm.Text =(int.Parse(hargaForm.Text.ToString()) * int.Parse(qtyForm.Text.ToString())).ToString();

        }

        private void qtyForm_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(qtyForm.Text.ToString()))
            {
                totalForm.Text = (int.Parse(hargaForm.Text.ToString()) * int.Parse(qtyForm.Text.ToString())).ToString();
            }

        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            foodXyzEntities entities = new foodXyzEntities();
           var barangs = entities.tbl_barang.First(x => x.kode_barang == menuPick.Text);
         

            keranjang.Rows.Add(new object[]
            {
                "TR" + num++,
                menuPick.Text,
                barangs.nama_barang.ToString(),
                hargaForm.Text,
                qtyForm.Text,
                totalForm.Text,
                
            });

        }
        DataGridViewRow row;
        private void keranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                row = keranjang.Rows[e.RowIndex];
                menuPick.Text = row.Cells[1].Value.ToString();
                qtyForm.Text = row.Cells[4].Value.ToString();
               
           


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foodXyzEntities entities = new foodXyzEntities();
            tbl_log log = new tbl_log();
            Hide();
            log.id_user = LoginSession.user.id_user;
            log.waktu = DateTime.Now;
            log.aktivitas = "Logout";
            entities.tbl_log.Add(log);
            entities.SaveChanges();
            new LoginForm().Show();
        }
        
        private void keranjang_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            
         
        }
        public int hargatotal = 0;
        private void keranjang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
       
            for (int i = 0; i < keranjang.Rows.Count; i++)
            {
                DataGridViewRow row = keranjang.Rows[i];
                var subtotal = int.Parse(row.Cells[5].Value.ToString());
                hargatotal += subtotal;

            }

            hargaLabel.Text = hargatotal.ToString();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            row.Cells[1].Value = menuPick.Text;
            row.Cells[4].Value = qtyForm.Text;
            row.Cells[5].Value = totalForm.Text;
        }

        public bool isPaid = false;

        private void button6_Click(object sender, EventArgs e)
        {
            if(int.Parse(hargaLabel.Text.ToString()) > int.Parse(bayarForm.Text.ToString())){

            }
            else
            {
                kembalianLabel.Text = (int.Parse(bayarForm.Text.ToString()) - int.Parse(hargaLabel.Text.ToString())).ToString();
                isPaid = true;
            }
        }

       

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            if(isPaid)
            {
                foodXyzEntities entities = new foodXyzEntities();
                for (int i = 0; i < keranjang.Rows.Count; i++)
                {
                    DataGridViewRow row = keranjang.Rows[i];
                    var kode_barang = row.Cells[1].Value.ToString();
                    var id_barang = entities.tbl_barang.First(x => x.kode_barang == kode_barang).id_barang;
                     tbl_transaksi transaksi = new tbl_transaksi();
                    transaksi.no_transaksi = row.Cells[0].Value.ToString();
                    transaksi.id_barang = id_barang;
                    transaksi.id_user = LoginSession.user.id_user;
                    transaksi.tgl_transaksi = DateTime.Now.Date;
                    transaksi.total_bayar = int.Parse(row.Cells[5].Value.ToString());
                    entities.tbl_transaksi.Add(transaksi);


                        }
                entities.SaveChanges();

                MessageBox.Show("Data berhasil disimpan!");

            }
            else
            {
                MessageBox.Show("Mohon bayar terlebih dahulu!");
            }
        }
    }
}
