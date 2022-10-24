int[] sayilar = new int[5];
sayilar[0] = 10;
sayilar[1] = 20;
sayilar[2] = 30;
sayilar[3] = 40;
sayilar[4] = 50;


for (int i = 0; i < sayilar.Length; i++)
{
    Console.WriteLine(sayilar[i]);
}



foreach (int x in sayilar)
{
    Console.WriteLine(x);
}


int j = 0;
while (j < sayilar.Length)
{
    Console.WriteLine(sayilar[j]);
    j++;
}


int s = 0;
do
{
    Console.WriteLine(sayilar[s]);
    s++;
}
while (s < sayilar.Length);


//çift sayiları yazdır ve topla...
int toplam = 0;
foreach (int x in sayilar)
{
    if (x % 2 == 0)
    {
        toplam = x + toplam;
        Console.WriteLine("Toplam : " + toplam);
    }

}