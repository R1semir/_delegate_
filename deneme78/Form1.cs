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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void islemler(int p1, int p2);

        void toplam(int sayi1, int sayi2)
        {
            listBox1.Items.Add(sayi1 + sayi2);
        }

        void fark (int x1, int x2)
        {
            listBox1.Items.Add(x1 - x2);
        }

        void  carpim( int v1,int v2)
        {
            listBox1.Items.Add(v1 * v2);
        }

        void  bolum(int q1,int q2)
        {
            listBox1.Items.Add(q1 / q2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            islemler islem = new islemler(toplam);
            islem += fark;
            islem += carpim;
            islem += bolum;
            islem(10, 5);



          //  listBox1.Items.Add(islem(10, 5));
         /*  
            listBox1.Items.Add(toplam(10, 5));
            listBox1.Items.Add(fark(10, 5));
            listBox1.Items.Add(carpim(10, 5));
            listBox1.Items.Add(bolum(10, 5));
         */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
