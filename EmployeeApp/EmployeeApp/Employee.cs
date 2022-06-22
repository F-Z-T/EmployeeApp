using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class Employee
    {
        private string _ad;
        public string Ad
        {
            get { return _ad.ToUpper(); }
            set
            {
                _ad = value;
            }
        }
        private string _soyad;
        public string Soyad
        {
            get { return _soyad.ToUpper(); }
            set { _soyad = value; }

        }

        private DateTime _dogumTarihi;
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set
            {
                if (value > DateTime.Now)
                {
                    System.Windows.Forms.MessageBox.Show("Hatali Tarih");
                }
                else
                {
                    _dogumTarihi=value;
                }
            }
        }

        private DateTime _iseGirisTarihi;
        public DateTime IseGirisTarihi
        {
            get { return _iseGirisTarihi; }
            set
            {
                _iseGirisTarihi = value;
            }
        }

        private string _departman;
        public string Departman
        {
            get { return _departman; }
            set { _departman = value; }
        }

        public override string ToString()
        {
            return this.Ad + " " + this.Soyad;
        }

    }
}
