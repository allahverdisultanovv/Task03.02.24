//Verilmish 2 mertebeli ededin en boyuk reqemini tapan algorithm misal: input 25, output 5

Console.WriteLine("ikireqemli eded daxil edin");
int num = Convert.ToInt32(Console.ReadLine());
if (num / 10 > num % 10)
{
    Console.WriteLine("Ededin boyuk reqemi:" + num / 10);
}
else if (num / 10 < num % 10)
{
    Console.WriteLine("Ededin boyuk reqemi:" + num % 10);

}
else
{
    Console.WriteLine("Daxil etidiyiniz ededin reqemleri eynidir");
}