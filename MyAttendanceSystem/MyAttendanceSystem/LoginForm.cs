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
    public partial class LoginForm : Form
    {
        public bool LoginFlag { get; set; }
        public int UserID { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            LoginFlag = false;
        }

        private void metroBtnLogin_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.UsersTableAdapter usersTableAdapter = new DataSet1TableAdapters.UsersTableAdapter();
            DataTable dt = usersTableAdapter.GetDataByUserNameAndPswd(metroTbUser.Text.Trim(), metroTbPassword.Text.Trim());
            if (dt.Rows.Count > 0)
            {   // valid user
                MessageBox.Show("Login Succesifull");
                UserID = int.Parse(dt.Rows[0]["UserID"].ToString());
                LoginFlag = true;
            }
            else
            {   // user (not exist or user/password) invalid

                MessageBox.Show("Access Denied");
                LoginFlag = false;
            }
            Close();
        }
    }
}
