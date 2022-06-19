using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sezar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string v = ""; // v isimli bir değişken oluşturdum.
            v = veritext.Text; // veritext isimli textboxdan gelen veriyi v isimli değişkene atadım.
            char[] karakterler = v.ToCharArray(); // v isimli değişkenden gelen verileri char dizine atadım.
            foreach (char eleman in karakterler) // dizideki tüm elemanlara ulaşmak için foreach döngüsü kullandım.
            {
                sifreliveritext.Text += Convert.ToChar(eleman+3).ToString(); //eleman isimli değişkendeki değeri chara dönüştürdüm. Şifreleme işlemini yapmak için eleman+3 ifadesini kullandım.
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sifre = " "; //sifre isimli değişken oluşturdum.
            sifre = sifreliveritext.Text; //sifreliveritext isimli textboxdan gelen veriri sifre isimli değişkene atadım.
            char[] karakterler2 = sifre.ToCharArray(); //sifredeki veriyi arrayliste atadım.
            foreach (char eleman2 in karakterler2)
            {
                veritext.Text += Convert.ToChar(eleman2 - 3).ToString();//eleman2deki verileri chara dönüştürdüm. Bu sefer şifreyi çözme işlemi için -3 ifadesini kullandım.
            }
            
        }
    }
}
