using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Ad = txtName.Text;
            emp.Soyad = txtSurname.Text;
            emp.Departman = cmbDepartman.Text;
            emp.IseGirisTarihi = dateTimePicker1.Value;
            emp.DogumTarihi = dateTimePicker2.Value;

            lstEmployee.Items.Add(emp);
        }

        private void btnShowDepartman_Click(object sender, EventArgs e)
        {
            if (lstEmployee.SelectedItem != null)
            {
                Employee selectedEmp = (Employee)lstEmployee.SelectedItem;
                MessageBox.Show("Secilen Personel Departman"+selectedEmp.Departman);
            }
        }
    }
}
