namespace WinFormsApp2
{
    partial class data_form
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
            data_courses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)data_courses).BeginInit();
            SuspendLayout();
            // 
            // data_courses
            // 
            data_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_courses.Location = new Point(169, 121);
            data_courses.Name = "data_courses";
            data_courses.RowHeadersWidth = 62;
            data_courses.Size = new Size(824, 256);
            data_courses.TabIndex = 0;
            data_courses.CellContentClick += dataGridView1_CellContentClick;
            // 
            // data_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 507);
            Controls.Add(data_courses);
            Name = "data_form";
            Text = "Shamir";
            Load += data_form_Load;
            ((System.ComponentModel.ISupportInitialize)data_courses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data_courses;
    }
}