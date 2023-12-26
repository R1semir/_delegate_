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
    public partial class Delegate : Form
    {
        public Delegate()
        {
            InitializeComponent();
        }

        // klavyeden girilen sayıyı ayrı metotlarda tutup tek bir temsilcide birleştir 
        // 4x^2 + 5x +10;
        //küp
        //kare
        //cember alan
        //cember cevre

        void bul( int s1 ,int s2)
        {
            listBox1.Items.Add((s1 * s1) * 4 + (s1 * 5) + 10);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
