using System;
using System.IO;

namespace UAS_005
{
    public class Data 
    {
        private object sw;

        public void DataBarang()
        {
            //mendeklarasikan atau mendefinisikan variabel data menggunakan array
            string[] ID  = new string[35];
            string[] Nama  = new string[35];
            string[] Jenis  = new string[35];
            string[] Harga = new string[35];

            int i, n = 0;
            //menginput jumlah data Siswa yang ingin diinputkan 
            Console.WriteLine("     Data Barang Elektronik     ");
            Console.WriteLine("=================================");
            Console.Write("Masukkan Jumlah Barang =  ");
            Console.Write("\n");
            n = int.Parse(Console.ReadLine());
            //mengisi data yang diinputkan user dengan perulangan for 
            for (i = 1; i <= n; i++)
            {
                //menampilkan 'Masukkan Data Siswa ke-' variabel i
                Console.WriteLine("Masukkan Data Barang ke-" + i);
                Console.WriteLine("===========================");
                Console.Write('\n');
                //menampilkan Masukkan ID Barang
                Console.Write("Masukkan ID Barang = ");
                ID[i] = Console.ReadLine();
                //menampilkan Masukkan Nama Barang
                Console.Write("Masukkan Nama Barang = ");
                Nama[i] = Console.ReadLine();
                //menampilkan Masukkan Jenis Barang
                Console.Write("Masukkan Jenis Barang = ");
                Jenis[i] = Console.ReadLine();
                //menampilkan Masukkan Harga Barang
                Console.Write("Masukkan Harga Barang = ");
                Harga[i] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Data Telah Dimasukkan, Tekan Sembarang Untuk Menampilkan Data");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("          Data Barang Yang Telah Anda Inputkan          ");
            Console.WriteLine("====================================================================");
            Console.Write("\n");
            Console.WriteLine("NO  |  ID Barang  |  Nama Barang  |  Jenis Barang  |  Harga Barang ");

            //menampilkan hasil dari data yang telah dimasukkan oleh user dengan perulangan for 
            for (i = 1; i <= n; i++)
            { 
                Console.WriteLine(" " + i + "     " + ID[i] + "\t           "+ Nama[i] + "\t         " + Jenis[i] + "\t            "+ Harga[i] + "\t" );
            }
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                StreamWriter sw = new StreamWriter(Path.Combine(path, $"Administrasi Barang.txt"));
                sw.WriteLine("NO  |  ID Barang  |  Nama Barang  |  Jenis Barang  |  Harga Barang  ");
                for (i = 1; i <= n; i++)
                {
                    sw.WriteLine(" " + i + "     " + ID[i] + "\t            "+ Nama[i] + "\t            " + Jenis[i] + "\t               "+ Harga[i] + "\t");
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e.Message);
            }


            Console.WriteLine();
            Console.Write("Tekan 'ENTER' untuk keluar.....");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //memanggil class administrasi siswa
            Data Brng = new Data();
            Brng.DataBarang();
        }
    }
}

/*
 * 1. ( PROGRAM DIATAS )
 * 2. Singluary List
 * 3. Rear dan Front
 * 4. 5 Struktur
 * 5. Inorder ( 15,20,25,30,31,32,35,48,50,65,66,67,69,70,90,94,98,99)
 */