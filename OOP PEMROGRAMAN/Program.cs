using System;
using System.Collections.Generic;
using TugasOOP.Anak;
using TugasOOP.Induk;

namespace TugasOOP
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //deklarasi objek
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "19.11.2683";
            karyawanTetap.Nama = "Muhammad";
            karyawanTetap.GajiBulanan = 13000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "73849283458234";
            karyawanHarian.Nama = "Qomaruzzaman";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 200000;

            Sales sales = new Sales();
            sales.Nik = "9283428394";
            sales.Nama = "QOMAR";
            sales.JumlahPenjualan = 60;
            sales.Komisi = 4000;
            

            //object class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);
            

            //loop
            int nomor = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine(" {0}.NIK: {1}\nNama: {2} \nGaji: {3:N0}\n",
                    nomor, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                nomor++;
            }
            

           

        }
    }
}