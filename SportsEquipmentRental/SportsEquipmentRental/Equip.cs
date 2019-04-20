using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsEquipmentRental
{
    public partial class Equip : Form
    {
        public Equip()
        {
            InitializeComponent();
        }

        public Equipment Equipment { get; set; }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equipment.Price = textBox9.Text;
            Equipment.SportEquip = textBox7.Text;
            Equipment.PriceOfRental = textBox8.Text;
            Equipment.Manufacturer = textBox10.Text;
            Equipment.CreationDate = dateTimePicker1.Value;
            foreach (string i in Equipment.TypeOfSports)
            {
                if (comboBox1.Text == i) 
                {
                    Equipment.TypeOfSport = i;
                    break;
                }
                else
                {
                    Equipment.TypeOfSport = "Другое";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
