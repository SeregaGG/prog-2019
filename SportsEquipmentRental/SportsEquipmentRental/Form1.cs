using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SportsEquipmentRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Фотография|*.jpg" };
            var dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var eq = new Equip() { Equipment = new Equipment() };
            if (eq.ShowDialog(this) == DialogResult.OK)
            {
                listBox1.Items.Add(eq.Equipment);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = listBox1.SelectedItem is Equipment;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Equipment)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
