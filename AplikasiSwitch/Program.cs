using System;

namespace AplikasiSwitch
{


    /// <summary>
    /// kelas persegi panjang
    /// </summary>
    public class PersegiPanjang
    {
        /// <summary>
        ///deklarasi variabel global panjang dan lebar
        /// </summary>
        public double panjang, lebar;

        /// <summary>
        /// membuat method berupa prosedur untuk input variabel yang diketahui
        /// </summary>
        public void sisiPP()
        {
            Console.Write("Masukkan panjang = ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar = ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Membuat method berupa fungsi untuk menghitung luas
        /// </summary>
        /// <param name="p">nilai inputan panjang</param>
        /// <param name="l">nilai inputan lebar</param>
        /// <returns></returns>
        public double LuasPP(double p, double l)
        {
            return p * l;
        }
        /// <summary>
        ///membuat method berupa prosedur untuk menampilkan data luas persegi panjang
        /// </summary>
        public void tampilPP()
        {
            Console.WriteLine("Luas Persegi panjang = " + this.LuasPP(panjang, lebar));
            Console.ReadKey();
        }
    }

    /// <summary>
    /// kelas segitiga
    /// </summary>
    public class Segitiga
    {
        /// <summary>
        /// deklarasi variabel global alas dan tinggi
        /// </summary>
        public double alas, tinggi;

        /// <summary>
        /// membuat method input alas dan tinggi
        /// </summary>
        public void sisiS3()
        {
            Console.Write("Masukkan alas = ");
            alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi = ");
            tinggi = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Membuat method berupa fungsi untuk menghitung luas
        /// </summary>
        /// <param name="a">nilai inputan alas</param>
        /// <param name="t">nilai inputan tinggi</param>
        /// <returns></returns>
        public double LuasS3(double a, double t)
        {
            return 0.5 * a * t;
        }
        /// <summary>
        /// membuat method berupa prosedur untuk menampilkan data luas segitiga
        /// </summary>
        public void tampilS3()
        {
            Console.WriteLine("Luas Segitiga = " + this.LuasS3(alas, tinggi));
            Console.ReadKey();
        }
    }

    /// <summary>
    /// main kelas program
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            //membuat instance untuk klas PersegiPanjang, klas Ligkaran dan klas Segitiga
            PersegiPanjang pp = new PersegiPanjang();
            Segitiga s3 = new AplikasiSwitch.Segitiga();

            //deklarasi variabel untuk ekspresi Switch
            int pilih;
            //membuat tampilan Menu
            Console.WriteLine("MENU");
            Console.WriteLine("----");
            Console.WriteLine("1. Luas Persegi Panjang");
            Console.WriteLine("2. Luas Segitiga");
            Console.WriteLine("3. Keluar");
            Console.Write("Pilihan (1/2/3) : ");
            pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (pilih)
            {
                case 1:
                    pp.sisiPP();
                    pp.tampilPP();
                    break;
                case 2:
                    s3.sisiS3();
                    s3.tampilS3();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Pilihan salah !");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
