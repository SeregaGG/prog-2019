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

        public Buyer buyer;
        public Seller seller;
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
            buyer = new Buyer();
            seller = new Seller();

            buyer.Name = textBox2.Text;
            buyer.Surname = textBox1.Text ;
            buyer.Patronymic = textBox3.Text;

            seller.Patronymic = textBox6.Text;
            seller.Name = textBox5.Text;
            seller.Surname = textBox4.Text;

            var eq = new Equip() { Equipment = new Equipment() };
            if (eq.ShowDialog(this) == DialogResult.OK)
            {
                listBox1.Items.Add(seller);
                listBox1.Items.Add(buyer);
                listBox1.Items.Add(eq.Equipment);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = listBox1.SelectedItem is string;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is string)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Участники|*.equip" };

            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;
            

            string[] spp = new string[listBox1.Items.Count];
            for (int i = 0; i < spp.Length; i++)
                spp[i] = listBox1.Items[i].ToString();

            var Form = new CompletingForm
            {
                Seller = seller,
                Buyer = buyer,
                Equip = spp,
            };
            
            var xs = new XmlSerializer(typeof(CompletingForm));

            var file = File.Create(sfd.FileName);

            var stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            seller.Photo = stream.ToArray();

            xs.Serialize(file, Form);
            file.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Участники|*.equip" };

            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;
            var xs = new XmlSerializer(typeof(CompletingForm));
            var file = File.OpenRead(ofd.FileName);
            var Form = (CompletingForm)xs.Deserialize(file);
            file.Close();

            textBox1.Text = Form.Buyer.Surname;
            textBox2.Text = Form.Buyer.Name;
            textBox3.Text = Form.Buyer.Patronymic;



            textBox4.Text = Form.Seller.Surname;
            textBox5.Text = Form.Seller.Name;
            textBox6.Text = Form.Seller.Patronymic;

            var ms = new MemoryStream(Form.Seller.Photo);
            pictureBox1.Image = Image.FromStream(ms);

            listBox1.Items.Clear();

            for (int i = 0; i < Form.Equip.Length; i++)
                listBox1.Items.Add(Form.Equip[i]);
        }

        

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
