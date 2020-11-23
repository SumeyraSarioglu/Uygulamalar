using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelirGiderUygulaması
{
    public partial class Butce : Form
    {
        public Butce()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            //GelirGider gelirgider = new GelirGider();
            //gelirgider.lblpara.Text = textBox1.Text.ToString();

            FileStream Fs = new FileStream(@"C:\Users\NajjSum\Desktop\Butce.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(Fs);
            sw.WriteLine(textBox1.Text);
            sw.Close();
            Butce butce = new Butce();
            butce.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
