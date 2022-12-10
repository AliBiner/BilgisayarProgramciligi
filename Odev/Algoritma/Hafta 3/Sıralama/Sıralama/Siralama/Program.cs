





Console.WriteLine("Girilecek Sayı Adedini Yazınız:");
int numberPiece = Convert.ToInt32(Console.ReadLine());
int[] dataList = new int[numberPiece];

for (int i = 1; i <= numberPiece; i++)
{
    Console.WriteLine("{0}. Sayıyı Giriniz:",i);
    int temporaryData = Convert.ToInt32(Console.ReadLine());
    dataList[i-1] = temporaryData;


}


int temp;
for (int i = 0; i < numberPiece-1; i++)
{
    for (int j = 0; j < numberPiece-1; j++)
    {
        if (dataList[j] > dataList[j+1])
        {
            temp = dataList[j + 1];
            dataList[j + 1] = dataList[j];
            dataList[j] = temp;
        }
    }
}





for (int i = 0; i < numberPiece; i++)
{
    Console.WriteLine("{0}", dataList[i]);
}







