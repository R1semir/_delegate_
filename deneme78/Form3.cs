using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme78
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        // klavyeden girilen sayıyı ayrı metotlarda tutup tek bir temsilcide birleştir 
        // 4x^2 + 5x +10;
        //küp
        //kare
        //cember alan
        //cember cevre

        delegate void islemler(int p1);
       void soru1(int s2)
        {
           
            listBox1.Items.Add((s2 * s2) * 4 + (s2 * 5) + 10); 
            
        }
        void kup(int s1)
        {
            listBox1.Items.Add(s1 * s1 * s1); 
        }
        void kare(int s3)
        {
            listBox1.Items.Add(s3 * s3);
        }
        void cember(int s4)
        {
            listBox1.Items.Add((s4 * s4) * Math.PI);
        }
        void cevre(int s5)
        {
            listBox1.Items.Add(2 * Math.PI * s5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s3 = Convert.ToInt32(txtSoru.Text);
           
            islemler islem = new islemler(soru1);
            islem += kup;
            islem += kare;
            islem += cember;
            islem += cevre;
            islem(s3);
            
            
        }
    }
}
