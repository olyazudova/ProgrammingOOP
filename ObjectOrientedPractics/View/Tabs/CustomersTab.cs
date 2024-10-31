using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new();

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(FullNameBox.Text, 300, nameof(FullNameBox));
                FullNameBox.ForeColor = System.Drawing.Color.Black;
            }
            catch (ArgumentException)
            {
                FullNameBox.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Описание должно быть меньше 200 символов.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(AddressBox.Text, 500, nameof(AddressBox));
                AddressBox.ForeColor = System.Drawing.Color.Black;
            }
            catch (ArgumentException)
            {
                AddressBox.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Описание должно быть меньше 500 символов.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add customers to listBox

            var fullname = FullNameBox.Text;
            var address = AddressBox.Text;

            Customer newCustomer = new Customer(fullname, address);
            _customers.Add(newCustomer);

            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
            CustomersListBox.DisplayMember = "FullName";

            AddressBox.Text = null;
            FullNameBox.Text = null;
            IdBox.Text = null;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // remove customers from listBox

            if (CustomersListBox.SelectedIndex >= 0)
            {
                int index = CustomersListBox.SelectedIndex;
                _customers.RemoveAt(index);
                CustomersListBox.DataSource = null;
                CustomersListBox.DataSource = _customers;
                CustomersListBox.DisplayMember = "FullName";

                IdBox.Text = null;
                FullNameBox.Text = null;
                AddressBox.Text = null;
            }
            else
            {
                MessageBox.Show("выберите элемент для удаления");
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                int index3 = CustomersListBox.SelectedIndex;


                IdBox.Text = _customers[index3].Id.ToString();
                FullNameBox.Text = _customers[index3].Fullname;
                AddressBox.Text = _customers[index3].Address;

            }
        }
    }
}
