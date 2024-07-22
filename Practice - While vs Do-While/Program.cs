//Bu pratikte kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırfım. (WHILE)

Console.WriteLine("Lütfen bir limit değeri giriniz");

int limit = Convert.ToInt32(Console.ReadLine());

int deger = 0;
                                                                  // While'da kontrol döngünün başında yapıldı.
while (deger <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    deger++;
}

Console.WriteLine("--------------------------------------------------------------");


Console.WriteLine("Lütfen bir limit değeri giriniz");

int limit = Convert.ToInt32(Console.ReadLine());
int sayi = 0;
                                                                  // do whlie döngüsünde ise konrol işlem sonunda yapılıyor. Yani koşul yanlış olsa bile 'do' her zaman çalışıyor. 
do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayi++;

}while( sayi <= limit);