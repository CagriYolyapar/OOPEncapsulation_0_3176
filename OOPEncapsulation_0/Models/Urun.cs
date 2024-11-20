using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPEncapsulation_0.Models
{
    public class Urun
    {

        //Property'ler aslında veri sakladıgınız alanlar degildir...Property'ler arka tarafta gizli olan bir alana veri gonderen veya o alandan veri getiren aracılardır...

        //Property'ler siz hicbir şey yapmadıgınızda runtime'da otomatik olarak bir field(global degişken) acarlar...

        //Property'lerin get ve set metotlarına bir şey yazılmadıgı sürece Encapsulation algoritması uygulamayı  bekleyemezsiniz...Ancak ve ancak bu metotlardan herhangi biri üzerinde bir kontrol algoritması gerçekleştiginde veya bu metotlara bir müdahalede bulunuldugunda bir Encapsulation prensibi uygulamıs olursunuz...

        //Biz normal şartlarda alttaki syntax'ta (Isim) acılan property'lere Autoproperty deriz...BUnlar bir Encapsulation uygulamayan, sadece RAM'den veri getiren veya RAM'e veri atayabilen property'lerdir...

        //Property'lerdeki get ve set görevleri:

        //get : İlgili property'den deger almaya calıstıgınızda calısan metottur..

        //set : İlgili property'nin deger atamasını istediginizde calısan bir metottur...


        public string Isim { get; set; } //Bu sekilde acılan property'e Auto-Property denir...Yani siz property'e hicbir görev vermemişsinizdir


        //-----------------------

        //Bir Encapsulation yapılacak ise Property kendisine kesinlikle hitap etmemelidir. Cünkü öyle yaparsa bu sizi StackOverflowException hatasına yonlendirir...Property'lerin hitap edecegi field artık özel olarak yaratılmak zorundadır. Cünkü property'e müdahale edildigi anda property runtime'de field yaratma kabiliyetini yitirir...

        //Field'lar standart olarak alttire ile baslar ve camelCase devam eder...Public veya internal olmamalıdırlar...

        decimal _fiyat = 0; //global alandaki degişkenlere field deriz...
        public decimal Fiyat
        {
            get //get geriye deger döndüren bir metottur...
            {
                //Dilerseniz burada _fiyat ile ilgili modifikasyon yapabilirsiniz

                //Eger siz get'te veya set'te herhangi bir kontrol algoritması veya müdahale algoritması yapmıyorsanız o zaman yazdıgınız syntax kesinlikle bir Encapsulation algoritması olmaz...
                if (_fiyat <= 0)
                {
                    MessageBox.Show($"Dikkat edin. Ürün fiyatı bilgisinde bir yanlıslık tespit edilgi icin (muhtemelen veritabanındaki veri corrupt oldu veya yanlıs girildi dısarıdan size gelen fiyat {_fiyat}) program bunu default fiyata cekecektir...Dilerseniz veritabanı uzmanınızla bunu görüsün");
                    _fiyat = 10;


                }
                return _fiyat;
            }




            set  //Deger atayan bir metottur. Geriye deger döndürmez...Set, aldıgı deger value keyword'u ile anlar
            {
                if (value <= 0)
                {
                    throw new Exception("Yanlıs fiyat girişi"); //throw new Exception() ; ifadesi yeni bir Exception nesnesi yaratarak (instance'i alarak) bunu programa fırlattırmaktır.
                }
                _fiyat = value;
            }


        }




       








    }
}
