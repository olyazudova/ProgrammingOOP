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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new();
        public ItemsTab()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add items to listBox

            var name = NameBox.Text;
            double.TryParse(CostBox.Text, out double cost);
            var info = InfoBox.Text;


            Item newItem = new Item(name, info, cost);
            _items.Add(newItem);

            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = "Name";

            NameBox.Text = null;
            CostBox.Text = null;
            InfoBox.Text = null;
            IdBox.Text = null;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                int index2 = ItemsListBox.SelectedIndex;


                IdBox.Text = _items[index2].Id.ToString();
                NameBox.Text = _items[index2].Name;
                CostBox.Text = _items[index2].Cost.ToString();
                InfoBox.Text = _items[index2].Info;

            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(NameBox.Text, 200, nameof(NameBox));
                NameBox.ForeColor = System.Drawing.Color.Black;
            }
            catch (ArgumentException)
            {
                NameBox.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Описание должно быть меньше 200 символов.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // remove items from listBox

            if (ItemsListBox.SelectedIndex >= 0)
            {
                int index = ItemsListBox.SelectedIndex;
                _items.RemoveAt(index);
                ItemsListBox.DataSource = null;
                ItemsListBox.DataSource = _items;
                ItemsListBox.DisplayMember = "Name";

                InfoBox.Text = null;
                IdBox.Text = null;
                NameBox.Text = null;
                CostBox.Text = null;
            }
            else
            {
                MessageBox.Show("выберите элемент для удаления");
            }
        }

        private void InfoBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(InfoBox.Text, 1000, nameof(InfoBox));
                InfoBox.ForeColor = System.Drawing.Color.Black;
            }
            catch (ArgumentException)
            {
                InfoBox.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Описание должно быть меньше 1000 символов.");
            }
        }

        private void CostBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value;
                Double.TryParse(CostBox.Text, out value);
                ValueValidator.AssertStringOnLength(value, 0, 100000, nameof(CostBox));
                CostBox.ForeColor = System.Drawing.Color.Black;
            }
            catch (ArgumentException)
            {
                CostBox.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Цена должна быть от 0 до 100000.");
            }
        }
    }
}
