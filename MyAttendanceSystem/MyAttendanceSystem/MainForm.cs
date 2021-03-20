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
            // TODO: This line of code loads data into the 'dataSet1.Classes' table. You can move, or remove it, as needed.
            
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
                    statusStripUser.Text = UserID.ToString();
                    LoggedIn = 1;

                    this.classesTableAdapter.Fill(this.dataSet1.Classes);
                    classesBindingSource.Filter = "UserID = '" + UserID.ToString() + "'";
                }
            }
            
        }

        private void metroButtonAddClass_Click(object sender, EventArgs e)
        {
            AddClassForm addClassForm = new AddClassForm();
            addClassForm.UserID = this.UserID;
            addClassForm.ShowDialog();
        }

        private void metroButtonAddStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
