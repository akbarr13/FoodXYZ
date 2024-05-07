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
    public partial class LogActivityForm : Form
    {
        public LogActivityForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showLogs(datePicker.Value);
        }
        public void showLogs(DateTime date)
        {
            foodXyzEntities entities = new foodXyzEntities();

            var logs = (from a in entities.tbl_log
                        join b in entities.tbl_user
                        on a.id_user equals b.id_user
                        where a.waktu.Value.Day == datePicker.Value.Day &&
                        a.waktu.Value.Month == datePicker.Value.Month&&
                        a.waktu.Value.Year == datePicker.Value.Year select new
                        {
                            ID = a.id_log,
                            Username = b.username,
                            Waktu = a.waktu,
                            Aktivitas = a.aktivitas,

                        }).ToList();

            logList.DataSource = logs;
        }
        private void LogActivityForm_Load(object sender, EventArgs e)
        {
            showLogs(datePicker.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void userFormBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new KelolaUserForm().ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
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
            new LoginForm().Show();
        }
    }
}
