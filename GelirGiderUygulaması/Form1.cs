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
    public partial class GelirGider : Form
    {
        public GelirGider()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtOzet_TextChanged(object sender, EventArgs e)
        {

        }
        String IslemDetay()
        {
            //string ozet = null;
            if (CBSecim.SelectedIndex == 0)
            {
                txtOzet.Text = CBSecim.Text + " " + txtTutar.Text + " " + txtaciklama.Text + " " + radiobuttonoku();
            }
            else if (CBSecim.SelectedIndex == 1)
            {
                txtOzet.Text = CBSecim.Text + " " + txtTutar.Text + " " + txtaciklama.Text + " " + radiobuttonoku();
            }
            else
            {
                MessageBox.Show("işlem Türünü seçiniz");
            }

            return txtOzet.Text;
        }

        string radiobuttonoku()
        {
            string sonuc = null;

            if (rdbSaglik.Checked) sonuc = rdbSaglik.Text;
            else if (rdbKiyafet.Checked) sonuc = rdbKiyafet.Text;
            else if (rdbRestoran.Checked) sonuc = rdbRestoran.Text;
            else if (rdbSpor.Checked) sonuc = rdbSpor.Text;
            else if (rdbUlasim.Checked) sonuc = rdbUlasim.Text;
            else if (rdbEglence.Checked) sonuc = rdbEglence.Text;
            else if (rdbMarket.Checked) sonuc = rdbMarket.Text;
            else if (rdbEvgiderleri.Checked) sonuc = rdbEvgiderleri.Text;
            else
            {
                if (rdbDiger.Checked)
                {
                    sonuc = rdbDiger.Text + " " + txtDiger.Text;
                }
            }
            {
                return sonuc;
            }
        }

        private void rdbSaglik_CheckedChanged(object sender, EventArgs e)
        {
            IslemDetay();

        }

        private void rdbKiyafet_CheckedChanged(object sender, EventArgs e)
        {
            IslemDetay();
        }

        private void rdbRestoran_CheckedChanged(object sender, EventArgs e)
        {
            IslemDetay();
        }

        private void rdbSpor_CheckedChanged(object sender, EventArgs e)
        {
            IslemDetay();
        }

        private void rdbDiger_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rdbDiger.Checked)
            {
                Aciklama.Visible = true;
                txtDiger.Visible = true;
            }
            else 
            {
                Aciklama.Visible = false;
                txtDiger.Visible = false;
            }
            IslemDetay();
        }

        private void rdbUlasim_CheckedChanged(object sender, EventArgs e)
        {
            IslemDetay();
        }

        private void rdbEglence_CheckedChanged(object sender, EventArgs e)
        {
            IslemDetay();
        }

        private void rdbMarket_CheckedChanged(object sender, EventArgs e)
        {
            IslemDetay();
        }

        private void rdbEvgiderleri_CheckedChanged(object sender, EventArgs e)
        {
            IslemDetay();
        }

        private void txtTutar_TextChanged(object sender, EventArgs e)
        {
            IslemDetay();
        }

        private void txtaciklama_TextChanged(object sender, EventArgs e)
        {

            IslemDetay();
           
        }

        private void GelirGider_Load(object sender, EventArgs e)
        {

            Directory.CreateDirectory(@"C:\Users\NajjSum\Desktop\Butce");
            if (!Directory.Exists(@"C:\Users\NajjSum\Desktop\Butce")) 
            {
              
            }

        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (txtTutar.Text == " ")

            {
                txtTutar.BackColor = Color.Yellow;
                MessageBox.Show("Sarı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası");
            }
            else
            {
                //...
                // Kullanıcı Kayıt İşlemi

            }
            if (CBSecim.SelectedIndex==0)
            {
                double butce = double.Parse(txtTutar.Text);
                totalbutce += butce;
                FileStream Fs = new FileStream(@"C:\Users\NajjSum\Desktop\Gelir.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(Fs);
                sw.WriteLine(txtOzet.Text);
                sw.Close();
                textBox2.Text = totalbutce.ToString();
                
            }
            else if (CBSecim.SelectedIndex == 1)
            {
                double butce = double.Parse(txtTutar.Text);
                totalbutce -= butce;
                FileStream Fs = new FileStream(@"C:\Users\NajjSum\Desktop\Gider.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(Fs);
                sw.WriteLine(txtOzet.Text);
                sw.Close();
                textBox2.Text = totalbutce.ToString();
            }
            txtTutar.Clear();
            txtaciklama.Clear();
            txtOzet.Clear();
            
        }

        double totalbutce = 0;
        private void txtDiger_TextChanged(object sender, EventArgs e)
        {
            if (txtDiger.Text == " ")
            MessageBox.Show("Sarı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası");
        }

        private void lblpara_Click(object sender, EventArgs e)
        {
         
        }

        private void btnOzetGetir_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\NajjSum\Desktop\Gider.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string[] gelir = sr.ReadToEnd().Split('\n');
            foreach (var item in gelir)
            {
                listBox1.Items.Add(item.ToString());
            }
            FileStream fis = new FileStream(@"C:\Users\NajjSum\Desktop\Gelir.txt", FileMode.Open, FileAccess.Read);
            StreamReader oku = new StreamReader(fis);
            string[] gider = oku.ReadToEnd().Split('\n');
            foreach (var item in gider)
            {
                listBox2.Items.Add(item);
            }

            sr.Close();
            oku.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
