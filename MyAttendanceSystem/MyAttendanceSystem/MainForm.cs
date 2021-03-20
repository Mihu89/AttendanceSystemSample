using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAttendanceSystem
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public int LoggedIn { get; set; }
        public int UserID { get; set; }
        public MainForm()
        {
            InitializeComponent();
            LoggedIn = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (LoggedIn == 0)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();

                if (loginForm.LoginFlag == false)
                {
                    Close();
                }
                else
                {
                    UserID = loginForm.UserID;
                    LoggedIn = 1;
                }
            }
            
        }
    }
}
