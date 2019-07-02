using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agregasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawanl = new Karyawan();
            karyawanl.Nama = "Paijo";
            Karyawan karyawan2 = new Karyawan();
            karyawan2.Nama = "Jhono";
            Perusahaan perusahaan = new Perusahaan();
            perusahaan.DaftarKaryawan.Add(karyawanl);
            perusahaan.DaftarKaryawan.Add(karyawan2);
            int noUrut = 1;
            Console.WriteLine("Daftar karyawan:");
            foreach (Karyawan karyawan in perusahaan.DaftarKaryawan)
            {
                Console.WriteLine("{0}. {1}", noUrut, karyawan.Nama);
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}
