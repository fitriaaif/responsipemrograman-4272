using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();
        static Penjualan penjualan = new Penjualan();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\n Nomor Menu [1..4] : ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("    RESPONSI PEMROGRAMAN    ");
            Console.WriteLine("============================\n");
            Console.WriteLine(" Pilihan Menu Aplikasi");
            Console.WriteLine(" 1. Tambah Penjualan");
            Console.WriteLine(" 2. Tampilkan Penjualan");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            penjualan = new Penjualan();
            string TK;

            Console.WriteLine(" Tambah Data Penjualan\n");

            Console.Write(" Nota        : ");
            penjualan.Nota = Console.ReadLine();

            Console.Write(" Tanggal     : ");
            penjualan.Tanggal = Console.ReadLine();

            Console.Write(" Customer    : ");
            penjualan.Customer = Console.ReadLine();

            Console.Write(" Jenis [T/K] : ");
            TK = Console.ReadLine();

            if (TK == "T")
            {
                penjualan.Jenis = "Tunai";
            } else if (TK == "K")
            {
                penjualan.Jenis = "Kredit";
            }

            Console.Write(" Total Nota  : ");
            penjualan.TotalNota = Console.ReadLine();

            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\n Tekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            int no = 1;
            Console.WriteLine(" Data Penjualan\n");

            foreach (Penjualan objJual in daftarPenjualan)
            {
                Console.WriteLine(" {0}. {1},  {2},  {3},  {4},  {5}", no, objJual.Nota, objJual.Tanggal, objJual.Customer, objJual.Jenis, objJual.TotalNota);
                no++;
            }

            Console.WriteLine("\n Tekan enter untuk kembali ke menu");
            Console.ReadKey();            
        }
        /*Nama  : Fitria Amanda Imas Fahriendi
              NIM   : 21.11.4272
              Kelas : 21 IF 07 */
    }
}
