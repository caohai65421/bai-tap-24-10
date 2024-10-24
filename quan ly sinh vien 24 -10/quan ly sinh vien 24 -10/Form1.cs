using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace quan_ly_sinh_vien_24__10
{
    public partial class Form1 : Form
    {
        private List<Student> studentsList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maSV = textid.Text;
            string tenSV = textname.Text;
            string lopHoc = textclass.Text;

            if (!string.IsNullOrEmpty(maSV) && !string.IsNullOrEmpty(tenSV) && !string.IsNullOrEmpty(lopHoc))
            {
                studentsList.Add(new Student(maSV, tenSV, lopHoc));
                UpdateDataGridView();
                ClearInputFields();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (students.SelectedRows.Count > 0)
            {
                int selectedIndex = students.SelectedRows[0].Index;

                string maSV = textid.Text;
                string tenSV = textname.Text;
                string lopHoc = textclass.Text;

                if (!string.IsNullOrEmpty(maSV) && !string.IsNullOrEmpty(tenSV) && !string.IsNullOrEmpty(lopHoc))
                {
                    studentsList[selectedIndex].MaSV = maSV;
                    studentsList[selectedIndex].TenSV = tenSV;
                    studentsList[selectedIndex].LopHoc = lopHoc;

                    UpdateDataGridView();
                    ClearInputFields();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (students.SelectedRows.Count > 0)
            {
                int selectedIndex = students.SelectedRows[0].Index;
                studentsList.RemoveAt(selectedIndex);
                UpdateDataGridView();
                ClearInputFields();
            }
        }

        private void students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitializeDataGridView()
        {
            students.ColumnCount = 3;
            students.Columns[0].Name = "Mã Sinh Viên";
            students.Columns[1].Name = "Tên Sinh Viên";
            students.Columns[2].Name = "Lớp Học";

            students.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            students.MultiSelect = false;
        }
        private void UpdateDataGridView()
        {
            students.Rows.Clear();
            foreach (var student in studentsList)
            {
                students.Rows.Add(student.MaSV, student.TenSV, student.LopHoc);
            }
        }

        // Xóa trắng các TextBox sau khi thêm, sửa hoặc xóa
        private void ClearInputFields()
        {
            textid.Clear();
            textname.Clear();
            textclass.Clear();
        }
        public class Student
        {
            public string MaSV { get; set; }
            public string TenSV { get; set; }
            public string LopHoc { get; set; }

            public Student(string maSV, string tenSV, string lopHoc)
            {
                MaSV = maSV;
                TenSV = tenSV;
                LopHoc = lopHoc;
            }
        }
    }
}

