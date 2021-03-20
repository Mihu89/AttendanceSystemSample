namespace MyAttendanceSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageAttendance = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPageReports = new MetroFramework.Controls.MetroTabPage();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelClass = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabelDate = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.metroButton = new MetroFramework.Controls.MetroButton();
            this.metroButtonAddClass = new MetroFramework.Controls.MetroButton();
            this.metroButtonAddStudent = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPageAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPageAttendance);
            this.metroTabControl1.Controls.Add(this.metroTabPageReports);
            this.metroTabControl1.Location = new System.Drawing.Point(13, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1382, 684);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPageAttendance
            // 
            this.metroTabPageAttendance.Controls.Add(this.metroButtonAddStudent);
            this.metroTabPageAttendance.Controls.Add(this.metroButtonAddClass);
            this.metroTabPageAttendance.Controls.Add(this.metroButton);
            this.metroTabPageAttendance.Controls.Add(this.metroButtonSave);
            this.metroTabPageAttendance.Controls.Add(this.dataGridView1);
            this.metroTabPageAttendance.Controls.Add(this.metroLabelDate);
            this.metroTabPageAttendance.Controls.Add(this.dateTimePicker1);
            this.metroTabPageAttendance.Controls.Add(this.metroLabelClass);
            this.metroTabPageAttendance.Controls.Add(this.metroComboBox1);
            this.metroTabPageAttendance.HorizontalScrollbarBarColor = true;
            this.metroTabPageAttendance.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageAttendance.Name = "metroTabPageAttendance";
            this.metroTabPageAttendance.Size = new System.Drawing.Size(1374, 645);
            this.metroTabPageAttendance.TabIndex = 0;
            this.metroTabPageAttendance.Text = "Attendance";
            this.metroTabPageAttendance.VerticalScrollbarBarColor = true;
            // 
            // metroTabPageReports
            // 
            this.metroTabPageReports.HorizontalScrollbarBarColor = true;
            this.metroTabPageReports.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageReports.Name = "metroTabPageReports";
            this.metroTabPageReports.Size = new System.Drawing.Size(1374, 645);
            this.metroTabPageReports.TabIndex = 1;
            this.metroTabPageReports.Text = "Reports";
            this.metroTabPageReports.VerticalScrollbarBarColor = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(7, 50);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 2;
            // 
            // metroLabelClass
            // 
            this.metroLabelClass.AutoSize = true;
            this.metroLabelClass.Location = new System.Drawing.Point(7, 14);
            this.metroLabelClass.Name = "metroLabelClass";
            this.metroLabelClass.Size = new System.Drawing.Size(76, 19);
            this.metroLabelClass.TabIndex = 3;
            this.metroLabelClass.Text = "Select Class";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // metroLabelDate
            // 
            this.metroLabelDate.AutoSize = true;
            this.metroLabelDate.Location = new System.Drawing.Point(201, 25);
            this.metroLabelDate.Name = "metroLabelDate";
            this.metroLabelDate.Size = new System.Drawing.Size(74, 19);
            this.metroLabelDate.TabIndex = 5;
            this.metroLabelDate.Text = "Select Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 514);
            this.dataGridView1.TabIndex = 6;
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(786, 99);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(75, 23);
            this.metroButtonSave.TabIndex = 7;
            this.metroButtonSave.Text = "Save";
            // 
            // metroButton
            // 
            this.metroButton.Location = new System.Drawing.Point(786, 159);
            this.metroButton.Name = "metroButton";
            this.metroButton.Size = new System.Drawing.Size(75, 23);
            this.metroButton.TabIndex = 8;
            this.metroButton.Text = "Clear";
            // 
            // metroButtonAddClass
            // 
            this.metroButtonAddClass.Location = new System.Drawing.Point(1218, 21);
            this.metroButtonAddClass.Name = "metroButtonAddClass";
            this.metroButtonAddClass.Size = new System.Drawing.Size(130, 23);
            this.metroButtonAddClass.TabIndex = 9;
            this.metroButtonAddClass.Text = "Add Class";
            this.metroButtonAddClass.Click += new System.EventHandler(this.metroButtonAddClass_Click);
            // 
            // metroButtonAddStudent
            // 
            this.metroButtonAddStudent.Location = new System.Drawing.Point(1218, 56);
            this.metroButtonAddStudent.Name = "metroButtonAddStudent";
            this.metroButtonAddStudent.Size = new System.Drawing.Size(130, 23);
            this.metroButtonAddStudent.TabIndex = 10;
            this.metroButtonAddStudent.Text = "Add Student";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 770);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "MainForm";
            this.Text = "Atendance System";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPageAttendance.ResumeLayout(false);
            this.metroTabPageAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPageAttendance;
        private MetroFramework.Controls.MetroTabPage metroTabPageReports;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabelClass;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabelDate;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButtonAddStudent;
        private MetroFramework.Controls.MetroButton metroButtonAddClass;
        private MetroFramework.Controls.MetroButton metroButton;
    }
}

