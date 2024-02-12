using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.ShowDialog();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();  
            kitapEkle.ShowDialog(); 
        }

        private void kitapTeslimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapTeslim kitapTeslim = new KitapTeslim();    
            kitapTeslim.ShowDialog();   
        }
            

        private void MorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void SariToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void MaviToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void KirmiziToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ekle butonu tıklandı;)");

        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapıştır butonu tıklandı;)");

        }
    }
}
