//Verilmish ededin 2 quvveti olub olmadigini tapan alqoritm misal:
//input 6, output quvveti deyil.  input 8 output quvvetidir

Console.WriteLine("Ededi dxil edin");
int num = Convert.ToInt32(Console.ReadLine());
bool f = true;
int temp = num;
while (num > 1)
{
    if (num % 2 == 1)
    {
        Console.WriteLine(temp + "-----ikinin derecesi deyil");
        f = false;
        break;
    }
    num /= 2;
}
if (f)
{
    Console.WriteLine(temp + "-----ikinin derecesidir");
}