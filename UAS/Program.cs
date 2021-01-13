using System;

namespace UAS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop == true)
            {
                Console.Clear();

                JUDUL();

                Console.WriteLine("Pemain min 2 max 4");
                Console.Write("Berapa pemain: ");
                int jumlahpemain = Convert.ToInt32(Console.ReadLine());

                if (jumlahpemain < 2)
                {
                    Console.Clear();
                    JUDUL();
                    
                    Console.WriteLine("Masukkan jumlah pemain yang benar!!");
                    Console.WriteLine("Tekan enter untuk melanjutkan");
                    Console.ReadKey();
                }
                if (jumlahpemain > 4)
                {
                    Console.Clear();
                    JUDUL();
                    
                    Console.WriteLine("Kebanyakan yang maen!!");
                    Console.WriteLine("Tekan enter untuk melanjutkan");
                    Console.ReadKey();
                }

                string[] namapemain = new string[jumlahpemain];

                if (jumlahpemain > 1 && jumlahpemain < 5)
                {
                    Console.Clear();
                    JUDUL();

                    
                    for (int i = 0; i < jumlahpemain; i++)
                    {
                        Console.Write("Masukkan nama player ke " + (i + 1) + ": ");
                        namapemain[i] = Console.ReadLine();
                    }

                    Console.WriteLine();

                    Console.Clear();

                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    string[] KARAKTER = new string[11];
                    KARAKTER[1] = "\u25A0";
                    KARAKTER[2] = "\u2660";
                    KARAKTER[3] = "\u2665";
                    KARAKTER[4] = "\u25B2";
                    KARAKTER[5] = "\u2666";
                    KARAKTER[6] = "\u2663";
                    KARAKTER[7] = "●";
                    KARAKTER[8] = "☻";
                    KARAKTER[9] = "♫";
                    KARAKTER[10] = "☼";

                    
                    string[] karakterpemain = new string[5];
                    int pilihkarakter = 0;

                    for (int i = 0; i < jumlahpemain; i++)
                    {
                        JUDUL();
                        

                        Console.WriteLine("Pilih karakter " + namapemain[i]);

                        for (int k = 1; k <= 10; k++)
                        {
                            Console.Write((k) + "." + KARAKTER[k] + "  ");
                        }

                        Console.WriteLine();

                        Console.Write("Karakter pilihan " + namapemain[i] + ": ");
                        pilihkarakter = Convert.ToInt32(Console.ReadLine());

                        karakterpemain[i] = KARAKTER[pilihkarakter];

                        Console.Clear();
                    }

                    JUDUL();
                    

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string maribermain = "MARI KITA BERMAINN!!";
                    Console.SetCursorPosition((Console.WindowWidth - maribermain.Length) / 2, Console.CursorTop);
                    Console.Write(maribermain);
                    Console.ResetColor();
                    Console.ReadKey();



                }
                
                
                

                
            }
            
        }

        static void JUDUL()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            string judul = "Uler Tangga";
            Console.SetCursorPosition((Console.WindowWidth - judul.Length) / 2, Console.CursorTop);
            Console.WriteLine(judul);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            string garis = "============================================================================================";
            Console.SetCursorPosition((Console.WindowWidth - garis.Length) / 2, Console.CursorTop);
            Console.Write(garis);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Dadu()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);

            //for (int dadu = 1; dadu <= 6; dadu++)
            {
                for (int i = 0; i < 8; i++) // kebawah
                {
                    for (int j = 0; j < 11; j++) // ke kanan
                    {
                        if (dice == 1)
                        {
                            if (i == 2 || i == 5 || j == 3 || j == 7)
                            {
                                Console.Write(".");
                            }
                            else if (j == 1 || j == 5 || j == 9)
                            {
                                Console.Write(" ");
                            }
                            else if (i > 2 && i < 5 && j > 3 && j < 7)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("#");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else if (dice == 2)
                        {
                            if (i == 2 || i == 5 || j == 3 || j == 7)
                            {
                                Console.Write(".");
                            }
                            else if (j == 1 || j == 5 || j == 9)
                            {
                                Console.Write(" ");
                            }
                            else if (i > 2 && i < 5 && j < 3 || i > 2 && i < 5 && j > 7)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("#");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else if (dice == 3)
                        {
                            if (i == 2 || i == 5 || j == 3 || j == 7)
                            {
                                Console.Write(".");
                            }
                            else if (j == 1 || j == 5 || j == 9)
                            {
                                Console.Write(" ");
                            }
                            else if (i > 2 && i < 5 && j > 3 && j < 7 || i < 2 && j > 7 || i > 5 && j < 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("#");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else if (dice == 4)
                        {
                            if (i == 2 || i == 5 || j == 3 || j == 7)
                            {
                                Console.Write(".");
                            }
                            else if (j == 1 || j == 5 || j == 9)
                            {
                                Console.Write(" ");
                            }
                            else if (i < 2 && j < 3 || i < 2 && j > 7 || i > 5 && j < 3 || i > 5 && j > 7)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("#");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else if (dice == 5)
                        {
                            if (i == 2 || i == 5 || j == 3 || j == 7)
                            {
                                Console.Write(".");
                            }
                            else if (j == 1 || j == 5 || j == 9)
                            {
                                Console.Write(" ");
                            }
                            else if (i < 2 && j < 3 || i < 2 && j > 7 || i > 5 && j < 3 || i > 5 && j > 7 || i > 2 && i < 5 && j > 3 && j < 7)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("#");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        else if (dice == 6)
                        {

                            if (i == 2 || i == 5 || j == 3 || j == 7)
                            {
                                Console.Write(".");
                            }
                            else if (j == 1 || j == 5 || j == 9)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("#");
                                Console.ResetColor();
                            }

                        }

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static void Papan()
        {
            string[] kotak = new string[100];
            for (int n = 0; n < 100; n++)
            {
                kotak[n] = "*";
            }
            int nomorkotak = 100;
            for (int m = 0; m < 10; m++) // 10x kebawah
            {
                if (m % 2 == 0 && m != 0)
                {
                    nomorkotak -= 1;
                }
                else if (m % 2 != 0 && m != 0)
                {
                    nomorkotak -= 19; // untuk kotak di baris berikutnya agar mempunyai angka yang berbeda
                }
                for (int k = 0; k < 4; k++) // 4x kebawah
                {
                    for (int j = 0; j < 10; j++) // 10x ke kanan
                    {
                        if (k == 0)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write(kotak[nomorkotak - 1] + " ");
                            }
                            if (nomorkotak == 100)
                            {
                                Console.Write(nomorkotak + " ");
                            }
                            else if (nomorkotak < 10)
                            {
                                Console.Write(nomorkotak + "   ");
                            }
                            else
                            {
                                Console.Write(nomorkotak + "  ");
                            }
                        }
                        else if (k == 1)
                        {
                            Console.Write(kotak[nomorkotak - 1] + " ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("1" + " ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("2" + " ");
                            Console.ResetColor();
                            Console.Write(kotak[nomorkotak - 1] + "   ");

                        }
                        else if (k == 2)
                        {
                            Console.Write(kotak[nomorkotak - 1] + " ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("3" + " ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("4" + " ");
                            Console.ResetColor();
                            Console.Write(kotak[nomorkotak - 1] + "   ");

                        }
                        else
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                Console.Write(kotak[nomorkotak - 1] + " ");
                            }
                            Console.Write(kotak[nomorkotak - 1] + "   ");
                        }
                        if (m % 2 == 0)
                        {
                            nomorkotak--;
                        }
                        else
                        {
                            nomorkotak++;
                        }
                    }
                    if (m % 2 == 0)
                    {
                        nomorkotak += 10;
                    }
                    else
                    {
                        nomorkotak -= 10; // untuk bintang di dalam kotak berada di array yang sama
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
        
