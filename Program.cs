namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ürünler = { "fanta", "kola", "çikolata" };
            double[] fiyatlar = { 40, 40, 30 };
            int many = 40;

            while (true)
            {
                for (int i = 0; i < ürünler.Length; i++)
                {

                    Console.Write($"{i + 1}");
                    Console.Write(ürünler[i]);
                    Console.Write($"{fiyatlar[i]}TL\n");
                }
                Console.WriteLine("Ürün numarasını giriniz");
                int numara = Convert.ToInt32(Console.ReadLine());

                if (numara == 1)
                {
                    Console.WriteLine("Para girişi yapınız");
                    int para = Convert.ToInt32(Console.ReadLine());

                    if (para == many)
                    {
                        Console.WriteLine("Afiyet olsun");
                    }
                    else if (para > many)
                    {
                        Console.WriteLine("Afiyet olsun Para üstü:10 alınız");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye");
                        Console.WriteLine("1-Para ekle\n2-Para iade");
                        int sayi = Convert.ToInt32(Console.ReadLine());

                        if (sayi == 1)
                        {
                            Console.WriteLine("En az 40tl olucak şekilde para ekleyebilirsiniz");
                            int ekle = Convert.ToInt32(Console.ReadLine());
                            if (ekle == many)
                            {
                                Console.WriteLine("Paranız başarılı bir şekilde eklenmiştir");
                            }
                            else
                            {
                                Console.WriteLine("Tekrar deneyiniz");
                            }
                        }
                        else if (sayi == 2)
                        {
                            Console.WriteLine("Paranız İade edildi");
                        }
                        else
                        {
                            Console.WriteLine("Hatalı sayı girdiniz.Tekrar dinleyiniz");
                        }
                    }
                }
                else if (numara == 2)
                {
                    Console.WriteLine("Para girişi yapınız");
                    int para = Convert.ToInt32(Console.ReadLine());

                    if (para == many)
                    {
                        Console.WriteLine("Afiyet olsun");
                    }
                    else if (para > many)
                    {
                        Console.WriteLine("Afiyet olsun Para üstü:10 alınız");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye");
                        Console.WriteLine("1-Para ekle\n2-Para iade");
                        int sayi = Convert.ToInt32(Console.ReadLine());

                        if (sayi == 1)
                        {
                            Console.WriteLine("En az 40tl olucak şekilde para ekleyebilirsiniz");
                            int ekle = Convert.ToInt32(Console.ReadLine());
                            if (ekle == many)
                            {
                                Console.WriteLine("Paranız başarılı bir şekilde eklenmiştir");
                            }
                            else
                            {
                                Console.WriteLine("Tekrar deneyiniz");
                            }
                        }
                        else if (sayi == 2)
                        {
                            Console.WriteLine("Paranız İade edildi");
                        }
                        else
                        {
                            Console.WriteLine("Hatalı sayı girdiniz.Tekrar dinleyiniz");
                        }
                    }
                }
                else if (numara == 3)
                {
                    Console.WriteLine("Para girişi yapınız");
                    int para = Convert.ToInt32(Console.ReadLine());

                    if (para == many)
                    {
                        Console.WriteLine("Afiyet olsun");
                    }
                    else if (para > many)
                    {
                        Console.WriteLine("Afiyet olsun Para üstü:10 alınız");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye");
                        Console.WriteLine("1-Para ekle\n2-Para iade");
                        int sayi = Convert.ToInt32(Console.ReadLine());

                        if (sayi == 1)
                        {
                            Console.WriteLine("En az 40tl olucak şekilde para ekleyebilirsiniz");
                            int ekle = Convert.ToInt32(Console.ReadLine());
                            if (ekle == many)
                            {
                                Console.WriteLine("Paranız başarılı bir şekilde eklenmiştir");

                            }
                            else
                            {
                                Console.WriteLine("Tekrar deneyiniz");
                            }
                        }
                        else if (sayi == 2)
                        {
                            Console.WriteLine("Paranız İade edildi");
                        }
                        else
                        {
                            Console.WriteLine("Hatalı sayı girdiniz.Tekrar dinleyiniz");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı sayı girdiniz.Tekrar deneyiniz");
                }


                while (true)
                {
                    Console.WriteLine("Admin Paneline Hoşgeldiniz");
                    int admin = Convert.ToInt32(Console.ReadLine());

                    if (admin == many)
                    {
                        Console.WriteLine("1-Yeni ürün Ekle\n2-Ürün Güncelle\n3-Ürün Sil\n4-Ürün Listele\n5-Günsonu Toplam satış");
                        int urun = Convert.ToInt32(Console.ReadLine());
                        if (urun == 1)
                        {
                            Console.WriteLine("Ürün Adı:");
                            string yeniürün = Console.ReadLine();
                            Console.WriteLine("Ürün Fiyatı:");
                            double fiyat = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ürün başarılı bir şekilde eklenmiştir");

                            int bosIndex = -1;
                            for (int i = 0; i < ürünler.Length; i++)
                            {
                                if (fiyatlar[i] == 0) { bosIndex = i; break; }
                            }

                            if (bosIndex != -1)
                            {
                                ürünler[bosIndex] = yeniürün;
                                fiyatlar[bosIndex] = fiyat;
                            }
                            else
                            {
                                Array.Resize(ref ürünler, ürünler.Length + 1);
                                Array.Resize(ref fiyatlar, fiyatlar.Length + 1);

                                ürünler[ürünler.Length - 1] = yeniürün;
                                fiyatlar[fiyatlar.Length - 1] = fiyat;
                            }
                            Console.Clear();
                        }
                    }
                }   
            }            
        }
    }
}
