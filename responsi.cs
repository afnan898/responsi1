using System;

namespace ResponsiPemrograman2673
{
    class Program
    {
        static void Main(string[] args)
        {

            karyawan karyawan1 = new karyawan(1, 11111111, "Afnan Rifqi F",   20000000);
            karyawan karyawan2 = new karyawan(2, 22222222, "Firmansyah Rifqi", 15000000);
            
            Console.WriteLine("\n\n Gaji Pokok");

            Console.WriteLine("No \t NIK \t nama \t gaji");
            Console.WriteLine("--------------------------");
            karyawan1.showkaryawan();
            karyawan2.showkaryawan();

            Console.WriteLine("\n\n Gaji Naik 10%");

            Console.WriteLine("No \t NIK \t nama \t gaji");
            Console.WriteLine("--------------------------");
            karyawan1.naikgaji();
            karyawan2.naikgaji();

            Console.ReadKey();
        }
    }

    class karyawan
    {
        public int No {get; set;}
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajibulanan { get; set; }

        public karyawan(int No,int nik, string nama, int gajibulanan)
        {
            this.No = No;
            this.nik = nik;
            this.nama = nama;

            if (gajibulanan < 0)
            {
                this.gajibulanan = 0;
            }
            else
            {
                this.gajibulanan = gajibulanan;
            }
        }

        public void showkaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2} \t {3}",No, nik, nama, gajibulanan);
        }

        public void naikgaji()
        {
            double tmp = 0;
            tmp = 0.1 * gajibulanan;
            gajibulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2} \t {3}",No, nik, nama, gajibulanan);
        }
        
    }
}