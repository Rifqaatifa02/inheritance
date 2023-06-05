using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{

    public class orang
    {
        public string nama { get; set; }

        public int umur { get; set; }


        public orang()
        {
            this.nama = "[belum diatur]";

            this.umur = 0;
        }

        public orang(string nama, int umur)
        {
            this.nama = nama;
            this.umur = 21;
        }
        public void InfoOrang()
        {
            Console.WriteLine("Hai Nama saya {0}, dan umur saya {1} tahun\n", nama, umur);
        }

        

    }
    public class Member : orang
    {
        public string jenis_kelamin { get; set; }
        public string jabatan { get; set; }
        public Member()
        {
            nama = "[belum diatur]";
            umur = 0;
        }
        public Member(string nama, int umur)
        {
            this.nama = nama;
            this.umur = umur;
        }

        public void InfoOrang(string jenis_kelamin, string jabatan)
        {
            this.nama = nama;
            this.jenis_kelamin = jenis_kelamin;
            this.jabatan = jabatan;

            Console.WriteLine("{0} berjenis kelamin {1} dan menjabat sebagai {2}", this.nama, this.jenis_kelamin, this.jabatan);
        }
    }
}
