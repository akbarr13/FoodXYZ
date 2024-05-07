using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXyzDesk.ucAdmin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }


        public void showUser(string username)
        {
            foodXyzEntities entities= new foodXyzEntities();
            var user = entities.tbl_user.Where(x=> x.username.Contains(username)).ToList();

            userList.DataSource = user;
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            showUser("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new LaporanForm().ShowDialog();
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
