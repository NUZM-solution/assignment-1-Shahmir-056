using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class data_form : Form
    {
        public data_form()
        {
            InitializeComponent();
        }

        private void data_form_Load(object sender, EventArgs e)
        {
            // Define columns
            data_courses.ColumnCount = 5;
            data_courses.Columns[0].Name = "Course Code";
            data_courses.Columns[1].Name = "Course Title";
            data_courses.Columns[2].Name = "Obtained Marks";
            data_courses.Columns[3].Name = "Grade";
            data_courses.Columns[4].Name = "Status";

            // Add sample data (you can add real data from a database or input later)
            string[] row1 = new string[] { "CS101", "Introduction to CS", "85", "A", "Pass" };
            string[] row2 = new string[] { "MATH201", "Calculus", "78", "B+", "Pass" };
            string[] row3 = new string[] { "ENG103", "English", "92", "A+", "Pass" };

            // Add rows to the DataGridView
            data_courses.Rows.Add(row1);
            data_courses.Rows.Add(row2);
            data_courses.Rows.Add(row3);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
