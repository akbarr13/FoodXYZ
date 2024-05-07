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
    public partial class KelolaUserForm : Form
    {

        tbl_user user = new tbl_user();
        public KelolaUserForm()
        {
            InitializeComponent();
        }

        public bool Validate(Control control)
        {
            bool isValid = true;

            isValid = (
                control.Controls.OfType<TextBox>().Where(x => string.IsNullOrEmpty(x.Text)).Count() == 0);

            return isValid;
        }

        public void showUser(string nama)
        {
            foodXyzEntities entities = new foodXyzEntities();
          
            var users = (from a in entities.tbl_user
                         where a.nama.Contains(nama)
                         select new
                         {
                             ID = a.id_user,
                             tipe = a.tipe_user,
                             nama = a.nama,
                             alamat = a.alamat,
                             telepon = a.telpon,

                         }).ToList();

            userList.DataSource = users;
        }
 

        private void KelolaUserForm_Load(object sender, EventArgs e)
        {
            user.id_user = 0;
            showUser("");
            tipeUserBox.SelectedIndex = 1;

        }

        public void clearText() {
            var textboxes = panel1.Controls.OfType<TextBox>().ToList();
            foreach ( var textbox in textboxes )
            {
                textbox.Text = string.Empty;
            }
        }

        private void searchForm_TextChanged(object sender, EventArgs e)
        {
            showUser(searchForm.Text.ToString().Trim());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foodXyzEntities entities = new foodXyzEntities();
            if (Validate(panel1))
            {
                tbl_user user = new tbl_user();
                user.tipe_user = tipeUserBox.Text.ToLower();
                user.nama = namaForm.Text;
                user.telpon = teleponForm.Text;
                user.alamat = alamatForm.Text;
                user.username = usernameForm.Text;
                user.password = passwordForm.Text;
                entities.tbl_user.Add(user);
                entities.SaveChanges();
                showUser("");
                clearText();
                MessageBox.Show("Berhasil menambahkan user!");
            }
            else
            {
                MessageBox.Show("Semua form harus terisi!");
            }
   

        }

        private void userList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                DataGridViewRow row = userList.Rows[e.RowIndex];
                var user_id = int.Parse(row.Cells[0].Value.ToString());
                user.id_user = user_id;
                foodXyzEntities entities = new foodXyzEntities();
                var userData = entities.tbl_user.First(x => x.id_user.Equals(user_id));
                tipeUserBox.Text = row.Cells[1].Value as string;
                namaForm.Text = row.Cells[2].Value as string;
                alamatForm.Text = row.Cells[3].Value as string;
                teleponForm.Text = row.Cells[4].Value as string;
                usernameForm.Text = userData.username;
                passwordForm.Text = userData.password;
               

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Validate(panel1))
            {
                foodXyzEntities entities = new foodXyzEntities();
                var userData = entities.tbl_user.First(x => x.id_user == user.id_user);
                userData.tipe_user = tipeUserBox.Text.ToLower();
                userData.nama = namaForm.Text;
                userData.telpon = teleponForm.Text;
                userData.alamat = alamatForm.Text;
                userData.username = usernameForm.Text;
                userData.password = passwordForm.Text;
                entities.SaveChanges();
                MessageBox.Show("Edit user berhasil!"); 
                showUser("");
                clearText();
            }
            else
            {
                MessageBox.Show("User tidak valid");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Validate(panel1) && user.id_user == 0)
            {
                foodXyzEntities entities = new foodXyzEntities();
                var userData = entities.tbl_user.First(x => x.id_user == user.id_user);
                entities.tbl_user.Remove(userData);
                entities.SaveChanges();
                showUser("");
                clearText();
            }
            else
            {
                MessageBox.Show("User tidak valid");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new LaporanForm().ShowDialog();
        }

        private void teleponForm_TextChanged(object sender, EventArgs e)
        {

        }

        private void teleponForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
            LoginSession.user = null;
            new LoginForm().Show();
        }
    }
}
