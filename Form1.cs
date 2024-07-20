using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;



        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text != "" && textBox3.Text != "")
            {
                decimal totalprintopay = Convert.ToInt32(comboBox3.Text) * Convert.ToInt32(textBox3.Text);
                textBox2.Text = totalprintopay.ToString();




            }
            else {
                textBox2.Text = "0";
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //printing purpose
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = Properties.Resources.download;
            Image newimage = bm;
            e.Graphics.DrawImage(newimage, 25, 25, newimage.Width, newimage.Height);
            e.Graphics.DrawString("Client Name: " + textBox1.Text, new Font("Arial", 12,FontStyle.Regular),Brushes.Black,new Point(25,180));
            e.Graphics.DrawString("Product Name: " + comboBox1.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Current Price: " + textBox3.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString("cash or card: " + comboBox2.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 240));
            e.Graphics.DrawString("Quantity: " + comboBox3.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 260));
            e.Graphics.DrawString("Total Price: " + textBox2.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 280));

        }
    }
}
