using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Staff> staffList = new List<Staff>();
        BindingSource source = new BindingSource();

        public Form1()
        {
            InitializeComponent();
           // initData();

            source.DataSource = staffList;
            groupBox.DataSource = source;

            groupBox.DisplayMember = "fullName";
            groupBox.ValueMember = "fullName";

        }
        private void initData()
        {
          //  staffLst.Add(new Staff { firstName = "john", lastName = "Doe" });
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Staff newStaff = new Staff();
            newStaff.firstName = FirstNameLabel.Text;
            newStaff.lastName = LastNameLabel.Text;
            staffList.Add(newStaff);

            source.ResetBindings(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Staff newStaff = new Staff();
            newStaff.firstName = FirstNameLabel.Text;
            newStaff.lastName = LastNameLabel.Text;
            if(newStaff.lastName != "LastName")
            staffList.Add(newStaff);

            source.ResetBindings(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
