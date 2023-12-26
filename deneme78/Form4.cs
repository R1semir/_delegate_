using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme78
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        // klavyeden girilen sayıyı ayrı metotlarda tutup tek bir temsilcide birleştir 
        // 4x^2 + 5x +10;
        //küp
        //kare
        //cember alan
        //cember cevre
        delegate void islem(int p1);

        void soru (int x1)
        {
            listBox1.Items.Add((x1*x1)*4+(x1*5)+10);
        }

        void küp(int s1)
        {
            listBox1.Items.Add(s1 * s1 * s1);
        }

        void kare(int s2)
        {
            listBox1.Items.Add(s2 * s2);
        }
        void cemberalan(int s3)
        {
            listBox1.Items.Add((s3 * s3) * Math.PI);
        }
        void cembercevre(int s4)
        {
            listBox1.Items.Add(2 * Math.PI * s4);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int s9 = Convert.ToInt32(textBox1.Text);
            islem islemler = new islem(soru);
            islemler += küp;
            islemler += kare;
            islemler += cemberalan;
            islemler += cembercevre;
            islemler(s9);

        }
    }
}
