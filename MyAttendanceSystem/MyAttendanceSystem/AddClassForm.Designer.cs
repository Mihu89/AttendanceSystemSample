namespace MyAttendanceSystem
{
    partial class AddClassForm
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
            this.metroTextBoxClassName = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonSaveClass = new MetroFramework.Controls.MetroButton();
            this.metroLabelClassName = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroTextBoxClassName
            // 
            this.metroTextBoxClassName.Location = new System.Drawing.Point(32, 54);
            this.metroTextBoxClassName.Name = "metroTextBoxClassName";
            this.metroTextBoxClassName.Size = new System.Drawing.Size(217, 23);
            this.metroTextBoxClassName.TabIndex = 0;
            // 
            // metroButtonSaveClass
            // 
            this.metroButtonSaveClass.Location = new System.Drawing.Point(278, 54);
            this.metroButtonSaveClass.Name = "metroButtonSaveClass";
            this.metroButtonSaveClass.Size = new System.Drawing.Size(75, 23);
            this.metroButtonSaveClass.TabIndex = 1;
            this.metroButtonSaveClass.Text = "Save";
            this.metroButtonSaveClass.Click += new System.EventHandler(this.metroButtonSaveClass_Click);
            // 
            // metroLabelClassName
            // 
            this.metroLabelClassName.AutoSize = true;
            this.metroLabelClassName.Location = new System.Drawing.Point(32, 19);
            this.metroLabelClassName.Name = "metroLabelClassName";
            this.metroLabelClassName.Size = new System.Drawing.Size(81, 19);
            this.metroLabelClassName.TabIndex = 2;
            this.metroLabelClassName.Text = "Class Name:";
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 102);
            this.Controls.Add(this.metroLabelClassName);
            this.Controls.Add(this.metroButtonSaveClass);
            this.Controls.Add(this.metroTextBoxClassName);
            this.Name = "AddClassForm";
            this.Text = "AddClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxClassName;
        private MetroFramework.Controls.MetroButton metroButtonSaveClass;
        private MetroFramework.Controls.MetroLabel metroLabelClassName;
    }
}