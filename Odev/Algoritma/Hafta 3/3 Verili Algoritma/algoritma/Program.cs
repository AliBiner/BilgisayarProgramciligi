
Console.WriteLine("1.Sayıyı Giriniz:");
int s1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2.Sayıyı Giriniz:");
int s2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3.Sayıyı Giriniz:");
int s3 = Convert.ToInt32(Console.ReadLine());


int k = 0;
int orta = 0;
int enb = 0;

//En Büyük Sayı Bulma
if (s1>=s2 && s1>=s3)
{
    enb = s1;
}
else if (s2>=s1 && s2>=s3)
{
    enb = s2;
}
else if (s3 >= s2 && s3 >= s1)
{
    enb=s3;
}


//En Büyüğün s1 Olma İhtimaline Göre  Orta ve Küçüğü Bulma
if (enb==s1 && s2>=s3)
{
    orta = s2;
    k = s3;
}
else if (enb == s1 && s3 >=s2)
{
    orta = s3;
    k = s2;
}


//En Büyüğün s2 Olma İhtimaline Göre Orta ve Küçüğü Bulma
if (enb == s2 && s1 >= s3)
{
    orta = s1;
    k = s3;
}
else if(enb == s2 && s3 >= s1)
{
    orta = s3;
    k = s1;
}


//En Büyüğün s3 Olma İhtimaline Göre Orta ve Küçüğü Bulma
if (enb == s3 && s2 >= s1)
{
    orta = s2;
    k = s1;
}
else if (enb == s3 && s1 >= s2)
{
    orta = s1;
    k = s2;
}

Console.WriteLine("\n {0} \n {1} \n {2} ",enb,orta,k);
Console.ReadLine();
