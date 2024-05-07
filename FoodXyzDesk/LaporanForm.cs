using FoodXyzDesk.ucAdmin;
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
    public partial class LaporanForm : Form
    {
        public LaporanForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new AdminForm().ShowDialog();
        }

        public void showLaporan(DateTime dateFrom, DateTime dateTo)
        {
           foodXyzEntities entities = new foodXyzEntities();

            var laporans = (from a in entities.tbl_transaksi
                            join b in entities.tbl_user
                            on a.id_user equals b.id_user
                            join c in entities.tbl_barang
                            on a.id_barang equals c.id_barang
                            where
                             a.tgl_transaksi.Value.Day >= dateFrom.Day &&
                             a.tgl_transaksi.Value.Day <= dateTo.Day &&

                             a.tgl_transaksi.Value.Month >= dateFrom.Month &&
                             a.tgl_transaksi.Value.Month <= dateTo.Month &&

                             a.tgl_transaksi.Value.Year >= dateFrom.Year &&
                             a.tgl_transaksi.Value.Year <= dateTo.Year
                            select new
                            {
                                  a.id_transaksi,
                                a.tgl_transaksi,
                                a.total_bayar,
                                b.nama
                            }
                        ).ToList();
                
            soldList.DataSource = laporans;
        }

        private void LaporanForm_Load(object sender, EventArgs e)
        {
            showLaporan(dateFrom.Value, dateTo.Value);
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            showLaporan(dateFrom.Value, dateTo.Value);
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
    }
}
