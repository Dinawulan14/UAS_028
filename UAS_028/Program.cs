using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_028
{
    internal class Program
    {
        public class BinariSearch
        { 
            string[] arr = new string[20];
            int n;
            public void read()
            {
                int i;
                while (true) ;
                {
                    Console.Write("\nMasukkan jumlah data :");
                    string s = Console.ReadLine();
                    n = Int32.Parse(s);
                    if ((n > 0) && (n <= 20))
                        break;
                    else
                        Console.WriteLine("\nArray yang harus disimpan minimal 1 data dan maksimal 20 data \n");
                }
                Console.WriteLine("=====================");
                Console.WriteLine("Masukkan jumlah data : ");
                Console.WriteLine("Masukkan nomor buku : ");
                Console.WriteLine("Masukkan judul buku : ");
                Console.WriteLine("Masukkan nama pengarang : ");
                Console.WriteLine("Masukkan tahun terbit :  ");
                for ( i = 0; i < n; i++)
                {
                    Console.WriteLine ("<" + (i + 1) + ">");
                    Console.Write("Nomor Buku :");
                    string NomorBuku = Console.ReadLine();
                    Console.Write("Judul Buku :");
                    string JudulBuku = Console.ReadLine();
                    Console.Write("Tahun Terbit :");
                    string s1 = Console.ReadLine();
                    arr[i] = (NomorBuku);
                    arr[i] = (JudulBuku);
                    arr[i] = (s1);
                }
            }
            public void Insertionsort()
            {
                //metode pengsortiran menggunakan insertion sort
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("");
                    Console.Write(arr[i] + "");
                }
                for (int i = 1; i < n; i++)
                {
                    string val = arr[i];
                    int flag = 0;
                    for (int j = i - 1; j >= 0 && flag != 1;)
                    {
                        if (string.Compare(val, arr[1]) < 0)
                        {
                            arr[j + 1] = arr[j];
                            j--;
                            arr[j + 1] = val;
                        }
                        else flag = 1;
                        }
                    }
                }
            public void bsearch(string item)
            {
                int lowerbound = 0;
                int upperbound = n - 1;

                int mid = (upperbound + lowerbound) / 2;
                int ctr = 1;
                //loop untuk mencari array dalam elemen
                while ((string.Compare(item, arr[mid]) != 0) && (lowerbound <= upperbound))
                {
                    if ((string.Compare(item, arr[mid j) > 0)
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1);
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
            }

            static void Main(string[] args)
            {
                Program x = new Program();
                while (true)
                {
                    Console.WriteLine("\n Menu");
                    Console.WriteLine("1. Nomor Buku :");
                    Console.WriteLine("2. Judul Buku :");
                    Console.WriteLine("3. Nama Pengarang :");
                    Console.WriteLine("4. Tahun Terbit :");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("6. Enter your Choice (1-5)");
                    char ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    }
                }
            }
        }
    }
