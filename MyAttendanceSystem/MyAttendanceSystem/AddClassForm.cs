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
    public partial class AddClassForm : Form
    {
        public int UserID { get; set; }
        public AddClassForm()
        {
            InitializeComponent();
        }

        private void metroButtonSaveClass_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ClassesTableAdapter classesTableAdapter = new DataSet1TableAdapters.ClassesTableAdapter();
            classesTableAdapter.AddClass(metroTextBoxClassName.Text, UserID);
            Close();
        }
    }
}
