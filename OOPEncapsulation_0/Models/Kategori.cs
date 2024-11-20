using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEncapsulation_0.Models
{
    public class Kategori
    {
        //CategoryName'in metninin 8 karakterden az olmamasını saglayın...metin.Length size int tipinde karakter sayısını döndürür...Eger textbox'tan girilen CategoryName 8 karakterden azsa karakter sayısı en az 8 olmalıdır runtime hatası verilsin

        //Encapsulation yapmamızın 3 Yöntemi vardır:

        //1 => Property Based Encapsulation

        //2 => Customized Encapsulation

        //3 => Constructor Based Encapsulation

        //public Kategori(string kategoriIsmi) //Constructor Based Encapsulation
        //{
        //    if (kategoriIsmi.Length < 8) throw new Exception("8 karakterden az kategori ismi ile baslayamazsınız");
        //    KategoriIsmi  = kategoriIsmi;

        //}
        public Kategori()
        {

        }

        string _kategoriIsmi;



        public void SetKategoriIsmi(string value)
        {
            if(value.Length < 8)
            {
                throw new Exception("Kategori ismi 8 karakterden az olamaz");
            }
            _kategoriIsmi = value;
        }

        public string GetKategoriIsmi()
        {
            return _kategoriIsmi;
        }




        #region PropertyBased
        public string KategoriIsmi
        {
            get
            {
                return _kategoriIsmi;
            }


            set
            {
                if (value.Length < 8)
                {
                    throw new Exception("Kategori ismi en az 8 karakter olmalıdır");
                }
                _kategoriIsmi = value;
            }
        }
        #endregion




    }
}
