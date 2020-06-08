using System;

namespace SK_Kendaraan__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string jenisKendaraan = "";
            string modelKendaraan = "";
            string platNomor = "";
            string noRegistrasi = "";
            int thnPembuatan = 0;

            jenisKendaraan = "Mobil";
            modelKendaraan = "BMW i8 Roadster";
            platNomor = "AB 1234 XYZ";
            thnPembuatan = 2007;

            Console.WriteLine(jenisKendaraan);
            Console.WriteLine(modelKendaraan);
            Console.WriteLine("Diproduksi Tahun {0}.", thnPembuatan);
            Console.WriteLine("Plat Nomor : " + platNomor + "-- No Registrasi " + noRegistrasi);

            Console.Read();
        }
    }
}
