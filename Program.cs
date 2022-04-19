using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman4370
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Karyawan 1
            Karyawan karyawan1 = new Karyawan();

            // pengesetan properties
            karyawan1.NIK = "21114370";
            karyawan1.NAMA = "Valen";
            karyawan1.GajiBulanan = 3000000;

            // membuat objek Karyawan 2
            Karyawan karyawan2 = new Karyawan();

            // pengesetan properties
            karyawan2.NIK = "21114374";
            karyawan2.NAMA = "Sonny";
            karyawan2.GajiBulanan = 2000000;

            //pemanggilan method
            Console.WriteLine("No. \tNik\tNama\t\tGaji Bulanan");
            Console.WriteLine("\n");
            Console.WriteLine("========PEMBAYARAN GAJI KARYAWAN========");
            Console.WriteLine("\n");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.GajiBulanan);
            Console.WriteLine("2. \t{0} {1}\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.GajiBulanan);
            Console.WriteLine("\n");
            Console.WriteLine("ASIIK NAIK GAJI 10%!! ");
            Console.WriteLine("\n");
            Console.WriteLine("========KENAIKAN GAJI 10%========");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.GajiBulanan + (karyawan1.GajiBulanan * 0.10));
            Console.WriteLine("2. \t{0} {1}\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }

}

