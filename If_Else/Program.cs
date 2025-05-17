using System.ComponentModel.Design;

Console.WriteLine("Lütfen bir sayı giriniz.");
int sayı = Convert.ToInt32(Console.ReadLine());
if(sayı > 10)
{
    Console.WriteLine("10' dan büyüktür");
}
else if(sayı == 10)
{

    Console.WriteLine("sayınız 10'a eşittir");
}
else if(sayı < 10)
{
    Console.WriteLine("sayu 10'dan küçütür");
}
    int BölümündenKalan = sayı % 2;
if (BölümündenKalan == 0)
{

    Console.WriteLine("sayı çiftir");
}
else 
{
    Console.WriteLine("girdiğiniz sayı tektdir");

}