using OOPEncapsulation_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPEncapsulation_0
{
    public partial class Form1 : Form
    {



        /*
                  --ENcapsulation

        1 => Class'ın ogelerine yapılan erişimin kontrol altına alınmasını ve bu kontrolün class'ın kendisi tarafından yapılmasını saglayan bir prensiptir (Seperation of Concerns - Sorumlulukların ayrılması felsefesini uygular)

        2 => Aynı zamanda normal şartlar altında ayrıntılı davranısların tek tek calıstıgı sistemlerde bu davranısların tek bir merkezden tetiklenmesini saglayarak işlemleri daha kontrollü bir hale getirir...
         
         
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Urun u = new Urun();
                u.Isim = "asdaasdsad";
                //u.Fiyat = 0;







                MessageBox.Show(u.Fiyat.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnYarat_Click(object sender, EventArgs e)
        {
            Kategori k = new Kategori();
           
        }
    }
}
