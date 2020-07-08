using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program

                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih menu aplikasi");
            Console.WriteLine("1. Tambah penjualan");
            Console.WriteLine("2. Hapus penjualan");
            Console.WriteLine("3. Tampilkan penjualan");
            Console.WriteLine("4. Keluar");

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            int nota;
            string tanggal, nama, jenis;
            double total;

            Console.WriteLine("Tambah data penjualan");
            Console.Write("Nota : ");
            nota = int.Parse(Console.ReadLine());
            Console.WriteLine("Tanggal : ");
            tanggal = Console.ReadLine();
            Console.WriteLine("Customer : ");
            nama = Console.ReadLine();
            Console.WriteLine("Jenis [T/K] : ");
            jenis = Console.ReadLine();
            Console.WriteLine("Total Nota : ");
            total = double.Parse(Console.ReadLine());
            daftarPenjualan.Add(new Penjualan() { Nota = nota, Tanggal = tanggal, Nama = nama, Jenis = jenis, Total = total });


            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();
            bool ada = false;
            Console.WriteLine("Hapus Penjualan");
            int hapus;
            Console.WriteLine("Nota : ");
            hapus = int.Parse(Console.ReadLine());

            int x = 0;
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                if (hapus == penjualan.Nota)
                {
                    daftarPenjualan.RemoveAt(x);
                    break;
                }
                x++;
            }
            if(ada)
            {
                daftarPenjualan.RemoveAt(x);
                Console.WriteLine("Data berhasil dihapus");
            }
            else
            {
                Console.WriteLine("Data tidak ditemukan");
            }
            x = 0;

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Data Penjualan");
            int no = 1;


            {
                foreach (Penjualan penjualan in daftarPenjualan)
                {
                    if (penjualan.Jenis == "T" || penjualan.Jenis == "t")
                    {
                        Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                        no, penjualan.Nota, penjualan.Tanggal, penjualan.Nama, penjualan.Jenis="Tunai", penjualan.Total); ;
                        no++;
                    }
                    else if (penjualan.Jenis == "K" || penjualan.Jenis == "k")
                    {
                        Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                        no, penjualan.Nota, penjualan.Tanggal, penjualan.Nama, penjualan.Jenis = "Kredit", penjualan.Total); ;
                        no++;
                    }
                }

            }


            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
    

