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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           usernameForm.Text = string.Empty;
            passwordForm.Text = string.Empty;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            foodXyzEntities entities = new foodXyzEntities();

            var username = usernameForm.Text;
            var password = passwordForm.Text;

            if (username != string.Empty && password != string.Empty)
            {
                if (entities.tbl_user.Any(x => x.username == username))
                {
                    var user = entities.tbl_user.FirstOrDefault(x => x.username == username);

                    {
                        if (user.password == password)
                        {
                            LoginSession.user = user;
                            tbl_log log = new tbl_log();
                            Hide();
                            log.id_user = user.id_user;
                            log.waktu = DateTime.Now;
                            log.aktivitas = "Login";
                            entities.tbl_log.Add(log);
                            entities.SaveChanges();
                            switch (user.tipe_user)
                            {
                                case "admin":
                                    new LogActivityForm().Show();
                                    break;
                                case "gudang":
                                    new GudangForm().Show(); 
                                    break;
                                case "kasir":
                                    new KasirForm().Show();
                                    break;
                            }



                        }
                        else
                        {
                            MessageBox.Show("Username atau password salah!");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Username atau password salah!");
                }

            }
            else
            {
                MessageBox.Show("Semua data harus terisi!");
            }

        }
    }
}
