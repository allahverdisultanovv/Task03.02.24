// Verilmish ededin sade ve ya murekkeb oldugunu tapan alqoritm
#region SingleOrCompound
//Console.WriteLine("Ededi daxil edin");
//int num = Convert.ToInt32(Console.ReadLine());
//int i = 2;
//bool f = true;
//while (i <= num / 2)
//{
//    if (num % i == 0)
//    {
//        Console.WriteLine("Eded murekkebdir");
//        f = false;
//        break;
//    }
//    i++;
//}
//if (f)
//{
//    Console.WriteLine("Eded sadedir");
//} 
#endregion

Console.WriteLine("Ededi daxil edin");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;
bool f = true;
while (i <= Math.Sqrt(num))
{
    if (num % i == 0)
    {
        Console.WriteLine("Eded murekkebdir");
        f = false;
        break;
    }
    i++;
}
if (f)
{
    Console.WriteLine("Eded sadedir");
}